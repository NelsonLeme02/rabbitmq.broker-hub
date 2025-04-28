using System;
using rabbitmq.broker_hub.rabbitmq.broker_hub.consumer.Modules.Block;
using rabbitmq.broker_hub.rabbitmq.broker_hub.consumer.Modules.Dict;
using rabbitmq.broker_hub.rabbitmq.broker_hub.consumer.Modules.Inconsistent;
using rabbitmq.broker_hub.rabbitmq.broker_hub.consumer.Modules.Payments;
using rabbitmq.broker_hub.rabbitmq.broker_hub.consumer.Modules.Returns;

namespace rabbitmq.broker_hub.consumer;

public class Program
{
    private static readonly TaskCompletionSource completion = new();
    public static async Task Main()
    {
        DotNetEnv.Env.Load();
        await Start();
        await completion.Task;
    }

    private static async Task Start()
    {
        var blockConsumer = new BlockConsumer();
        var dictConsumer = new DictConsumer();
        var inconsistentConsumer = new InconsistentConsumer();
        var paymentsConsumer = new PaymentsConsumer();
        var returnsConsumer = new ReturnsConsumer();

        await blockConsumer.StartConsuming();
        await dictConsumer.StartConsuming();
        await inconsistentConsumer.StartConsuming();
        await paymentsConsumer.StartConsuming();
        await returnsConsumer.StartConsuming();
    }
}
