using PersiciFinancial.CustomerManagement.Domain.Models.Customers;
using PersiciFinancial.CustomerManagement.Domain.Models.Customers.Services;

namespace PersiciFinancial.CustomerManagement.Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerManagementContext context;

        public CustomerRepository(CustomerManagementContext context)
        {
            this.context = context;
        }

        public void RegisterCustomer(Customer customer)
        {
            //TODO: remove save changes from here
            this.context.Customers.Add(customer);
            this.context.SaveChanges();
        }

        public bool IsExistCustomer(string firstname, string lastName, DateTime dateOfBirth)
        {
            return this.context.Customers.Any(c => c.FirstName == firstname
                                                   && c.LastName == lastName
                                                   && c.DateOfBirth == dateOfBirth);
        }
    }
}