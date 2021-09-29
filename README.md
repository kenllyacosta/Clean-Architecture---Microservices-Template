# Clean-Architecture - Microservices-Template - Northwind
Project to know about Microservices in .NET 5

You can add more Api's to get more micro-services enable ☺

After that, you have to make reference to these projects:

- Ioc
- Domain
- Application

Install from nuget:
- MediatR.Extensions.Microsoft.DependencyInjection
- FluentValidation.DependencyInjectionExtensions

**For each project you add, make sure you add the services at Startup**

services.AddMediatR(Assembly.Load("Application"));
services.AddRepositories(Configuration);

services.AddValidatorsFromAssembly(Assembly.Load("Application"));
services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

Done!
