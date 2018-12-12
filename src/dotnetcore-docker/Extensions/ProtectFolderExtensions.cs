using dotnetcore_docker.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace dotnetcore_docker.Extensions
{
    
    /// See https://odetocode.com/blogs/scott/archive/2015/10/06/authorization-policies-and-middleware-in-asp-net-5.aspx
    public static class ProtectFolderExtensions
    {
        public static IApplicationBuilder UseProtectFolder(
        this IApplicationBuilder builder, 
        ProtectFolderOptions options)
    {
        return builder.UseMiddleware<ProtectFolder>(options);
    }
    }
}