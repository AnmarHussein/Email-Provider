using System.Net.Mail;

namespace ToolKit.Emails.Dtos;
public class EmailMessage
{
    public List<string> To { get; set; } = new();
    public List<string> Cc { get; set; } = new();
    public List<string> Bcc { get; set; } = new();
    public string Subject { get; set; }
    public string Body { get; set; }
    public bool IsBodyHtml { get; set; }
    public List<EmailAttachment> Attachments { get; set; } = new();
}
