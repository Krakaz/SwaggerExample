using Microsoft.AspNetCore.Mvc;

namespace SwaggerExample.Models.Conventions
{
    public static class SwaggerExampleConventions
    {
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(Error), 404)]
        public static void Find(object filter)
        {
        }
    }
}
