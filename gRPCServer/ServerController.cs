using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace gRPCServer
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerController : ControllerBase
    {
        [HttpGet]
        public async Task<string> Get()
        {
            return "hello from gRPCServer";
        }
    }
}
