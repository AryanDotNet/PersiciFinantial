namespace PersiciFinancial.CustomerManagement.Domain.Models.Customers.Exceptions
{
    public class InvalidMobileNumberException : Exception
    {
        public InvalidMobileNumberException() : base("Invalid Mobile number")
        {
        }
    }
}
