using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleWebAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:7106/");
        }
    }
}