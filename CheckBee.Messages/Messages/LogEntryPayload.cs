namespace CheckBee.Messages.Messages
{
    public class LogEntryPayload : IMessage
    {
        public int Id { get; set; }

        public string MessageBody { get; set; }

        public int LogType { get; set; }

        public string RoutingKey { get; set; }
    }

}
