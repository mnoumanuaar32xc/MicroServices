using Ocelot.Middleware;
using Ocelot.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json");
builder.Services.AddOcelot();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseOcelot().Wait();

//app.MapGet("/", () => "Hello World!");

app.MapControllers();


app.Run();
