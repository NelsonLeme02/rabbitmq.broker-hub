using System.Text.Json;
using rabbitmq.broker_hub.rabbitmq.broker_hub.shared.Abstractions;
using rabbitmq.broker_hub.rabbitmq.broker_hub.shared.Contracts;

namespace rabbitmq.broker_hub.rabbitmq.broker_hub.consumer.Modules.Block;
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
