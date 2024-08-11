# Starter Project

This project demonstrates how to set up and run a RabbitMQ instance using Docker. Follow the instructions below to get started.

## Prerequisites

- Docker installed on your machine
- Basic knowledge of Docker and RabbitMQ

## Getting Started

### Pull the RabbitMQ Docker Image

To pull the RabbitMQ Docker image, run the following command in your terminal:

docker pull rabbitmq:latest

### Run the RabbitMQ Container

To run the RabbitMQ container, use the following command:

docker run -d --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:latest

This command will:
- Run the RabbitMQ container in detached mode (`-d`)
- Name the container `rabbitmq`
- Map port `5672` for RabbitMQ and port `15672` for the RabbitMQ management plugin

### Access RabbitMQ Management Interface

Once the container is running, you can access the RabbitMQ management interface by navigating to `http://localhost:15672` in your web browser. The default username and password are both `guest`.

## Stopping the RabbitMQ Container

To stop the RabbitMQ container, run: 

docker stop rabbitmq

To remove the container, run:
docker rm rabbitmq

## Conclusion

That's it! You now have a RabbitMQ instance running in a Docker container. You can use this instance to develop and test your applications that require RabbitMQ messaging.

For more information on RabbitMQ, check out the [official documentation](https://www.rabbitmq.com/documentation.html).

## Additional Resources

- [RabbitMQ Documentation](https://www.rabbitmq.com/documentation.html)
- [Docker Documentation](https://docs.docker.com/)

## License

This project is licensed under the MIT License.
