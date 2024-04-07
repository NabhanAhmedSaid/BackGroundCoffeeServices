
using System.Threading;

public class BackgroundCoffeeService : BackgroundService
{
    readonly ILogger<BackgroundCoffeeService> _logger;

    public BackgroundCoffeeService(ILogger<BackgroundCoffeeService> logger)
    {
        _logger = logger;
    }
    

    protected  async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Coffee making at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
        }
    }
}