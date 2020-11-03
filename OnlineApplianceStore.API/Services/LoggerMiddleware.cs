using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.API.Services
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;

        private const string writePath = "logger.txt";

        public LoggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            using (StreamWriter sw = new StreamWriter(
                writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine();
                sw.WriteLine("Request");
                sw.WriteLine($"- Data: {DateTime.Now}");
                sw.WriteLine($"- Type request: {context.Request.Method}");
                sw.WriteLine($"- URL: {context.Request.GetDisplayUrl()}");
                sw.WriteLine($"- User: {context.User.Claims}");
                sw.WriteLine($"    : {context.User.Identity.IsAuthenticated}");
                sw.WriteLine($"- IpAddres: {context.Connection.RemoteIpAddress}");
                sw.WriteLine($"- StatusCode: {context.Response.StatusCode}");
                sw.WriteLine();
            }
            await _next.Invoke(context);
        }
    }
}