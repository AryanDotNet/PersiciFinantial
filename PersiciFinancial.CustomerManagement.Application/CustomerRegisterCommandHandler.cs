using PersiciFinancial.CustomerManagement.Application.Contracts;
using PersiciFinancial.CustomerManagement.Domain.Models.Customers;
using PersiciFinancial.CustomerManagement.Domain.Models.Customers.Exceptions;
using PersiciFinancial.CustomerManagement.Domain.Models.Customers.Services;

namespace PersiciFinancial.CustomerManagement.Application
{
    public class CustomerRegisterCommandHandler
    {
        private ICustomerRepository repository;

        public CustomerRegisterCommandHandler(ICustomerRepository repository)
        {
            this.repository = repository;
        }

        public void Handle(CustomerRegisterCommand command)
        {
            var customer = ConvertCommandToCustomer(command);
            repository.RegisterCustomer(customer);
        }

        private Customer ConvertCommandToCustomer(CustomerRegisterCommand command)
        {
            return new Customer(command.FirstName, command.LastName,
                                    command.DateOfBirth, command.PhoneNumber,
                                    command.Email, command.BankAccountNumber);
        }
    }
}