var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.SocialApp>("socialapp");

builder.Build().Run();
