using CheckBeeOCRSubscriber.MessageProcessor;
using MassTransit;
using System;
using Topshelf;

namespace CheckBeeOCRSubscriber
{
    public class Program
    {
        public static void Main()
        {
            HostFactory.Run(cfg => cfg.Service(x => new EventConsumerService()));
        }
    }

    class EventConsumerService : ServiceControl
    {
        IBusControl _bus;

        public bool Start(HostControl hostControl)
        {
            _bus = ConfigureBus();
            _bus.Start();

            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            _bus?.Stop(TimeSpan.FromSeconds(30));

            return true;
        }

        IBusControl ConfigureBus()
        {
            return Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                var host = cfg.Host(new Uri("rabbitmq://localhost"), h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });

                cfg.ReceiveEndpoint(host, "LogEntryQueue", e =>
                {
                    e.UseBinarySerializer();
                    e.Consumer<LogEntryMessageProcessor>();
                    //e.Handler<LogEntryMessage>(context =>
                    //Console.Out.WriteLineAsync($"Value was entered: {context.Message.Message.MessageBody}"));
                });
            });
        }
    }
}
