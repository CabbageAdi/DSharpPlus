using System;
using System.Collections.Generic;
using System.Text;

namespace DSharpPlus.SlashCommands
{
    public enum ApplicationCommandOptionType
    {
        SubCommand = 1,
        SubCommandGroup,
        String,
        Integer,
        Boolean,
        User,
        Channel,
        Role
    }
}
