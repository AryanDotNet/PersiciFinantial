using PersiciFinancial.CustomerManagement.Domain.Models.Customers.Exceptions;
using PersiciFinancial.CustomerManagement.Domain.Models.Customers.Services;

namespace PersiciFinancial.CustomerManagement.Domain.Models.Customers
{
    public class Customer
    {
        public long Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public string BankAccountNumber { get; private set; }

        private Customer() { }
        public Customer(string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, string bankAccountNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.PhoneNumber = ValidatePhoneNumber(phoneNumber);
            this.Email = ValidateEmail(email);
            this.BankAccountNumber = bankAccountNumber;
        }
        private static string ValidatePhoneNumber(string phoneNumber)
        {
            if (!MobileValidator.IsValid(phoneNumber))
                throw new InvalidMobileNumberException();

            return phoneNumber;
        }
        private static string ValidateEmail(string emailAddress)
        {
            var emailValidator = new EmailValidator();
            if (!emailValidator.IsValid(emailAddress))
                throw new EmailValidatorException(emailAddress);

            return emailAddress;
        }
    }
}
