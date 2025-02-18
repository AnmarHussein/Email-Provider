using ToolKit.Emails.Dtos;

namespace ToolKit.Configurations;
public class ToolkitSetting
{
    public string Key { get; set; }
    public EmailSetting EmailSettings { get; set; }
}
