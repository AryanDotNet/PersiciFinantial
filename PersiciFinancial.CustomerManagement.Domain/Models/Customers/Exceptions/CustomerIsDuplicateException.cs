namespace PersiciFinancial.CustomerManagement.Domain.Models.Customers.Exceptions
{
    public class CustomerIsDuplicateException : Exception
    {
        public CustomerIsDuplicateException() : base("Customer is duplicate")
        {
        }
    }
}
