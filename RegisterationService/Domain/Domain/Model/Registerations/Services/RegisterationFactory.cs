using Domain.Model.Registerations.ValueObject;

namespace Domain.Model.Registerations.Services
{
    public static class RegisterationFactory
    {
        public static Registeration Factory(RegisterationValueObject valueObject)
        {
            return new Registeration(valueObject.firstName, valueObject.lastName, valueObject.nationalCode, valueObject.dob);

        }
    }
}
