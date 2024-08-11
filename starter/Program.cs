using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory();
factory.HostName = "localhost";
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);

for (int i = 1; i <= 100; i++)
{
    string message = "Item dispatched no"+ i;
    var body = Encoding.UTF8.GetBytes(message);
    Console.WriteLine(message);


    channel.BasicPublish(exchange: "", routingKey: "hello", basicProperties: null, body: body);
}

Console.WriteLine("Messages Sent");
Console.ReadLine();
