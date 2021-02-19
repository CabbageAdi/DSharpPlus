using System;
using System.Collections.Generic;
using System.Text;

namespace DSharpPlus.SlashCommands
{
    /// <summary>
    /// Represents a configuration for a <see cref="DSharpPlus.SlashCommands.SlashCommandsExtension"/>
    /// </summary>
    public class SlashCommandsConfiguration
    {
        /// <summary>
        /// Gets or sets the guild this extension should be registered for
        /// <para>Leave this as <see langword="null"/> to register commands globally</para>
        /// </summary>
        public ulong? GuildId { get; set; } = null;
    }
}
