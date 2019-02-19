using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ConsoleApp
{
    class Application
    {
        [Option]
        public int Port { get; } = 8080;
                
        public Application(ILogger<Application> logger, IHostingEnvironment env)
        {
            _logger = logger;
            _env = env;
            
            _logger.LogInformation("Application started!");
        }

        private readonly ILogger<Application> _logger;
        private readonly IHostingEnvironment _env;

        private void OnExecute()
        {
            _logger.LogInformation($"Starting on port {Port}, env = {_env.EnvironmentName} on {_env.ContentRootPath}");
        }
    }
}
