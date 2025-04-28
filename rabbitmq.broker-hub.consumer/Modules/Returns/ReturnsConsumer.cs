using System.Text.Json;
using rabbitmq.broker_hub.rabbitmq.broker_hub.shared.Abstractions;
using rabbitmq.broker_hub.shared.Contracts;

namespace rabbitmq.broker_hub.rabbitmq.broker_hub.consumer.Modules.Returns;
public class ReturnsConsumer : ConsumingTemplate<ReturnsMessage>
{
    public ReturnsConsumer() : base("RETURNS_QUEUE")
    {

    }

    protected override Task ProcessMessage(ReturnsMessage message)
    {
        Console.WriteLine("RETURNS_QUEUE: " + JsonSerializer.Serialize(message));
        return Task.CompletedTask;
    }
}
