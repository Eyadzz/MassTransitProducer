namespace SharedLibrary;

public interface NotificationMessage
{
    public string? Message { get; set; }
    public string? Url { get; set; }
    public string? Section { get; set; }
    public int ReceiverId { get; set; }
}