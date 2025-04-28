using System.Text;
using System.Text.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace rabbitmq.broker_hub.rabbitmq.broker_hub.shared.Abstractions;
public abstract class ConsumingTemplate<TModel>(string queue) where TModel : new()
{
    private readonly IChannel channel = BuildChannelAsync().Result;
    private static async Task<IChannel> BuildChannelAsync()
    {
        string queuePath = Environment.GetEnvironmentVariable("QUEUE_PATH") ?? "";
        string username = Environment.GetEnvironmentVariable("USERNAME") ?? "";
        string password = Environment.GetEnvironmentVariable("PASSWORD") ?? "";
        var factory = new ConnectionFactory { HostName = queuePath, Port = 5672, UserName = username, Password = password };
        var connection = await factory.CreateConnectionAsync();
        var channel = await connection.CreateChannelAsync();
        return channel;
    }

    public async Task StartConsuming()
    {
        await channel.QueueDeclareAsync(queue: queue,
                                        durable: false,
                                        exclusive: false,
                                        autoDelete: false,
                                        arguments: null);
        var consumer = new AsyncEventingBasicConsumer(channel);
        Console.WriteLine($"{queue} is running");
        consumer.ReceivedAsync += async (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            var deserializedMessage = JsonSerializer.Deserialize<TModel>(message) ?? new TModel();
            await ProcessMessage(deserializedMessage);
        };
        await channel.BasicConsumeAsync(queue: queue, autoAck: true, consumer: consumer);
    }

    protected abstract Task ProcessMessage(TModel message);
}

