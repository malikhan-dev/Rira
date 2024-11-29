using Application.Contracts.Commands;
using Application.Contracts.Commands.Results;

namespace Edge.Grpc.Adapters
{
    public static class GrpcToCommandAdapter
    {
        public static RegisterCommand AdaptToCommand(this RegisterationRequest request)
            => new RegisterCommand(request.Id, request.FName, request.LName, request.NationalCode, request.Dob.ToDateTime());


        public static RegisterationResponse AdaptToResponse<T>(this BaseCommandResult<T> response)
            => new RegisterationResponse()
            {
                Suceeded = response.Success,
                Message = response?.Description?.ToString() ?? string.Empty,
            };



    }
}
