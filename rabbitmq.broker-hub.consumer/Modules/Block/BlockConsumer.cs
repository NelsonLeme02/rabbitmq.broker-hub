using System.Text.Json;
using rpnet.broker_matera_hub.rpnet.broker_matera_hub.shared.Abstractions;
using rpnet.broker_matera_hub.rpnet.broker_matera_hub.shared.Contracts;

namespace rpnet.broker_matera_hub.rpnet.broker_matera_hub.consumer.Modules.Block;
public class BlockConsumer : ConsumingTemplate<BlockMessage>
{
    public BlockConsumer() : base("BLOCK_QUEUE")
    {

    }

    protected override Task ProcessMessage(BlockMessage message)
    {
        Console.WriteLine("BLOCK_QUEUE: " + JsonSerializer.Serialize(message));
        return Task.CompletedTask;
    }
}
