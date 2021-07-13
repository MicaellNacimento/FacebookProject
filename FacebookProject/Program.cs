using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using static Microsoft.Graph.CoreConstants.MimeTypeNames;

namespace FacebookProject
{
    class Program
    {
        static void Main()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://facebook.com/friends";

            driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            driver.FindElement(By.Id("email")).SendKeys("email");

            driver.FindElement(By.Id("pass")).SendKeys("senha" + Keys.Enter);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            IList<IWebElement> friends = driver.FindElements(By.XPath("//div[@class='tvmbv18p aahdfvyu']"));

            Console.WriteLine(friends.Count);

            for (int i = 0; i < friends.Count; i++) 

                if(i > 5)
                {

                    driver.Close();
                    Environment.Exit(1);
                }

                else
                {
                    Console.WriteLine(friends[i].Text);
                }

        }




    }

}


