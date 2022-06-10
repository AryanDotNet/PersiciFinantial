namespace PersiciFinancial.CustomerManagement.Domain.Models.Customers.Services
{
    public interface ICustomerRepository
    {
        void RegisterCustomer(Customer customer);

        bool IsExistCustomer(string name, string lastName, DateTime dateOfBirth);
    }
}
