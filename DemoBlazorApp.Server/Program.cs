using DemoBlazorApp.Server.Data;
using DemoBlazorLibrary.Servizi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<IServizioEventi, ServizioEventi>();
builder.Services.AddScoped<IOrologio, OrologioStatico>();
builder.Services.AddScoped(sp => new HttpClient() { BaseAddress = new Uri("https://localhost:7118")});
builder.Services.AddScoped<IDatiClienti, ServizioDatiClientiServer>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
