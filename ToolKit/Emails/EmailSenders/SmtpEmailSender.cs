
using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net;
using ToolKit.Configurations;
using ToolKit.Emails.Dtos;
using System.Net.Mime;

namespace ToolKit.Emails.EmailSenders;
public class SmtpEmailSender : IEmailSender
{
    private readonly EmailSetting _emailSetting;
    public SmtpEmailSender(IOptions<ToolkitSetting> options)
    {
        _emailSetting = options.Value.EmailSettings;
    }

    public async Task SendAsync(EmailMessage email)
    {
        SmtpClient smtpClient = CreateSmtpClientInstans();

        using var mailMessage = new MailMessage
        {
            From = new MailAddress(_emailSetting.SenderEmail , _emailSetting.SenderName) ,
            Subject = email.Subject ,
            Body = email.Body ,
            IsBodyHtml = email.IsBodyHtml
        };

        email.To.ForEach(to => mailMessage.To.Add(to));
        email.Cc?.ForEach(cc => mailMessage.CC.Add(cc));
        email.Bcc?.ForEach(bcc => mailMessage.Bcc.Add(bcc));

        foreach (var attachment in email.Attachments)
        {
            mailMessage.Attachments.Add(new Attachment(
               new MemoryStream(attachment.Content) ,
                attachment.FileName ,
                attachment.MediaType
            ));
        }


        await smtpClient.SendMailAsync(mailMessage);
        smtpClient.Dispose();
    }


    private SmtpClient CreateSmtpClientInstans()
    {
        var smtpClient = new SmtpClient(_emailSetting.Server , _emailSetting.Port)
        {
            EnableSsl = _emailSetting.EnableSsl ,
            Credentials = new NetworkCredential(_emailSetting.Username , _emailSetting.Password)
        };

        return smtpClient;
    }
}
