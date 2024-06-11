var builder = WebApplication.CreateBuilder(args);

//Add Services to DI Container
var app = builder.Build();

//Configure HTTP request pipeline

app.MapGet("/", () => "Hello World!");

app.Run();