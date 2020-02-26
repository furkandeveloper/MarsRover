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
                                            .BuildServiceProvider();


            var logger = serviceProvider.GetService<ILoggerFactory>()
            .CreateLogger<Program>();
            logger.LogDebug("Starting application");

            logger.LogDebug("All done !!!");
        }
    }
}
