using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToolKit.Emails;
using ToolKit.Emails.EmailSenders;
using ToolKit.Emails.Services;

namespace ToolKit.Configurations;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddToolkitSettings(this IServiceCollection services ,IConfiguration configuration)
    {
        services.Configure<ToolkitSetting>(configuration.GetSection("ToolkitSettings"));
        return services; 
    } 
    
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IEmailService , EmailService>();
        services.AddScoped<IEmailSender, SmtpEmailSender>();
        services.AddScoped<IEmailSender, MimeKitEmailSender>();
        return services; 
    }
}
