using System.Text.Json;
using rabbitmq.broker_hub.rabbitmq.broker_hub.shared.Abstractions;
using rabbitmq.broker_hub.shared.Contracts;

namespace rabbitmq.broker_hub.rabbitmq.broker_hub.consumer.Modules.Dict;

public class DictConsumer : ConsumingTemplate<DictMessage>
{
    public DictConsumer() : base("DICT_QUEUE")
    {

    }

    protected override Task ProcessMessage(DictMessage message)
    {
        Console.WriteLine("DICT_QUEUE: " + JsonSerializer.Serialize(message));
        return Task.CompletedTask;
    }
}
