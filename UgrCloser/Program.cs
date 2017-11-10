using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UgrCloser.PageObjects;

namespace UgrCloser
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new Proxy
            {
                HttpProxy = "http://eul0856:Dony2211!@proxyfull.servizi.ras:80",
                SslProxy = "http://eul0856:Dony2211!@proxyfull.servizi.ras:80"
            };

            var options = new ChromeOptions
            {
                Proxy = proxy
            };
            using (IWebDriver driver = new ChromeDriver(options))
            {

                //Notice navigation is slightly different than the Java version
                //This is because 'get' is a keyword in C#
                var ugrMain = new Clicker(driver);

                while (true)
                {
                    ugrMain.Go().Search();
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        private static void closeFor(IWebDriver driver, string app)
        {

        }
    }
}
