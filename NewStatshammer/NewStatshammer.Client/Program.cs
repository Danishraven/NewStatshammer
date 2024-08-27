using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NewStatshammer.Client;
using NewStatshammer.Client.Models;
using NewStatshammer.Client.Models.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();
builder.Services.AddSingleton<IDamage, Damage>();
builder.Services.AddSingleton<IProfile, Profile>();
builder.Services.AddSingleton<IFighter, Fighter>();
builder.Services.AddSingleton<StateContainer>();
builder.Services.AddBlazoredLocalStorage();
await builder.Build().RunAsync();
