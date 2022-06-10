using PersiciFinancial.CustomerManagement.Domain.Models.Customers.Exceptions;
using PhoneNumbers;

namespace PersiciFinancial.CustomerManagement.Domain.Models.Customers.Services
{
    public static class MobileValidator
    {
        private static readonly PhoneNumberUtil PhoneNumberUtil = PhoneNumberUtil.GetInstance();
        public static bool IsValid(string phoneNumber)
        {
            try
            {
                var posibleNumber = PhoneNumberUtil.Parse(phoneNumber, "");
                GuardAgainstPhoneNumberType(posibleNumber);

                return PhoneNumberUtil.IsValidNumber(posibleNumber);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static void GuardAgainstPhoneNumberType(PhoneNumber posibleNumber)
        {
            var phoneType = PhoneNumberUtil.GetNumberType(posibleNumber);
            if (phoneType != PhoneNumberType.MOBILE)
                throw new InvalidMobileNumberException();
        }
    }
}
