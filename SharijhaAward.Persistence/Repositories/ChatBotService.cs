using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Helpers.ExcelHelper;

namespace SharijhaAward.Persistence.Repositories
{
    public class ChatBotService : IChatBotService
    {
        private readonly HttpClient _HttpClient;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public ChatBotService(HttpClient _HttpClient,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._HttpClient = _HttpClient;
            this._HttpContextAccessor = _HttpContextAccessor;
        }
        public string GetResponse(string message)
        {
            string fileName = "wwwroot/";

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string FolderPath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            var response = _HttpClient.GetAsync(FolderPath + "/RuleBased.json").Result;
            response.EnsureSuccessStatusCode();
            string jsonString = response.Content.ReadAsStringAsync().Result;
            var ObjectData = JsonConvert.DeserializeObject<PropertyJson>(jsonString);

            // Convert the user message to lowercase for case-insensitive matching
            string key = message.ToLower();

            // Check if the chatbot has a response for the given message
            if (ObjectData!.Rule.ContainsKey(key))
            {
                return ObjectData.Rule[key];
            }
            else
            {
                return "I'm sorry, I didn't understand that. Can you please rephrase?";
            };
        }
    }
}
