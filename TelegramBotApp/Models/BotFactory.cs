using System;

namespace TelegramBotApp.Models
{
    public static class BotFactory
    {
        private static Bot bot;

        public static Bot GetBot() => bot ?? Activator.CreateInstance<Bot>();
    }
}
