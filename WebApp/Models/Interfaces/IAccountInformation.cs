namespace WebApp.Models.Interfaces
{
    public interface IAccountInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ProfileImage { get; set; }
    }
}
