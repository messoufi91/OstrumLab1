// See https://aka.ms/new-console-template for more information  Provider : IProvider
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ostrum;
using Ostrum.Inteface;
using Ostrum.Model;


using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services
            .AddScoped<ICalculator<List<List<decimal>>, decimal>, Calculator>()
            .AddScoped<ICalculator<List<decimal>, decimal>, Calculator>()
            .AddScoped<OrchestrePrice>())
    .Build();

await host.RunAsync();

Console.WriteLine("Hello, World!");


