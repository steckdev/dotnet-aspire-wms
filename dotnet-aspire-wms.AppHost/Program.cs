var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.dotnet_aspire_wms_ApiService>("apiservice");

builder.AddProject<Projects.dotnet_aspire_wms_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
