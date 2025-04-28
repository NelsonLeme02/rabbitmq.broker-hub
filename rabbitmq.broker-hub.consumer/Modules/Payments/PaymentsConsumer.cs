using System.Text.Json;
using rabbitmq.broker_hub.rabbitmq.broker_hub.shared.Abstractions;
using rabbitmq.broker_hub.shared.Contracts;

namespace rabbitmq.broker_hub.rabbitmq.broker_hub.consumer.Modules.Payments;

public class PaymentsConsumer : ConsumingTemplate<PaymentsMessage>
{
    public PaymentsConsumer() : base("PAYMENT_QUEUE")
    {

    }

    protected override Task ProcessMessage(PaymentsMessage message)
    {
        Console.WriteLine("PAYMENT_QUEUE: " + JsonSerializer.Serialize(message));
        return Task.CompletedTask;
    }
}

