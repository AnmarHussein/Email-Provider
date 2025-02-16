using Microsoft.Extensions.Options;
using ToolKit.Configurations;

namespace ToolKit.Emails;
public class EmailSender(IOptions<ToolkitSetting> options) : IEmailSender
{
    public async Task SendAsync()
    {
        var x = options.Value.Key;
    }
}
