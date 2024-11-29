using Application.Contracts.Commands;
using Application.Contracts.Commands.Results;
using Application.Contracts.DTO;
using Google.Protobuf.WellKnownTypes;

namespace Edge.Grpc.Adapters
{
    public static class GrpcToCommandAdapter
    {
        public static RegisterCommand AdaptToCommand(this RegisterationRequest request)
            => new RegisterCommand(request.Id, request.FName, request.LName, request.NationalCode, request.Dob.ToDateTime());

        public static UpdateRegistererCommand AdaptToUpdateCommand(this RegisterationRequest request)
           => new UpdateRegistererCommand(request.Id, request.FName, request.LName, request.NationalCode, request.Dob.ToDateTime());

        public static RegisterationResponse AdaptToResponse<T>(this BaseCommandResult<T> response)
            => new RegisterationResponse()
            {
                Suceeded = response.Success,
                Message = response?.Description?.ToString() ?? string.Empty,
            };

        public static RegistererResponse AdaptRegistererQuery(this RegistererDto dto)
           => new RegistererResponse()
           {
               Dob = Timestamp.FromDateTime(dto.DateOfBirth.ToUniversalTime()),
               FName = dto.FirstName,
               NationalCode = dto.NationalCode,
               LName = dto.LastName,
               Id = dto.Id,
           };

    }
}
