using System.Text.Json;
using rabbitmq.broker_hub.rabbitmq.broker_hub.shared.Abstractions;
using rabbitmq.broker_hub.shared.Contracts;

namespace rabbitmq.broker_hub.rabbitmq.broker_hub.consumer.Modules.Inconsistent;

public class InconsistentConsumer : ConsumingTemplate<InconsistentMessage>
{
    public InconsistentConsumer() : base("INCONSISTENT_QUEUE")
    {

    }

    protected override Task ProcessMessage(InconsistentMessage message)
    {
        Console.WriteLine("INCONSISTENT_QUEUE: " + JsonSerializer.Serialize(message));
        return Task.CompletedTask;
    }
}
