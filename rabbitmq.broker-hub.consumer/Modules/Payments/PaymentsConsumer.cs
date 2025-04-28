using System.Text.Json;
using rpnet.broker_matera_hub.rpnet.broker_matera_hub.shared.Abstractions;
using rpnet.broker_matera_hub.shared.Contracts;

namespace rpnet.broker_matera_hub.rpnet.broker_matera_hub.consumer.Modules.Payments;

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

