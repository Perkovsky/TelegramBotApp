using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotApp.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "hello";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO: Command logic -_-
            //await client.SendTextMessage(chatId, "Hello!", replyToMessageId: messageId);
            await client.SendTextMessageAsync(chatId, "hello44! this is test!");
        }
    }
}
