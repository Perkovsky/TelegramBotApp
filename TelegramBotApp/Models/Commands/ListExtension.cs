using System.Collections.Generic;
using System.Linq;

namespace TelegramBotApp.Models.Commands
{
    internal static class ListExtension
    {
        internal static ICommand FindCommand(this IReadOnlyCollection<ICommand> commands, string txtCommand)
        {
            return commands.Where(c => c.Name == txtCommand.Trim().ToLower()).FirstOrDefault();
        }
    }
}
