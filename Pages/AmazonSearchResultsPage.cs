using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Amazon.Pages
{
    public class AmazonSearchResultsPage
    {
        private readonly IWebDriver driver;
        private readonly By selectTpLinkN450 = By.CssSelector("img[alt='TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)']");
        private readonly By allBuyingOption = By.XPath("//a[@title='See All Buying Options']");
        private readonly By addToCart = By.XPath("//input[@data-csa-c-content-id='aod-atc-non-pinned-desktop']");

        public AmazonSearchResultsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void addItemToTheCart()
        {
            driver.FindElement(selectTpLinkN450).Click();
            Thread.Sleep(2000);
            driver.FindElement(allBuyingOption).Click();
            Thread.Sleep(2000);
            driver.FindElement(addToCart).Click();
        }
    }
}
