using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;



namespace UnitTestProject1
{
    public class CommonFunction
    {
        public static IWebDriver WebDriver;
        public const string Url = "http://192.168.190.215:54000/TADashboard/2f9njff6y9.page";

        public static void Openbrowser1(string browser)

        {

            switch (browser.ToUpper())
            {

                case "CHROME":
                    WebDriver = new ChromeDriver();
                    WebDriver.Manage().Window.Maximize();
                    break;
                case "IE":
                    WebDriver = new InternetExplorerDriver();
                    WebDriver.Manage().Window.Maximize();
                    break;
                case "FIREFOX":
                    WebDriver = new FirefoxDriver();
                    WebDriver.Manage().Window.Maximize();
                    break;
                default:
                    Console.WriteLine(String.Format("Browser '{0}' not recognized. Spawning default Firefox browser.", browser));
                    WebDriver = new FirefoxDriver();
                    WebDriver.Manage().Window.Maximize();
                    break;

            }

        }
    }
}
