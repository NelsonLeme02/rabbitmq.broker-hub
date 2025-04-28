using System.Text.Json;
using rpnet.broker_matera_hub.rpnet.broker_matera_hub.shared.Abstractions;
using rpnet.broker_matera_hub.shared.Contracts;

namespace rpnet.broker_matera_hub.rpnet.broker_matera_hub.consumer.Modules.Returns;
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
