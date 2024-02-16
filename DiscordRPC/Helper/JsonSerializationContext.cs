using DiscordRPC.IO;
using DiscordRPC.RPC.Commands;
using DiscordRPC.RPC.Payload;
using System.Text.Json.Serialization;

namespace DiscordRPC.Helper
{
    [
    /* Commands Context */
        JsonSerializable(typeof(CloseCommand)),
        JsonSerializable(typeof(PresenceCommand)),
        JsonSerializable(typeof(RespondCommand)),
        JsonSerializable(typeof(SubscribeCommand)),

    /* Payload Context */
        JsonSerializable(typeof(EventPayload)),
        JsonSerializable(typeof(ClosePayload)),
        JsonSerializable(typeof(IPayload)),
        JsonSerializable(typeof(ArgumentPayload<RespondCommand>)),
        JsonSerializable(typeof(ArgumentPayload<PresenceCommand>)),
        JsonSerializable(typeof(ArgumentPayload<CloseCommand>)),

    /* IO Context */
        JsonSerializable(typeof(Handshake))
    ]
    internal partial class JsonSerializationContext : JsonSerializerContext { }
}
