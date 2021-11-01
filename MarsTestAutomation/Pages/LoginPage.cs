using OpenQA.Selenium;
using System;


namespace MarsTestAutomation.Pages
{
    public class LoginPage
    {
        public void LoginAction(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://64a7-2a02-8084-2164-3d00-61ef-548a-9274-820c.ngrok.io/");
            driver.Manage().Window.Maximize();

            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signInButton.Click();
            
            // indetify the username textbox enter valid username
            IWebElement emailAddressTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailAddressTextbox.SendKeys("nandini49@outlook.com");

            // identify password textbox enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("test@123");

            // identify login button and click
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
        }
    }
}