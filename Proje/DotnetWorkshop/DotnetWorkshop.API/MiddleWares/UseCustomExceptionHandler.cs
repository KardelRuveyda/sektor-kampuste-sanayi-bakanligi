using DotnetWorkshop.Core.DTOs;
using DotnetWorkshop.Service.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DotnetWorkshop.API.MiddleWares
{
    public static class UseCustomExceptionHandler
    {
        public static void UseCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = "application/json";

                    var exceptionFeature = context.Features.Get<IExceptionHandlerFeature>();

                    var statusCode = exceptionFeature.Error switch
                    {
                        ClientSideException => 400,
                        NotFoundException => 404,
                        _ => 500
                    };

                    context.Response.StatusCode = statusCode;

                    var response = GlobalResponseDto<NoContentDto>.Fail(statusCode, exceptionFeature.Error.Message);
                    await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                });

            });
        }
    }
}
