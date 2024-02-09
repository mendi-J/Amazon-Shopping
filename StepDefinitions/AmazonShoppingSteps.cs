using System.Diagnostics;
using Amazon.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Amazon.StepDefinitions
{
    [Binding]
    public sealed class AmazonShoppingSteps
    {
        private IWebDriver driver;
        private readonly AmazonHomePage amazonHomePage;
        private readonly AmazonSearchResultsPage amazonSearchResultsPage;
        private readonly AmazonCartPage amazonCartPage;
        private readonly CaptchaSecPage amazonCaptchaSecPage;

        public AmazonShoppingSteps()
        {
            driver = driver = new ChromeDriver();
            amazonHomePage = new AmazonHomePage(driver);
            amazonSearchResultsPage = new AmazonSearchResultsPage(driver);
            amazonCartPage = new AmazonCartPage(driver);
            amazonCaptchaSecPage = new CaptchaSecPage(driver);
        }

        [Given("I open browser")]
        public void GivenIOpenBrowser()
        {
            driver.Manage().Window.Maximize();
        }

        [Given(@"I navigate to Amazon website")]
        public void GivenINavigateToAmazonWebsite()
        {
            driver.Navigate().GoToUrl("https://www.amazon.com/");
            Thread.Sleep(3000);
        }

        [Given(@"I bypass captcha")]
        public void GiveIBypassCaptcha()
        {
            amazonCaptchaSecPage.IByPassCaptcha();
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchTerm)
        {
            amazonHomePage.SearchForItem(searchTerm);
            Thread.Sleep(5000);
        }

        [When(@"I add the corresponding item to the cart")]
        public void WhenIAddTheCorrespondingItemToTheCart()
        {
            amazonSearchResultsPage.addItemToTheCart();
        }

        [Then(@"I navigate to the cart")]
        public void INavigateToTheCart()
        {
            Thread.Sleep(5000);
            amazonCartPage.NavigateToCart();
        }

        [Then(@"I validate the correct item and amount is displayed")]
        public void ThenIValidateTheCorrectItemAndAmountIsDisplayed()
        {
            Assert.IsTrue(amazonCartPage.IsCorrectItemAndAmountDisplayed());
            Thread.Sleep(5000);
            driver.Quit();
        }
        
    }
}
