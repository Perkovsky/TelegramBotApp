using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using TelegramBotApp.Models;
using TelegramBotApp.Models.Commands;

namespace TelegramBotApp.Controllers
{
    [Route("api/[controller]/[action]")]
    public class MessageController : Controller
    {
        private Bot bot = BotFactory.GetBot();

        [HttpGet]
        public string Update() => "Test route done!";

        [HttpPost]
        public OkResult Update([FromBody]Update update)
        {
            var message = update.Message;
            var commands = bot.Commands;
            var command = commands.FindCommand(message.Text);

            command?.ExecuteAsync(bot.Client, message);

            return Ok();
        }
    }
}
