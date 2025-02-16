using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToolKit.Emails;

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
        services.AddScoped<IEmailSender, EmailSender>();
        return services; 
    }
}
