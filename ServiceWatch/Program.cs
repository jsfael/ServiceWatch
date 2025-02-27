using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServiceWatch;

class Program {
    static async Task Main(string[] args) { 
        using IHost host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddSingleton<ServicosMonitorados>();
                services.AddSingleton<MonitorService>();
                services.AddHostedService<MonitorWorker>();
            })
            .Build();

        await host.RunAsync();
    }

}