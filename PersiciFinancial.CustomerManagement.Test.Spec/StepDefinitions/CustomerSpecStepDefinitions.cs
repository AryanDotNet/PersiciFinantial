using PersiciFinancial.CustomerManagement.Application.Contracts;
using PersiciFinancial.CustomerManagement.Interface.Facade;
using PersiciFinancial.CustomerManagement.Persistence;
using PersiciFinancial.CustomerManagement.Persistence.Repositories;
using TechTalk.SpecFlow.Assist;

namespace PersiciFinancial.CustomerManagement.Test.Spec.StepDefinitions
{
    [Binding]
    public class CustomerSpecStepDefinitions
    {
        [Given(@"I have registered as following")]
        public void GivenIHaveRegisteredAsFollowing(Table table)
        {
            var registerCustomerCommand = table.CreateInstance<CustomerRegisterCommand>();
            var facade = new CustomerManagementFacade();
            var dbContext = new CustomerManagementContext();
            var repository = new CustomerRepository(dbContext);
            facade.CustomerRegister(registerCustomerCommand, repository);
        }

        [When(@"I register")]
        public void WhenIRegister()
        {

        }

        [Then(@"I should redirect to my profile")]
        public void ThenIShouldRedirectToMyProfile()
        {

        }

        [Given(@"I have already registered in the web site as follwing")]
        public void GivenIHaveAlreadyRegisteredInTheWebSiteAsFollwing(Table table)
        {

        }

        [Given(@"I'm going to register as following")]
        public void GivenImGoingToRegisterAsFollowing(Table table)
        {

        }

        [Then(@"the system should warn me you have already registered")]
        public void ThenTheSystemShouldWarnMeYouHaveAlreadyRegistered()
        {

        }

        [Given(@"I have already registered in the web site with '([^']*)' email")]
        public void GivenIHaveAlreadyRegisteredInTheWebSiteWithEmail(string p0)
        {

        }

        [Given(@"I try to register as following")]
        public void GivenITryToRegisterAsFollowing(Table table)
        {

        }

        [Then(@"the system should warn me the email is duplicated")]
        public void ThenTheSystemShouldWarnMeTheEmailIsDuplicated()
        {

        }
    }
}
