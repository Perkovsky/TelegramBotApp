using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using TelegramBotApp.Models;
using TelegramBotApp.Models.Commands;

namespace TelegramBotApp.Controllers
{
    //TODO: сделать "правильный" route
    //[Route("api/[controller]")]
    public class MessageController : Controller
    {
        [HttpGet]
        //[Route(@"api/message/update")]
        public string Update()
        {
            return "Test route!";
        }

        //[Route(@"api/message/update")] //webhook uri part
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var message = update.Message;
            var commands = Bot.Commands;
            var command = commands.FindCommand(message.Text);
            var client = await Bot.Get();

            command?.Execute(client, message);

            return Ok();
        }
    }
}
