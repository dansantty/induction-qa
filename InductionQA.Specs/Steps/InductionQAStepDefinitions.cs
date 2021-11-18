using FluentAssertions;
using TechTalk.SpecFlow;

namespace InductionQA.Specs.Steps
{
    [Binding]
    public sealed class InductionQAStepDefinitions
    {
        public int Day;
        public double FinalPrice;
        public double Price;

        private readonly ScenarioContext _scenarioContext;

        private readonly TicketFly _ticketFly = new TicketFly();

        public InductionQAStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("i want go to London")]
        public void GivenIWantGoToLondon()
        {

        }

        [Given("be a day of (.*)")]
        public void GivenBeADayOf(int day)
        {
            Day = day;
        }

        [Given("(.*) vip customer (.*)")]
        public void GivenVipCustomer(string vip, double value)
        {

            if (vip == "i am")
            {
                FinalPrice = _ticketFly.GetDiscount(value);
            }
            else

                FinalPrice = value;

        }

        [When("i do the payment")]
        public void WhenIDoThePayment()
        {
            _ticketFly.DoPayment(FinalPrice);
        }

        [Then("i will pay (.*)")]
        public void ThenIWillPay(double value)
        {
            FinalPrice.Should().Be(value);
        }


    }
}
