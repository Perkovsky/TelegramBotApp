using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotApp.Models.Commands
{
    public class SiteOrdersCommand : Command, ICommand
    {
        public string Name => "siteorders";

        public async void ExecuteAsync(TelegramBotClient client, Message message, bool replyToMessage = false)
        {
            string text = $"Сегодня сделано ХХ заказов на сумму ХХХХ.ХХ грн";
            await SendTextMessageAsync(client, message, text, true);
        }
    }
}
