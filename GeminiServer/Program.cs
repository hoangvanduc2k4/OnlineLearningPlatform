using System.Net;
using System.Net.Sockets;
using System.Text;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Server;

namespace GeminiServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();
            string apiKey = config["GeminiApiKey"];
            if (string.IsNullOrEmpty(apiKey))
            {
                Console.WriteLine("Error: Please set GeminiApiKey in user secrets.");
                return;
            }

            var httpClient = new HttpClient();
            var geminiService = new GeminiService(httpClient, apiKey);

            string host = "127.0.0.1";
            int port = 8080;
            StartServer(host, port, geminiService);
        }

        static void StartServer(string host, int port, GeminiService geminiService)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(host);
                var server = new TcpListener(ip, port);
                server.Start();
                Console.WriteLine($"Server running at {host}:{port}");

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Task.Run(() => HandleClient(client, geminiService));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Server error: {ex.Message}");
            }
        }

        static void HandleClient(TcpClient client, GeminiService geminiService)
        {
            try
            {
                using var stream = client.GetStream();
                using var reader = new StreamReader(stream, Encoding.UTF8);
                using var writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };

                string data = reader.ReadLine();
                string response = "{}";

                if (!string.IsNullOrEmpty(data))
                {
                    try
                    {
                        dynamic request = JsonConvert.DeserializeObject(data);
                        string action = request?.action;

                        switch (action)
                        {
                            case "mentor/generate-lesson-content":
                                var description = (string)request.description;
                                var lessonPrompt = $"Provide a concise outline of key topics to learn about '{description}'. List main sections with core concepts and brief descriptions (1-2 sentences each). Include a short introduction and conclusion on practical applications. Use professional language matching the input. Limit to 100-200 words. No markdown, no labels, plain text only.";
                                response = JsonConvert.SerializeObject(new { content = geminiService.CallGemini(lessonPrompt) });
                                break;

                            case "mentor/generate-questions":
                                var checkContent = (string)request.checkContent;
                                int numQuestions = (int)request.numQuestions;
                                var quizPrompt = $"Generate exactly {numQuestions} multiple-choice questions with 4 options each on '{checkContent}'. Questions should be concise, focusing on core knowledge. Provide the correct answer and a brief explanation (20-30 words). Format as: Question 1: [question]? A. [option] B. [option] C. [option] D. [option] Correct answer: [A/B/C/D]. Explanation: [explanation]. Separate questions with a blank line. Use professional language, plain text, no markdown or symbols.";
                                response = JsonConvert.SerializeObject(new { content = geminiService.CallGemini(quizPrompt) });
                                break;

                            case "mentee/ask-quiz":
                                var question = (string)request.question;
                                var askPrompt = $"Provide a concise explanation of the concept behind the quiz question: '{question}'. Use simple terms for beginners, focusing on core ideas to aid understanding. Do not reveal the answer. Use professional language matching the input. Plain text, no markdown.";
                                response = JsonConvert.SerializeObject(new { answer = geminiService.CallGemini(askPrompt) });
                                break;

                            case "mentee/summarize-or-explain":
                                var content = (string)request.content;
                                bool isSummary = (bool)request.isSummary;
                                var contentPrompt = isSummary
                                    ? $"Provide a concise summary of '{content}', focusing on core knowledge in simple terms for beginners. Use professional language matching the input. Plain text, no markdown."
                                    : $"Explain '{content}' concisely in simple terms for beginners, focusing on core knowledge. Use professional language matching the input. Plain text, no markdown.";
                                response = JsonConvert.SerializeObject(new { response = geminiService.CallGemini(contentPrompt) });
                                break;

                            default:
                                response = JsonConvert.SerializeObject(new { error = "Unknown action. Please try again." });
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error processing request: {ex.Message}");
                        response = JsonConvert.SerializeObject(new { error = "Invalid request. Please try again." });
                    }
                }

                writer.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Client error: {ex.Message}");
            }
            finally
            {
                client.Close();
            }
        }
    }
}
