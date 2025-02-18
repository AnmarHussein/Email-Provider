using ToolKit.Emails.Dtos;
using ToolKit.Emails.EmailBuilders;
using ToolKit.Emails.EmailSenders;

namespace ToolKit.Emails.Services;
public class EmailService(IEmailSender _emailSender) : IEmailService
{
    public async Task SendEmailAsync()
    {
        EmailMessage emailMessage = new EmailBuilder()
            .SetSubject("Subject")
            .AddTo("anmar.hussein.okour@gmail.com")
            .SetBody("Dont Wary <b>Will Do</b>")
            .Build();

        await _emailSender.SendAsync(emailMessage);
    }
}
