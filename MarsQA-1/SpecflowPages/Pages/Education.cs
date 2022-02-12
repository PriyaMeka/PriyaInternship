using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Education
    {
        private static IWebElement EducationTab => Driver.driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[3]"));
        private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        private static IWebElement CountryDropDown => Driver.driver.FindElement(By.XPath(".//*[@name='country']"));
        private static IWebElement AddNameTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        private static IWebElement TitleDropDown => Driver.driver.FindElement(By.XPath(".//*[@name='title']"));
        private static IWebElement AddDegreeTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        private static IWebElement YearDropDown => Driver.driver.FindElement(By.XPath(".//*[@name='yearOfGraduation']"));
        private static IWebElement AddEducationButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        private static IWebElement ActualCountry => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement ActualUniversity => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
        private static IWebElement ActualTitle => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
        private static IWebElement ActualDegree => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
        private static IWebElement ActualYear => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));

        internal void AddEducation(IWebDriver driver, string Country, string University, string Title, string Degree, string Year)
        {
            EducationTab.Click();
            AddButton.Click();
            SelectElement element = new SelectElement(CountryDropDown);
            element.SelectByValue(Country);
            AddNameTextBox.SendKeys(University);
            SelectElement element1 = new SelectElement(TitleDropDown);
            element1.SelectByValue(Title);
            AddDegreeTextBox.SendKeys(Degree);
            SelectElement element2 = new SelectElement(YearDropDown);
            element2.SelectByValue(Year);
            AddEducationButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }
        public string GetCountry(IWebDriver driver)
        {
            return ActualCountry.Text;
        }
        public string GetUniversity(IWebDriver driver)
        {
            return ActualUniversity.Text;
        }
        public string GetTitle(IWebDriver driver)
        {
            return ActualTitle.Text;
        }
        public string GetDegree(IWebDriver driver)
        {
            return ActualDegree.Text;
        }
        public string GetYear(IWebDriver driver)
        {
            return ActualYear.Text;
        }
    }
}
