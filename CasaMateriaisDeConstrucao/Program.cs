var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/sobre", async context =>
{
await context.Response.SendFileAsync("wwwroot/sobre.html");
});