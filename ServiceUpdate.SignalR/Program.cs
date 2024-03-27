
using ServiceUpdate.SignalR.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.UseDeveloperExceptionPage();
app.UseRouting();
app.MapHub<ServiceUpdaterHub>("/ServiceUpdateHub");
app.Run();