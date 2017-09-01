using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotApp.Models.Commands
{
    public abstract class Command
    {
        public async Task SendTextMessageAsync(TelegramBotClient client, Message message, string text, bool replyToMessage = false)
        {
            long chatId = message.Chat.Id;
            int messageId = message.MessageId;

            if (replyToMessage)
            {
                await client.SendTextMessageAsync(chatId, text, replyToMessageId: messageId);
            }
            else
            {
                await client.SendTextMessageAsync(chatId, text);
            }
        }
    }
}
