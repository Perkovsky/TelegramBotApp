using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotApp.Models.Commands
{
    public class HelloCommand : Command, ICommand
    {
        public string Name => "hello";

        public async void Execute(TelegramBotClient client, Message message, bool replyToMessage = false)
        {
            string text = $"Привет, {message.From.FirstName} {message.From.LastName}. Тестирование бота...";
            await SendTextMessageAsync(client, message, text, replyToMessage);
        }
    }
}
