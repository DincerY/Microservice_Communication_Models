using System.Text;
using RabbitMQ.Client;

ConnectionFactory factory = new();
factory.Uri = new("amqps://gyakepie:pdpYr1SBb8nP1ZIVmWug8W5GqQ7ImAFL@stingray.rmq.cloudamqp.com/gyakepie");

IConnection connection = factory.CreateConnection();
IModel channel = connection.CreateModel();

channel.ExchangeDeclare(exchange:"direct-exchange-example",type:ExchangeType.Direct);

while (true)
{
    Console.WriteLine("Mesaj :");
    string message = Console.ReadLine();
    byte[] byteMessage = Encoding.UTF8.GetBytes(message);

    channel.BasicPublish(
        exchange: "direct-exchange-example",
        routingKey:"direct-queue-example",
        body: byteMessage);
}

Console.Read();