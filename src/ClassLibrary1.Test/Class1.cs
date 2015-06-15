using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;

namespace ClassLibrary1.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void T()
        {
            //IWebDriver driver = new PhantomJSDriver();
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://google.com/");
            Console.WriteLine(driver.Title);
            driver.Quit();
        }
    }
}
