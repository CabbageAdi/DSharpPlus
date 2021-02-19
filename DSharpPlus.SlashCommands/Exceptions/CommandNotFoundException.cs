using System;
using System.Collections.Generic;
using System.Text;

namespace DSharpPlus.SlashCommands.Exceptions
{
    /// <summary>
    /// Thrown when a command cannot be found for an interaction
    /// </summary>
    public class CommandNotFoundException : Exception
    {
        internal CommandNotFoundException(string message) : base (message) { }
    }
}
