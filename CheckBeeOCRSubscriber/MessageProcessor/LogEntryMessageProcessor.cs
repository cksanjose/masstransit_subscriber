using CheckBee.Messages.Messages;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace CheckBeeOCRSubscriber.MessageProcessor
{
    public class LogEntryMessageProcessor : IConsumer<LogEntryMessage>
    {
        public Task Consume(ConsumeContext<LogEntryMessage> context)
        {
            //var payload = context.GetPayload<LogEntryMessage>();
            Console.Out.WriteLineAsync($"Value was entered: {context.Message.Message.MessageBody}");
            return Task.FromResult(0);
        }
    }
}
