using DSharpPlus.Entities;

namespace DSharpPlus.EventArgs;

/// <summary>
/// Fired when someone subscribes to the scheduled event.
/// </summary>
public class ScheduledGuildEventUserAddedEventArgs : DiscordEventArgs
{
    /// <summary>
    /// The guild the event is scheduled for.
    /// </summary>
    public DiscordGuild Guild => this.Event.Guild;

    /// <summary>
    /// The event that was subscribed to.
    /// </summary>
    public DiscordScheduledGuildEvent Event { get; internal set; }

    /// <summary>
    /// The user that subscribed to the event.
    /// </summary>
    public DiscordUser User { get; internal set; }

    internal ScheduledGuildEventUserAddedEventArgs() : base() { }
}
