using ToolKit.Emails.Dtos;

namespace ToolKit.Emails.EmailSenders;
public interface IEmailSender
{
    Task SendAsync(EmailMessage email);
}
