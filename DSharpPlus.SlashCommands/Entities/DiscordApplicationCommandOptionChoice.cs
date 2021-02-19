using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DSharpPlus.SlashCommands.Entities
{
    public class DiscordApplicationCommandOptionChoice
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; internal set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public object Value { get; internal set; }
    }
}
