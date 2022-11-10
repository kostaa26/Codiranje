using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPrviTest
{
    public class Program

    {
        IWebDriver drive = new ChromeDriver();
        static void Main(string[] args)
        {
            

        }
        [SetUp]
        public void Inicijalizacija()
        {
            drive.Navigate().GoToUrl("https://www.saucedemo.com/");
            drive.Manage().Window.Maximize();
        }
        [Test]
        public void Test1()
        {
            IWebElement userName = drive.FindElement(By.Id("user-name"));
            userName.SendKeys("standard_user");

            IWebElement password = drive.FindElement(By.Id("password"));
            password.SendKeys("secret_sauce");

            IWebElement LoginButton = drive.FindElement(By.Id("login-button"));
            LoginButton.Submit();
        }

        [TearDown]
        public void Close()
        {
            drive.Close();
        }
    }
}
