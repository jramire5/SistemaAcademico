using BlazorClient;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5183/") });

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5183/") });
var baseAddress = builder.Configuration["HttpClient:BaseAddress"];

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });


await builder.Build().RunAsync();
