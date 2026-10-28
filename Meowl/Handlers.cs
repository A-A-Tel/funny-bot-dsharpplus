using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using DSharpPlus.Extensions;

namespace Meowl;

public static class Handlers
{
    public static void ConfigureDiscordHandlers(this IServiceCollection services)
    {
        services.ConfigureEventHandlers(b => b
            .HandleMessageCreated(HandleMessageCreated)
            .HandleMessageDeleted(HandleMessageDeleted)
        );
    }

    private static async Task HandleMessageCreated(DiscordClient client, MessageCreatedEventArgs args)
    {
        //                               Wemm         +++        Annie
        if (args.Author.Id is 569342254565687346)
        {
            DiscordMessageBuilder builder = new()
            {
                FailOnInvalidReply = true,
                Content = "Free speech was a mistake"
            };

            builder.WithReply(args.Message.Id);
            await builder.SendAsync(args.Channel);
        }
    }

    private static async Task HandleMessageDeleted(DiscordClient client, MessageDeletedEventArgs args)
    {
    }
}