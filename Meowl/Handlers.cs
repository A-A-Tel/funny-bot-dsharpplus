using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using DSharpPlus.Extensions;

namespace Meowl;

public static class Handlers
{
    public static void ConfigureDiscordHandlers(this IServiceCollection services)
    {
        services.ConfigureEventHandlers(b => b.HandleMessageCreated(HandleMessageCreated));
    }

    private static async Task HandleMessageCreated(DiscordClient client, MessageCreatedEventArgs args)
    {
        
        //                          Wemm            +        Annie
        if (args.Author.Id is 1388582208431984721 or 1403595152232284274) return;
        
        DiscordMessageBuilder builder = new();

        builder.AddTextDisplayComponent("Fuck you >:(");
        builder.WithReply(args.Message.Id);
        await builder.SendAsync(args.Channel);
    }
}