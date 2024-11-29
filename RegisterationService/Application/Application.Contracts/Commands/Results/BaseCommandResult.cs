namespace Application.Contracts.Commands.Results
{
    public class BaseCommandResult<TData>
    {
        public bool Success { get; set; }
        public string Description { get; set; }
        public TData Data { get; set; }
    }
}
