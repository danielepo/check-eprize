using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;

namespace UgrCloser.PageObjects
{
    class Clicker
    {
        private readonly IWebDriver _driver;
        string _homeHandle;
        private int _retries = 0;
        public Clicker(IWebDriver driver)
        {
            _driver = driver;
            _retries = 0;
        }

        public Clicker Go()
        {
            _driver.Navigate().GoToUrl("https://www.eprice.it/black-hour");

            return this;
        }

        private void UseTopPanel()
        {
            var topRight = _driver.FindElements(By.TagName("frame")).First(x => x.GetAttribute("name") == "TopRight");
            _driver.SwitchTo().Frame(topRight);
        }
        public Clicker Search()
        {
            UseTopPanel();
            var query = _driver.FindElement(By.CssSelector(".item:first-child .btn"));
            //var query = _driver.FindElement(By.CssSelector(".item.superSconto:first-child .btn"));
            query.Click();
            return this;
        }
        
    }
}