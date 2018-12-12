using Microsoft.AspNetCore.Http;

namespace dotnetcore_docker
{
    public class ProtectFolderOptions
    {
        public PathString Path { get; set; }
        public string PolicyName { get; set; }
    }
}