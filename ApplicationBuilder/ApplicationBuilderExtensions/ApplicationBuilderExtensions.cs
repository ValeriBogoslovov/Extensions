namespace ApplicationBuilderExtensions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Threading.Tasks;

    public static class ApplicationBuilderExtensions
    {
        //call this method inside 'Configure' method in 'Startup.cs' --> ASP.NET Core 2.0
        public static IApplicationBuilder UseDatabaseMigrations(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices
                                         .GetRequiredService<IServiceProvider>()
                                         .CreateScope())
            {
                serviceScope.ServiceProvider.GetService<YourDbContext>
            }

            return app;
        }
    }

    public class YourDbContext : DbContext
    {

    }
}
