using DemoBlazorApp.WASM.Data;
using DemoBlazorComponentLibrary;
using DemoBlazorLibrary.Servizi;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddScoped<ServizioEventi>();

builder.Services.AddScoped<IServizioEventi, ServizioEventi>();
builder.Services.AddScoped<IOrologio, OrologioStatico>();
builder.Services.AddScoped<IDatiClienti, ServizioDatiClientiWASM>();

await builder.Build().RunAsync();
