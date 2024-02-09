using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Amazon.Pages
{
    public class AmazonCartPage
    {
        private readonly IWebDriver driver;
        private readonly By cartButton = By.XPath("//span[@id='aod-offer-view-cart-1']//input[@type='submit']");
        private readonly By itemTitle = By.XPath("//span[@class='a-truncate-cut']");
        private readonly By itemPrice = By.CssSelector(".a-size-medium.a-color-base.sc-price.sc-white-space-nowrap.sc-product-price.a-text-bold");

        public AmazonCartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToCart()
        {
            Thread.Sleep(5000);
            driver.FindElement(cartButton).Click();
            
        }

        public bool IsCorrectItemAndAmountDisplayed()
        {
            string expectedItemTitle = "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)";
            string expectedItemPrice = "$75.19";

            string actualTitle = driver.FindElement(itemTitle).Text;
            string actualPrice = driver.FindElement(itemPrice).Text;

            return actualTitle.Contains(expectedItemTitle) && actualPrice.Contains(expectedItemPrice);
        }
    }
}
