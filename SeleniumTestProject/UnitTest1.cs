using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestProject
{
    public class Tests
    {
        String u = "https://www.tutorialspoint.com/index.htm";
        IWebDriver d;
        [SetUp]
        public void Setup()
        {
            d = new ChromeDriver();
        }
        [Test]
        public void Test1()
        {
            d.Navigate().GoToUrl(u);
            Console.WriteLine("Url launched");
        }
        [TearDown]
        public void close_Browser()
        {
            d.Quit();
        }
    }
}