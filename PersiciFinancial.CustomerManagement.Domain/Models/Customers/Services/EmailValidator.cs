using FluentValidation;
using FluentValidation.Validators;


namespace PersiciFinancial.CustomerManagement.Domain.Models.Customers.Services
{
    public class EmailValidator : AbstractValidator<string>
    {
        public EmailValidator()
        {
            RuleFor(e => e).EmailAddress(EmailValidationMode.Net4xRegex).WithMessage("Email Is not valid");
        }
        public bool IsValid(string emailAddress)
        {
            return Validate(emailAddress).IsValid;
        }
    }
}
