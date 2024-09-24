using Newtonsoft.Json;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Helpers.ExcelHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Repositories
{
    public class ChatBotService : IChatBotService
    {
        public string GetResponse(string message)
        {
            string fileName = "wwwroot/RuleBased.json";
            string jsonString = File.ReadAllText(fileName);
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
