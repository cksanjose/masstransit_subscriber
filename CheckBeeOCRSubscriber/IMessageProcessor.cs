using CheckBee.Messages;

namespace CheckBeeOCRSubscriber
{
    public interface IMessageProcessor<in T, TResult> where T : IMessage
    {
        TResult Execute(T message);
    }
}
