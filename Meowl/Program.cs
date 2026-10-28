using DotNetEnv;
using DSharpPlus;
using DSharpPlus.Commands;
using DSharpPlus.Commands.Processors.SlashCommands;
using DSharpPlus.Extensions;
using Meowl.Commands.Happy;
using Meowl.Handlers;
using Meowl.Services;

Env.Load();
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddDiscordClient(Env.GetString("TOKEN"), DiscordIntents.All);
builder.Services.ConfigureDiscordHandlers();

builder.Services.AddCommandsExtension((sp, cx) =>
{
    cx.AddCommands([typeof(HappyCommandGroup)]);

    cx.AddProcessor(sp.GetRequiredService<SlashCommandProcessor>());
});
builder.Services.AddSingleton<SlashCommandProcessor>();

builder.Services.AddHostedService<BotBackgroundService>();

IHost host = builder.Build();
await host.RunAsync();