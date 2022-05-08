using AKLab01;
using AKLab01.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using static AKLab01.Pages.FetchData;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>(); 
builder.Services.AddScoped<IWeatherForecastService, DemoWeatherForecastService>(); 
await builder.Build().RunAsync();
