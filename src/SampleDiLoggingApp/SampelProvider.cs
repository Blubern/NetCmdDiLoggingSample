
using Microsoft.Extensions.Logging;

namespace SampleDiLoggingApp
{
    public class SampelProvider : ISampelProvider
    {
        private readonly ILogger<SampelProvider> logger;

        public SampelProvider(ILogger<SampelProvider> logger)
        {
            this.logger = logger;
        }

        public Task HelloWorldAsync()
        {
            logger.LogInformation("Hello, World!");
            Console.WriteLine("Hello, World!");

            logger.LogWarning("This is a warning message");

            return Task.CompletedTask;
        }
    }
}
