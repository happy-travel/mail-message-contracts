namespace HappyTravel.MailMessageContracts;

public class MailAttachment
{
    public byte[] Content { get; set; } = Array.Empty<byte>();
    public string Type { get; set; } = string.Empty;
    public string Filename { get; set; } = string.Empty;
    public string Disposition { get; set; } = string.Empty;
}