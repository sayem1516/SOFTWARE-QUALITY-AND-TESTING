using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("test case started ");
            //create the reference for the browser  
            IWebDriver driver = new ChromeDriver();
            // navigate to URL  
            driver.Navigate().GoToUrl("http://127.0.0.1:8000/login");
            Thread.Sleep(2000);
            // identify the email box  
            IWebElement ele = driver.FindElement(By.Name("email"));
            //enter the value in email box  
            ele.SendKeys("jayedchowdhury1234@gmail.com");
            Thread.Sleep(2000);
            // identify the password box  
            IWebElement ele2 = driver.FindElement(By.Name("password"));
            //enter the password in box  
            ele2.SendKeys("123");
            Thread.Sleep(2000);
            //identify the log in button  
            IWebElement ele1 = driver.FindElement(By.Name("login"));
            //click on the  log in button  
            ele1.Click();
            Thread.Sleep(3000);
            //close the browser  
            driver.Close();
            Console.Write("test case ended ");
        }
    }
}