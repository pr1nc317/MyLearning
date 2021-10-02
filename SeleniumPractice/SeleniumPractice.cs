using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumPractice
{
    class SeleniumPractice
    {
        [FindsBy(How = How.XPath, Using = "abc")]
        public IWebElement ele { get; set; }
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://toolsqa.com/automation-practice-form/";
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 30);
            ///PRACTICE 1
            //Console.WriteLine("Title: " + driver.Title + "\tTitle Length: " + driver.Title.Length);
            //Console.WriteLine("Page Url: " + driver.Url + "\tPage Url Length:" + driver.Url.Length);
            //Console.WriteLine("Page Source: " + driver.PageSource + "\tPage Source Length:" + driver.PageSource.Length);
            //Console.ReadLine();

            ///PRACTICE 2
            //driver.FindElement(By.Name("firstname")).SendKeys("Alpha");
            //driver.FindElement(By.Id("lastname")).SendKeys("Bravo");
            //driver.FindElement(By.Id("buttonwithclass")).Click();

            ///PRACTICE 3
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
            wait.IgnoreExceptionTypes(typeof(ElementClickInterceptedException));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[@title='Automation Practice Form']")));
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//a[@title='Automation Practice Form']")).Click();
            IList<IWebElement> buttonList = driver.FindElements(By.TagName("button"));
            foreach (IWebElement element in buttonList)
            {
                if (element.GetAttribute("innerText").Length > 4)
                {
                    Console.WriteLine(element.GetAttribute("innerText"));
                }
            }
            Console.ReadLine();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[@title='Automation Practice Table']")));
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//a[@title='Automation Practice Table']")).Click();
            Console.ReadLine();

            ///PRACTICE 4
            //IWebElement element = driver.FindElement(By.Id("sex-1"));
            //Actions action = new Actions(driver);
            //if (!element.Selected)
            //{
            //    action.MoveToElement(element).Click().Perform();
            //}
            //driver.FindElement(By.Id("exp-2")).Click();
            //IList<IWebElement> list = driver.FindElements(By.Name("profession"));
            //foreach (var item in list){
            //    if (item.GetAttribute("value")=="Automation Tester")
            //    {
            //        item.Click();
            //    }
            //}
            //driver.FindElement(By.CssSelector("input[value='Selenium IDE']")).Click();

            // DROPDOWN
            //SelectElement sel = new SelectElement(driver.FindElement(By.Id("")));
            //sel.SelectByValue("");

            // SCREENSHOT
            //Screenshot file = ((ITakesScreenshot)driver).GetScreenshot();
            //file.SaveAsFile("", ScreenshotImageFormat.Bmp);

            Func<int, double> func = num => num * 5;

            var _ = 5;

            driver.Quit();
        }
    }
}
