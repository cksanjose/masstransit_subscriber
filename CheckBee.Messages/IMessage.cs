namespace CheckBee.Messages
{
    public interface IMessage
    {
        int Id { get; set; }

        string RoutingKey { get; set; }

        string MessageBody { get; set; }
    }
}
