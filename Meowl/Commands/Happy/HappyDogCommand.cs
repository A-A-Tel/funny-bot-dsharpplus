using System.ComponentModel;
using DSharpPlus.Commands;

namespace Meowl.Commands.Happy;

public partial class HappyCommandGroup
{
    [Command("dog")]
    [Description("Count dogs")]
    public async ValueTask DogAsync(
        CommandContext context,
        [Description("Dog amount 1")] int x,
        [Description("Dog amount 2")] int y
    )
    {
        await context.RespondAsync($"{x} dog(s) + {y} dog(s) = {x + y} dog(s)");
    }
}