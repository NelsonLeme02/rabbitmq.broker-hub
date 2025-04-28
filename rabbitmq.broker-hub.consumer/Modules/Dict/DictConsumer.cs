using System.Text.Json;
using rpnet.broker_matera_hub.rpnet.broker_matera_hub.shared.Abstractions;
using rpnet.broker_matera_hub.shared.Contracts;

namespace rpnet.broker_matera_hub.rpnet.broker_matera_hub.consumer.Modules.Dict;

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
