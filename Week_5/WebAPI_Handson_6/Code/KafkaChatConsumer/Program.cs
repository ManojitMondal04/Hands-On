using Confluent.Kafka;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "chat-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Null, string>(config).Build();
        consumer.Subscribe("chat-topic");

        Console.WriteLine("Listening for messages...");
        while (true)
        {
            var result = consumer.Consume();
            Console.WriteLine($"Friend: {result.Message.Value}");
        }
    }
}
