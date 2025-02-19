using ToolKit.Emails.Dtos;
using ToolKit.Emails.Dtos.EmailTemplate;
using ToolKit.Emails.EmailBuilders;
using ToolKit.Emails.EmailSenders;
using ToolKit.Emails.Utilities;

namespace ToolKit.Emails.Services;
public class EmailService(IEmailSender _emailSender) : IEmailService
{
    public async Task SendEmailAsync()
    {
        //EmailMessage emailMessage = new EmailBuilder()
        //    .SetSubject("Subject")
        //    .AddTo("anmar.hussein.okour@gmail.com")
        //    .SetBody(HtmlTemplateProvider.NewslettersTemplate())
        //    .WithModel(new User() { FullName = "Test Data" , NameLink = "Click Me" ,Link = "#" })
        //    .Build();

        var order = new OrderDto
        {
            FullName = "Test Data" ,
            NameLink = "View Full Report" ,
            Link = "#" ,
            Items = new()
            {
                new() { ProductName = "Prod 1" ,Quantity = 1 ,Price = 10 },
                new() { ProductName = "Prod 2" ,Quantity = 14 ,Price = 20 },
                new() { ProductName = "Prod 3" ,Quantity = 15 ,Price = 69 }
            }
        };

        EmailMessage emailMessage1 = new EmailBuilder()
            .SetSubject("Subject")
            .AddTo("anmar.hussein.okour@gmail.com")
            .SetBody(HtmlTemplateProvider.DynamicTableTemplate())
            .WithModel(order)
            .Build();

        await _emailSender.SendAsync(emailMessage1);
    }

}
