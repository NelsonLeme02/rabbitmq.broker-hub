using System.Text.Json;
using rpnet.broker_matera_hub.rpnet.broker_matera_hub.shared.Abstractions;
using rpnet.broker_matera_hub.shared.Contracts;

namespace rpnet.broker_matera_hub.rpnet.broker_matera_hub.consumer.Modules.Inconsistent;

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
