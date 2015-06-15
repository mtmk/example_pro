using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace ClassLibrary1.Test
{
    [Binding]
    public sealed class StepDefinition1 : IDisposable
    {
        public StepDefinition1()
        {
            Console.WriteLine("### .ctor");
            _driver = new FirefoxDriver();
        }
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        private int _total;
        private readonly FirefoxDriver _driver;

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see http://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            _total += number;
            _driver.Navigate().GoToUrl("http://google.com");
            //ScenarioContext.Current.Pending();
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            //TODO: implement act (action) logic
            Console.WriteLine("### " + _driver.Title);
            //ScenarioContext.Current.Pending();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            //ScenarioContext.Current.Pending();
            Assert.AreEqual(result, _total);
        }

        public void Dispose()
        {
            Console.WriteLine("### disposed");
            _driver.Dispose();
        }
    }
}
