using Application.init;
using Edge.Grpc.Services;
using Infra.Persistance.EF.init;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.InitializeDatabases(builder.Configuration.GetConnectionString("DefaultConnection"));
builder.Services.AddGrpc();
builder.Services.InitCommands();
builder.Services.InitializeAppService();


var app = builder.Build();



app.MapGrpcService<RegisterationService>();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
