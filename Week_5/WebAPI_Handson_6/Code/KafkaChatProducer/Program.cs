using Confluent.Kafka;

class Program
{
    static async Task Main(string[] args)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Type messages to send to Kafka. Press Ctrl+C to exit.");
        while (true)
        {
            Console.Write("You: ");
            var message = Console.ReadLine();

            await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
        }
    }
}
