using MarsRover.Services.Abstractions;
using MarsRover.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    /// <summary>
    /// This class setup our Dependency Injection
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                                            .AddLogging()
                                            .AddScoped<IHelperService, HelperManager>()
                                            .AddScoped<IRoverService, RoverManager>()
                                            .BuildServiceProvider();


            var logger = serviceProvider.GetService<ILoggerFactory>()
            .CreateLogger<Program>();

            logger.LogDebug(Constants.DebugMessages.START_APP);

            serviceProvider.GetService<IRoverService>().Initilaze();

            logger.LogDebug(Constants.DebugMessages.DONE_APP);
        }
    }
}
