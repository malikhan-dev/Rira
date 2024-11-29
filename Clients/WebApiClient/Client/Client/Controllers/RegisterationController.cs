using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using Edge.Grpc;
using Google.Protobuf.WellKnownTypes;
using Client.Model;
namespace Client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterationController : ControllerBase
    {
        private readonly string _serverAddress;
        public RegisterationController(IConfiguration configuration)
        {
            _serverAddress = configuration.GetValue<string>("RegisterationServer");

        }

        [HttpPost(Name = "Register")]
        public async Task<ApiResponse> Register([FromBody] RegisterationModel model)
        {

            using var channel = GrpcChannel.ForAddress(_serverAddress);

            var client = new Registeration.RegisterationClient(channel);

            var reply = client.Register(
                              new RegisterationRequest { FName = model.FirstName, NationalCode = model.NationalCode, Dob = Timestamp.FromDateTime(model.DateOfBirth) });

            return new ApiResponse()
            {

                Message = reply.Message,
                Succeeded = reply.Suceeded
            };
            
        }
    }
}
