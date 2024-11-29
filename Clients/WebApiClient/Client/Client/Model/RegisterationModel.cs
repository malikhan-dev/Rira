namespace Client.Model
{
    public class RegisterationModel
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string NationalCode { get;  set; }
        public DateTime DateOfBirth { get;  set; }
    }

    public class UpdateRegisterationModel : RegisterationModel
    {
        public int Id { get; set; }

    }
}
