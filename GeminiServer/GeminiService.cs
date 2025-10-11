
using System.Text;
using Newtonsoft.Json;

namespace Server
{
    public class GeminiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public GeminiService(HttpClient httpClient, string apiKey)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
        }

        public string CallGemini(string prompt)
        {
            try
            {
                var requestBody = new
                {
                    contents = new[] { new { parts = new[] { new { text = prompt } } } }
                };
                var jsonBody = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = _httpClient.PostAsync(
                    $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-pro:generateContent?key={_apiKey}",
                    content).Result;

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Gemini API error: {response.ReasonPhrase}");
                    return "Error: Could not connect to AI service.";
                }

                string responseString = response.Content.ReadAsStringAsync().Result;
                dynamic jsonResponse = JsonConvert.DeserializeObject(responseString);

                if (jsonResponse?.candidates?[0]?.content?.parts?[0]?.text != null)
                {
                    string text = jsonResponse.candidates[0].content.parts[0].text;
                    return text.Replace("\\n", "\n").Trim();
                }

                return "Error: Invalid response from AI.";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Gemini API error: {ex.Message}");
                return "Error: AI service unavailable.";
            }
        }
    }
}
