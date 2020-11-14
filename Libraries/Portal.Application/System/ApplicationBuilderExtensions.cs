using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.System
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder ConfigSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Portal API V1");
            });
            return app;
        }
    }
}