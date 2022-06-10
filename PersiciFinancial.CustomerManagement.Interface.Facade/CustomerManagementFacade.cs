using PersiciFinancial.CustomerManagement.Application;
using PersiciFinancial.CustomerManagement.Application.Contracts;
using PersiciFinancial.CustomerManagement.Domain.Models.Customers.Services;

namespace PersiciFinancial.CustomerManagement.Interface.Facade
{
    public class CustomerManagementFacade
    {
        public void CustomerRegister(CustomerRegisterCommand command, ICustomerRepository repository)
        {
            //TODO: use commandBus to dispatch command. and use IOCC for repository
            var handler = new CustomerRegisterCommandHandler(repository);
            handler.Handle(command);
        }
    }
}
