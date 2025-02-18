namespace ToolKit.Emails.Dtos;
public class EmailSetting
{
    public bool IsEnable { get; set; }
    public string Provider { get; set; }
    public string Server { get; set; }
    public int Port { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool EnableSsl { get; set; }
    public string SenderEmail { get; set; }
    public string SenderName { get; set; }
}
