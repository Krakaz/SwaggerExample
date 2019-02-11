using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SwaggerExample.Models
{
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) =>
            this.provider = provider;

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(
                    description.GroupName,
                    new Info()
                    {
                        Title = $"Swagger Example API {description.ApiVersion}",
                        Version = description.ApiVersion.ToString(),
                        Description = "Пример использования Swagger в ASP.NET Core Web API",
                        TermsOfService = "None",
                        Contact = new Contact
                        {
                            Name = "Денис Кузнецов",
                            Email = "denis.kuznetcov@simbirsoft.com",
                            Url = "https://www.linkedin.com/in/DKuznetsovDotNet/"
                        },
                        License = new License() { Name = "None" },
                    });
            }
        }
    }
}