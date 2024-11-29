using Application.Contracts.Commands;
using Edge.Grpc;
using Edge.Grpc.Adapters;
using Grpc.Core;
using MediatR;
namespace Edge.Grpc.Services
{
    public class RegisterationService : Registeration.RegisterationBase
    {
        private readonly IMediator _mediator;

        public RegisterationService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public override async Task<RegisterationResponse> Register(RegisterationRequest request, ServerCallContext context)
        {
            var command = request.AdaptToCommand();

            var result = await _mediator.Send(command);

            var response = result.AdaptToResponse();

            return response;
        }

        public override async Task<RegisterationResponse> Delete(RegistererId request, ServerCallContext context)
        {
            var command = request.Id;

            var result = await _mediator.Send(new DeleteRegistererCommand(request.Id));

            var response = result.AdaptToResponse();

            return response;
        }

        public override async Task<RegisterationResponse> Update(RegisterationRequest request, ServerCallContext context)
        {
            var command = request.AdaptToUpdateCommand();

            var result = await _mediator.Send(command);

            var response = result.AdaptToResponse();

            return response;
        }
    }
}
