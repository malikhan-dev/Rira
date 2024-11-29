using Application.Contracts.Commands.Results;
using MediatR;

namespace Application.Pipelines
{
    public class ExceptionHandledCommandBehaviour<Treq, Tres> : IPipelineBehavior<Treq, BaseCommandResult<bool>> where Tres : BaseCommandResult<bool>
    {
        public ExceptionHandledCommandBehaviour()
        {

        }
        public async Task<BaseCommandResult<bool>> Handle(Treq request, RequestHandlerDelegate<BaseCommandResult<bool>> next, CancellationToken cancellationToken)
        {
            try
            {
                return await next();
            }
            catch (Exception ex)
            {
                var response = new BaseCommandResult<bool>()
                {
                    Success = false,
                    Data = false,
                    Description = "Unexpected error"
                };
                return response;
            }
        }
    }
}
