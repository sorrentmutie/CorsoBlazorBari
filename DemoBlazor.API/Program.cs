using DemoBlazor.API.Services;
using DemoBlazorLibrary.Servizi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDatiClienti, ServizioClienti>();
builder.Services.AddCors(opzioni =>
{
    opzioni.AddPolicy("MiaPolicy", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("MiaPolicy");

app.MapGet("/clienti", (IDatiClienti servizio) => servizio.EstraiClienti());


app.Run();


