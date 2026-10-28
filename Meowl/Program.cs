using Meowl;
using DSharpPlus;
using DSharpPlus.Extensions;

DotNetEnv.Env.Load();
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddDiscordClient(DotNetEnv.Env.GetString("TOKEN"), DiscordIntents.All);
builder.Services.ConfigureDiscordHandlers();
builder.Services.AddHostedService<BotBackgroundService>();

IHost host = builder.Build();
await host.RunAsync();
