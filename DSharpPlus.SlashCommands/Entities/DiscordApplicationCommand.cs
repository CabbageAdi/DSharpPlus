using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.Entities;
using Newtonsoft.Json;
using DSharpPlus.SlashCommands;

namespace DSharpPlus.SlashCommands.Entities
{
    public class DiscordApplicationCommand : SnowflakeObject
    {
        [JsonProperty("application_id")]
        public ulong ApplicationId { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("description")]
        public string Description { get; internal set; }

        [JsonProperty("options")]
        public IReadOnlyList<DiscordApplicationCommandOption> Options { get; internal set; } = null;

        public Task DeleteAsync()
            => ((DiscordClient)Discord).GetSlashCommands().DeleteCommandAsync(Id);
    }
}
