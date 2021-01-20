using DSharpPlus.Entities;
using Newtonsoft.Json;

namespace NitroSniper
{
    public static class Extensions
    {
        public static T GetAsJson<T>(this string raw) => JsonConvert.DeserializeObject<T>(raw);

        public static string GetTag(this DiscordUser user)
        {
            return $"{user.Username}#{user.Discriminator}";
        }

        public static string GetUrl(this DiscordMessage msg)
        {
            return msg.Channel.Guild == null ?
                $"https://discord.com/channels/@me/{msg.ChannelId}/{msg.Id}" :
                $"https://discord.com/channels/{msg.Channel.GuildId}/{msg.ChannelId}/{msg.Id}";
        }
    }
}