using System;
using FluentAssertions;
using PersiciFinancial.CustomerManagement.Domain.Models.Customers;
using PersiciFinancial.CustomerManagement.Domain.Models.Customers.Exceptions;
using Xunit;

namespace PersiciFinancial.CustomerManagement.Test.Unit
{
    public class CustomerTests
    {
        [Fact]
        public void Constructor_should_construct_customer()
        {
            var firstName = "Mohammad";
            var lastName = "Aryanpour";
            var dateOfBirth = DateTime.Parse("09/04/1987");
            var phoneNumber = "+989128907347";
            var email = "aryanpour.dev@gmail.com";
            var bankAccountNumber = "202305060847";


            var builder = new CustomerTestBuilder()
                .WithFirstName(firstName)
                .WithLastName(lastName)
                .WithDateOfBirth(dateOfBirth)
                .WithPhoneNumber(phoneNumber)
                .WithEmail(email);

            var customer = builder.Build();

            customer.FirstName.Should().Be(firstName);
            customer.LastName.Should().Be(lastName);
            customer.DateOfBirth.Should().Be(dateOfBirth);
            customer.PhoneNumber.Should().Be(phoneNumber);
            customer.Email.Should().Be(email);
            customer.BankAccountNumber.Should().Be(bankAccountNumber);
        }
        // this comment is a test for checking pull request
        [Theory]
        [InlineData("+98912758417")]
        [InlineData("989127584170")]
        [InlineData("09127584170")]
        public void Cunstructor_should_throw_exception_when_mobile_is_not_valid(string invalidMobileNumber)
        {
            var phoneNumber = invalidMobileNumber;
            var builder = new CustomerTestBuilder().WithPhoneNumber(invalidMobileNumber);

            Action customer = () => builder.Build();

            customer.Should().Throw<InvalidMobileNumberException>();
        }
    }
}