var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.WeatherApp_API>("weatherappapi");

builder.AddProject<Projects.WeatherApp_Web>("weatherapfrontend").WithReference(api);


builder.Build().Run();
