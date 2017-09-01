using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using TelegramBotApp.Models;

namespace TelegramBotApp.Controllers
{
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
            var commands = Bot.Commands;
            var message = update.Message;
            var client = await Bot.Get();

            var hello = new Models.Commands.HelloCommand();
            hello.Execute(message, client);

            //foreach (var command in commands)
            //{
            //    if (command.Contains(message.Text.ToUpper()))
            //    {
            //        command.Execute(message, client);
            //        //break;
            //        return Ok();
            //    }
            //}

            return Ok();
        }
    }
}
