using System.Collections.Generic;

namespace CheckBee.Messages
{
    public interface IMessageEnvelope
    {
        string MessageId { get; set; }

        string DestinationAddress { get; set; }

        IDictionary<string, object> Headers { get; set; }

        IMessage Message { get; set; }

        string[] MessageType { get; set; }

    }
}
