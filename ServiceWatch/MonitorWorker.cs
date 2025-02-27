using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceWatch
{
    public class MonitorWorker : BackgroundService
    {
        private readonly MonitorService _monitorService;
        private readonly ServicosMonitorados _services;

        public MonitorWorker(MonitorService monitorService, ServicosMonitorados services)
        {
            _monitorService = monitorService;
            _services = services;
            SolicitarUrls();
        }

        private void SolicitarUrls()
        {
            var validUrls = new List<string>();

            while (validUrls.Count == 0)
            {
                Console.WriteLine("Por favor, insira as URLs dos serviços a serem monitorados (separadas por vírgula):");
                string input = Console.ReadLine();
                var urls = input.Split(',').Select(url => url.Trim()).ToList();

                foreach (var url in urls)
                {
                    if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
                    {
                        validUrls.Add(url);
                    }
                    else
                    {
                        Console.WriteLine($"URL inválida:  '{url}' Tente novamente.");
                        Console.WriteLine("O formato deve ser válido e iniciar com  'https://'.");
                        validUrls.Clear();
                        break;
                    }
                }
            }

            _services.SetUrls(validUrls);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.Clear();
                Console.WriteLine("\nIniciando verificação de serviços...");

                foreach (var url in _services.Urls)
                {
                    bool online = await _monitorService.VerifyService(url);
                    string status = online ? "\u001b[32monline\u001b[0m" : "\u001b[31moffline\u001b[0m";
                    Console.WriteLine($"{url} está {status}");
                }

                Console.WriteLine("Aguardando 5 segundos antes da próxima verificação...");
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
