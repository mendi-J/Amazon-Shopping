using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Amazon.Pages
{
    public class CaptchaSecPage
    {
        private readonly IWebDriver driver;
        private readonly By reloadCaptcha = By.XPath("//a[@onclick='window.location.reload()']");
        public CaptchaSecPage(IWebDriver driver) {

            this.driver = driver;
        }

        public void IByPassCaptcha()
        {
            driver.FindElement(reloadCaptcha).Click();
        }

    }
}
