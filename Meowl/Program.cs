using Meowl;
using DSharpPlus;
using DSharpPlus.Extensions;

DotNetEnv.Env.Load();
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddDiscordClient(DotNetEnv.Env.GetString("TOKEN"), DiscordIntents.AllUnprivileged);
builder.Services.ConfigureDiscordHandlers();

IHost host = builder.Build();
await host.RunAsync();
