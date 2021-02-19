using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DSharpPlus.SlashCommands.Entities
{
    public class DiscordApplicationCommandOption
    {
        [JsonProperty("type")]
        public ApplicationCommandOptionType Type { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("description")]
        public string Description { get; internal set; }

        [JsonProperty("required")]
        public bool? IsRequired { get; internal set; }

        [JsonProperty("choices", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<DiscordApplicationCommandOptionChoice> Choices { get; internal set; } = null;

        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<DiscordApplicationCommandOption> Options { get; internal set; } = null;
    }
}
