namespace PersiciFinancial.CustomerManagement.Domain.Models.Customers.Exceptions
{
    public class EmailValidatorException : Exception
    {
        public EmailValidatorException(string email) : base($"Invalid {email}")
        {
        }
    }
}
