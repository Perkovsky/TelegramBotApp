using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotApp.Models.Commands
{
    public class SiteOrdersCommand : Command, ICommand
    {
        private string URL = "https://stozhary.net.ua/api/orders/summ/OqNMgwI4rq0oNFGLwB8AcWMzJVDhqFHr";

        public string Name => "siteorders";

        private string GetTotalSumOrdersToday()
        {
            try { return WebApiHelper.Get(URL).TrimExt("\""); }
            catch { return "Ошибка получения данных!"; }
        }

        public async void ExecuteAsync(TelegramBotClient client, Message message, bool replyToMessage = false)
        {
            await SendTextMessageAsync(client, message, GetTotalSumOrdersToday(), true);
        }
    }
}
