namespace SharedLibrary;

public interface EmailMessage
{
    public string EmailAddress { get; set; }
    public int ReceiverId { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}