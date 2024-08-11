//using RabbitMQ.Client;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

var factory = new ConnectionFactory();
factory.HostName = "localhost";
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();


var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine(" [x] Received {0}", message);

};

channel.BasicConsume(queue: "hello", autoAck: true, consumer: consumer);

Console.WriteLine("Press [enter] to exit.");
Console.ReadLine();