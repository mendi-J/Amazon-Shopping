
using NUnit.Framework;
using OpenQA.Selenium;

namespace Amazon.Pages
{
    public class AmazonHomePage
    {
        private readonly IWebDriver driver;
        private readonly By searchBox = By.XPath("//input[@id='twotabsearchtextbox']");
        private readonly By searchButton = By.XPath("//input[@id='nav-search-submit-button']");
        private readonly By reloadCaptcha = By.XPath("//a[@onclick='window.location.reload()']");

        public AmazonHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SearchForItem(string searchTerm)
        {
            driver.FindElement(searchBox).SendKeys(searchTerm);
            driver.FindElement(searchButton).Click();
        }
    }

}
