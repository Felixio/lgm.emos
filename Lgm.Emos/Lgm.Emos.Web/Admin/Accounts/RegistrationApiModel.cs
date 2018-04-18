using FluentValidation.Attributes;

namespace Lgm.Emos.Web
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class RegistrationApiModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}