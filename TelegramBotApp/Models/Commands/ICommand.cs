using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotApp.Models.Commands
{
    public interface ICommand
    {
        string Name { get; }

        void ExecuteAsync(TelegramBotClient client, Message message, bool replyToMessage = false);
    }
}
