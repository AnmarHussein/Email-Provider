using ToolKit.Emails.Dtos;

namespace ToolKit.Emails.EmailBuilders;
public class EmailBuilder
{
    private readonly EmailMessage _email = new();
    public EmailBuilder AddTo(params string[] emails)
    {
        _email.To.AddRange(emails);
        return this;
    }

    public EmailBuilder AddCc(params string[] emails)
    {
        _email.Cc.AddRange(emails);
        return this;
    }

    public EmailBuilder AddBcc(params string[] emails)
    {
        _email.Bcc.AddRange(emails);
        return this;
    }

    public EmailBuilder SetSubject(string subject)
    {
        _email.Subject = subject;
        return this;
    }

    public EmailBuilder SetBody(string body , bool isHtml = true)
    {
        _email.Body = body;
        _email.IsBodyHtml = isHtml;
        return this;
    }

    public EmailBuilder AddAttachment(EmailAttachment attachment)
    {
        _email.Attachments.Add(attachment);
        return this;
    }

    public EmailBuilder AddAttachments(IEnumerable<EmailAttachment> attachments)
    {
        _email.Attachments.AddRange(attachments);
        return this;
    }

    public EmailMessage Build() => _email;
}
