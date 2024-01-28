using DSharpPlus;
using DSharpPlus.SlashCommands;

namespace ShadowrunDiceRollerBot;

class Program
{
    static async Task Main(string[] args)
    {
        var token = Environment.GetEnvironmentVariable("DISCORD_TOKEN");

        var discord = new DiscordClient(new DiscordConfiguration() {
            Token = token,
            TokenType = TokenType.Bot,
            Intents = DiscordIntents.AllUnprivileged | DiscordIntents.MessageContents
        });

        var slash = discord.UseSlashCommands();
        slash.RegisterCommands<SlashCommands>();
        
        await discord.ConnectAsync();
        await Task.Delay(-1);
    }
}
