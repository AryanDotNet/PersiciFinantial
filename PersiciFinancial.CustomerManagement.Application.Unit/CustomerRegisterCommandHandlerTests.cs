using AutoFixture;
using FluentAssertions;
using NSubstitute;
using PersiciFinancial.CustomerManagement.Application.Contracts;
using PersiciFinancial.CustomerManagement.Domain.Models.Customers;
using PersiciFinancial.CustomerManagement.Domain.Models.Customers.Services;
using System;
using Xunit;

namespace PersiciFinancial.CustomerManagement.Application.Unit
{
    public class CustomerRegisterCommandHandlerTests
    {
        [Fact]
        public void Should_create_customer()
        {
            var command = new CustomerRegisterCommand()
            {
                PhoneNumber = "+989128907347",
                BankAccountNumber = "1201225411",
                DateOfBirth = DateTime.Parse("1987/04/09"),
                Email ="aryanpour.dev@gmail.com",
                FirstName="Mohammad",
                LastName="Aryanpour"
            };
            var repository = Substitute.For<ICustomerRepository>();
            var commandHnadler = new CustomerRegisterCommandHandler(repository);

            commandHnadler.Handle(command);

            repository.Received(1).RegisterCustomer(Verify.That<Customer>(c => c.Should().BeEquivalentTo(command)));
        }
    }
}