namespace MassTransitProducer;

public class EmailDto
{
    public string EmailAddress { get; set; }
    public int ReceiverId { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}