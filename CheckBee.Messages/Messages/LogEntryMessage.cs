using System.Collections.Generic;

namespace CheckBee.Messages.Messages
{
    public class LogEntryMessage
    {
        public string DestinationAddress { get; set; }

        public string MessageId { get; set; }

        public string ConversationId { get; set; }

        public string SourceAddress { get; set; }

        public HostInfo Host { get; set; }

        public IDictionary<string, object> Headers { get; set; }

        public LogEntryPayload Message { get; set; }

        public string[] MessageType { get; set; }
    }
}
