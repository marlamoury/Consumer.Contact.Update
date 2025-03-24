using Consumer.Update.Contact.Infrastructure.Messaging;

namespace Consumer.Contact.Update.Worker;

public class RabbitWorker : BackgroundService
{
    private readonly ILogger<RabbitWorker> _logger;
    private readonly RabbitMQConsumer _consumer;

    public RabbitWorker(ILogger<RabbitWorker> logger, RabbitMQConsumer consumer)
    {
        _logger = logger;
        _consumer = consumer;
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Worker iniciado...");
        return _consumer.StartAsync(stoppingToken); // Chama o StartAsync do RabbitMQConsumer
    }
}
