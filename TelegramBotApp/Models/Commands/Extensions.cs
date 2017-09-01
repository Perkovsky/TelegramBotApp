using System.Collections.Generic;
using System.Linq;

namespace TelegramBotApp.Models.Commands
{
    internal static class Extensions
    {
        internal static ICommand FindCommand(this IReadOnlyCollection<ICommand> commands, string txtCommand)
        {
            return commands.Where(c => c.Name == txtCommand.Trim().ToLower()).FirstOrDefault();
        }

        /// <summary>
        /// Removes all occurrences of specified characters from the beginning and end of this instance.
        /// </summary>
        /// <param name="original">Original string</param>
        /// <param name="remove">Characters to Remove</param>
        /// <returns>New string</returns>
        internal static string TrimExt(this string original, string remove)
        {
            return original.Trim(remove.ToCharArray());
        }
    }
}
