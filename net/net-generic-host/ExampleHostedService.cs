using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetGenericHost
{
    internal class ExampleHostedService: IHostedService
    {
        private readonly ILogger _logger;
        public  ExampleHostedService(
            ILogger<ExampleHostedService> logger, 
            IHostApplicationLifetime appLifetime)
        {
            _logger = logger;
            appLifetime.ApplicationStarted.Register(OnStarted);
            appLifetime.ApplicationStopped.Register(OnStopped);
            appLifetime.ApplicationStopping.Register(OnStopping);
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("1. StartAsync has been called. current id {0}.", Task.CurrentId);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("4. Stop has been called. current id {0}.", Task.CurrentId);
            return Task.CompletedTask;
        }

        private void OnStarted()
        {
            _logger.LogInformation("2. OnStarted has been called.");
        }

        private void OnStopping()
        {
            _logger.LogInformation("3. OnStopping has been called.");
        }
        private void OnStopped()
        {
            _logger.LogInformation("5. OnStopped has been called.");
        }
    }
}
