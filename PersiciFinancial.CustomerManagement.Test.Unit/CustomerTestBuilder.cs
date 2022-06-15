using PersiciFinancial.CustomerManagement.Domain.Models.Customers;
using System;

namespace PersiciFinancial.CustomerManagement.Test.Unit
{
    internal class CustomerTestBuilder
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string BankAccountNumber { get; set; }
        public CustomerTestBuilder()
        {
            var FirstName = "Mohammad";
            var LastName = "Aryanpour";
            var DateOfBirth = DateTime.Parse("09/04/1987");
            var Email = "aryanpour.dev@gmail.com";
            var BankAccountNumber = "202305060847";
        }
        public CustomerTestBuilder WithFirstName(string firstName)
        {
            FirstName = firstName;
            return this;
        }

        public CustomerTestBuilder WithLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }
        public CustomerTestBuilder WithDateOfBirth(DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
            return this;
        }
        public CustomerTestBuilder WithPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
            return this;
        }
        public CustomerTestBuilder WithEmail(string email)
        {
            Email=email;
            return this;
        }
        public CustomerTestBuilder WithBankAccountNumber(string bankAccountNumber)
        {
            BankAccountNumber = bankAccountNumber;
            return this;
        }

        public Customer Build()
        {
            return  new Customer(FirstName,LastName,DateOfBirth,PhoneNumber,Email,BankAccountNumber);
        }
    }
}
