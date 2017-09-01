using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using TelegramBotApp.Models.Commands;

namespace TelegramBotApp.Models
{
    public static class Bot
    {
#if DEBUG
        public readonly static string URL = "https://285227fd.ngrok.io";
#else
        public readonly static string URL = "https://telegrambotapp20170831072144.azurewebsites.net:443";
#endif
        //public readonly static string NAME = "NightNinjaBot";
        public readonly static string ROUTE = "message/update"; // "api/message/update"
        public readonly static string KEY = "417102442:AAHGx-14uAGiBUXruQvbxn8IO81uoY1H_q0";

        private static TelegramBotClient client;
        private static List<ICommand> commandsList;

        //public static IReadOnlyList<ICommand> Commands => commandsList.AsReadOnly();

        internal static IReadOnlyList<ICommand> Commands => commandsList.AsReadOnly();

        public static async Task<TelegramBotClient> Get()
        {
            if (client != null)
            {
                return client;
            }

            commandsList = new List<ICommand>();
            commandsList.Add(new HelloCommand());
            //TODO: add more commands

            client = new TelegramBotClient(KEY);
            await client.SetWebhookAsync($"{URL}/{ROUTE}");

            return client;
        }
    }
}
