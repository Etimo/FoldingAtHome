using FoldingAtHomeEtimo;
using FoldingAtHomeEtimo.HttpRepositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();

builder.Services.AddScoped<IProjectHttpRepository, ProjectHttpRepository>();
builder.Services.AddScoped<ITeamHttpRepository, TeamHttpRepository>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(uriString: "https://cors-anywhere.herokuapp.com/https://api.foldingathome.org/") });


builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();

builder.Services.AddScoped<IProjectHttpRepository, ProjectHttpRepository>();
builder.Services.AddScoped<ITeamHttpRepository, TeamHttpRepository>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(uriString: "https://api.foldingathome.org/") });



await builder.Build().RunAsync();
