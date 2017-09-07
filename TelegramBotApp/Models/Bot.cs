using System.Collections.Generic;
using Telegram.Bot;
using TelegramBotApp.Models.Commands;

namespace TelegramBotApp.Models
{
    public class Bot
    {
        #region AppSetting

#if DEBUG
        private readonly string URL = "https://70b49923.ngrok.io";
#else
        private readonly string URL = "https://telegrambotapp20170831072144.azurewebsites.net";
#endif
        private readonly string ROUTE = "api/message/update";
        private readonly string KEY = "417102442:AAHGx-14uAGiBUXruQvbxn8IO81uoY1H_q0";
        #endregion

        private TelegramBotClient client;
        private List<ICommand> commands;

        public TelegramBotClient Client => client;
        public IReadOnlyList<ICommand> Commands => commands.AsReadOnly();

        public Bot()
        {
            client = new TelegramBotClient(KEY);
            SetWebhookAsync();

            commands = new List<ICommand>
            {
                new HelloCommand(),
                new SiteOrdersCommand()
                //TODO: add more commands
            };
        }

        private async void SetWebhookAsync() => await client.SetWebhookAsync($"{URL}/{ROUTE}");
    }
}
