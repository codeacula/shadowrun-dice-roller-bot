using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;

namespace ShadowrunDiceRollerBot;

public class SlashCommands : ApplicationCommandModule
{
    [SlashCommand("ping", "A command to test if the slash commands work")]
    public async Task PingCommand(InteractionContext ctx)
    {
        await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("Pong!"));
    }
}