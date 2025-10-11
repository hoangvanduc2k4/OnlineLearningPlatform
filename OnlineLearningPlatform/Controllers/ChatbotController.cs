using System.Net.Sockets;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineLearningPlatform.Models.ViewModels;

namespace OnlineLearningPlatform.Controllers
{
    [Route("chatbot")]
    public class ChatbotController : Controller
    {
        private readonly string _tcpServerAddress;
        private readonly int _tcpServerPort;

        public ChatbotController(IConfiguration configuration)
        {
            var addressParts = configuration["ChatbotTcpServer"]?.Split(':')
                ?? throw new ArgumentException("ChatbotTcpServer configuration is missing or invalid.");
            _tcpServerAddress = addressParts[0];
            _tcpServerPort = int.Parse(addressParts[1]);
        }

        private string SendTcpRequest(object request)
        {
            try
            {
                using var client = new TcpClient(_tcpServerAddress, _tcpServerPort);
                using var stream = client.GetStream();

                // Send request with newline
                string jsonRequest = JsonConvert.SerializeObject(request);
                byte[] buffer = Encoding.UTF8.GetBytes(jsonRequest + "\n");
                stream.Write(buffer, 0, buffer.Length);

                // Read response until complete
                var responseBuilder = new StringBuilder();
                buffer = new byte[4096];
                int bytesRead;
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    responseBuilder.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));
                    // Check if response contains a complete JSON object
                    string responseSoFar = responseBuilder.ToString();
                    try
                    {
                        JsonConvert.DeserializeObject(responseSoFar);
                        break; // Valid JSON received, stop reading
                    }
                    catch (JsonException)
                    {
                        // Incomplete JSON, continue reading
                    }
                }

                string response = responseBuilder.ToString();
                if (string.IsNullOrEmpty(response))
                {
                    return "{\"error\": \"No response from server\"}";
                }

                return response;
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(new { error = $"Could not connect to TCP server: {ex.Message}" });
            }
        }

        [HttpPost("generate-lesson")]
        [Authorize(Roles = "Mentor")]
        public IActionResult GenerateLesson([FromForm] string description)
        {
            var request = new { action = "mentor/generate-lesson-content", description };
            var response = SendTcpRequest(request);
            return Content(response, "application/json");
        }

        [HttpPost("generate-quiz")]
        [Authorize(Roles = "Mentor")]
        public IActionResult GenerateQuiz([FromForm] QuizInput input)
        {
            var request = new { action = "mentor/generate-questions", checkContent = input.CheckContent, numQuestions = input.NumQuestions };
            var response = SendTcpRequest(request);
            return Content(response, "application/json");
        }

        [HttpPost("ask-quiz")]
        [Authorize(Roles = "Mentee")]
        public IActionResult AskQuiz([FromForm] string question)
        {
            var request = new { action = "mentee/ask-quiz", question };
            var response = SendTcpRequest(request);
            return Content(response, "application/json");
        }

        [HttpPost("summarize")]
        [Authorize(Roles = "Mentee")]
        public IActionResult Summarize([FromForm] ContentInput input)
        {
            var request = new { action = "mentee/summarize-or-explain", content = input.Content, isSummary = input.IsSummary };
            var response = SendTcpRequest(request);
            return Content(response, "application/json");
        }
    }
}