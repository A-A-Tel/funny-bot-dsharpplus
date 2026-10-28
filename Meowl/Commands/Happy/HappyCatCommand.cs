using System.ComponentModel;
using DSharpPlus.Commands;

namespace Meowl.Commands.Happy;

public partial class HappyCommandGroup
{
    [Command("cat")]
    [Description("Count cats")]
    public async ValueTask CatAsync
    (
        CommandContext context,
        [Description("Cat amount 1")] int x,
        [Description("Cat amount 2")] int y,
        [Description("Cat amount 3")] int z
    )
    {
        await context.RespondAsync($"{x} cat(s) + {y} cat(s) + {z} cat(s) = {x + y + z} cat(s)");
    }
}