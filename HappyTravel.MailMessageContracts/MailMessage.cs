namespace HappyTravel.MailMessageContracts;

public class MailMessage
{
    public string TemplateId { get; set; } = string.Empty;
    public IEnumerable<string> Recipients { get; set; } = Array.Empty<string>();
    public object? Data { get; set; }
    public List<MailAttachment>? Attachments { get; set; }
}