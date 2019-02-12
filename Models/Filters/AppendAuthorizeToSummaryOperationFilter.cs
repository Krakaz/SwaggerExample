using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SwaggerExample.Models.Filters
{
    public class AppendAuthorizeToSummaryOperationFilter : IOperationFilter
    {
        private static void AppendRoles(IEnumerable<AuthorizeAttribute> authorizeAttributes, StringBuilder authorizationDescription)
        {
            var roles = authorizeAttributes
                .Where(a => !string.IsNullOrEmpty(a.Roles))
                .Select(a => a.Roles)
                .OrderBy(role => role);

            if (roles.Any())
            {
                authorizationDescription.Append($" roles: {string.Join(", ", roles)};");
            }
        }

        public void Apply(Operation operation, OperationFilterContext context)
        {
            var authorizeAttributes = context.MethodInfo.DeclaringType.GetCustomAttributes(true)
                .Union(context.MethodInfo.GetCustomAttributes(true))
                .OfType<AuthorizeAttribute>()
                .ToList();

            if (authorizeAttributes.Any())
            {
                var authorizationDescription = new StringBuilder(" (Auth");

                AppendRoles(authorizeAttributes, authorizationDescription);

                operation.Summary += authorizationDescription.ToString().TrimEnd(';') + ")";
            }
        }
    }
}
