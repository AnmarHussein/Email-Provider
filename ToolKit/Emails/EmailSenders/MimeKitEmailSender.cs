using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using ToolKit.Configurations;
using ToolKit.Emails.Dtos;

namespace ToolKit.Emails.EmailSenders;
public class MimeKitEmailSender : IEmailSender
{
    private readonly EmailSetting _emailSetting;
    public MimeKitEmailSender(IOptions<ToolkitSetting> options)
    {
        _emailSetting = options.Value.EmailSettings;
    }

    public async Task SendAsync(EmailMessage email)
    {
        var mimeMessage = new MimeMessage();
        mimeMessage.From.Add(MailboxAddress.Parse(_emailSetting.SenderEmail));
        mimeMessage.Subject = email.Subject;

        var bodyBuilder = new BodyBuilder
        {
            HtmlBody = email.IsBodyHtml ? email.Body : null ,
            TextBody = email.IsBodyHtml ? null : email.Body
        };

        foreach (var attachment in email.Attachments)
        {
            bodyBuilder.Attachments.Add(attachment.FileName , attachment.Content);
        }

        mimeMessage.Body = bodyBuilder.ToMessageBody();

        foreach (var to in email.To)
        {
            mimeMessage.To.Add(MailboxAddress.Parse(to));
        }

        foreach (var cc in email.Cc)
        {
            mimeMessage.Cc.Add(MailboxAddress.Parse(cc));
        }

        foreach (var bcc in email.Bcc)
        {
            mimeMessage.Bcc.Add(MailboxAddress.Parse(bcc));
        }

        using var client = new SmtpClient();
        await client.ConnectAsync(_emailSetting.Server , _emailSetting.Port);
        await client.AuthenticateAsync(_emailSetting.Username , _emailSetting.Password);
        await client.SendAsync(mimeMessage);
        await client.DisconnectAsync(true);

    }
}
