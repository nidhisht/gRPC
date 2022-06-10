using Grpc.Net.Client;
using gRPCServer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace gRPCApiClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetController : Controller
    {
        public EnvironmentVariable EnvironmentVariable { get; set; }
        public GreetController(IOptions<EnvironmentVariable> env)
        {
            EnvironmentVariable = env.Value;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            return await InvokeGrpc("world");
        }


        [HttpGet("{name}")]
        public async Task<string> GetName(string name = "world")
        {
            return await InvokeGrpc(name);
        }

        private async Task<string> InvokeGrpc(string name)
        {
            string response = string.Empty;
            try
            {
                // The port number(5001) must match the port of the gRPC server.
                using var channel = GrpcChannel.ForAddress(EnvironmentVariable.gRPCServerUrl);

                var client = new Greeter.GreeterClient(channel);
                var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
                Console.WriteLine("Reply from gRPC Service:" + reply.Message);

                response = reply.Message;
            }
            catch (Exception ex)
            {
                response = ex.Message;
                Console.WriteLine(response);
            }
            return response;
        }
    }
}
