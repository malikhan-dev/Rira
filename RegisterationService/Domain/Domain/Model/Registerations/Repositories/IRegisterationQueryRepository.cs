namespace Domain.Model.Registerations.Repositories
{
    public interface IRegisterationQueryRepository
    {
        public bool AnyNationalCode(string nationalCode);
        Registeration Get(int id);

    }
}
