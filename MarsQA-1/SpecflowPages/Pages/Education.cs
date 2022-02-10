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
        public void AddEducation(IWebDriver driver, string Name, string Country, string Title, string Degree, string Year)
        {
            IWebElement gotoEducationTab = driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[3]"));
            gotoEducationTab.Click();
            // click on Add New button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNewButton.Click();
            Thread.Sleep(2000);
            IWebElement addNameTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            addNameTextBox.SendKeys(Name);
            IWebElement countryDropdown = driver.FindElement(By.XPath(".//*[@name='country']"));
            SelectElement element = new SelectElement(countryDropdown);
            element.SelectByValue(Country);//Select By Text
            Thread.Sleep(2000);
            IWebElement titleDropdown = driver.FindElement(By.XPath(".//*[@name='title']"));
            SelectElement element1 = new SelectElement(titleDropdown);
            element1.SelectByValue(Title);//Select By Text
            Thread.Sleep(2000);
            IWebElement addDegreeTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            addDegreeTextBox.SendKeys(Degree);
            IWebElement yearDropdown = driver.FindElement(By.XPath(".//*[@name='yearOfGraduation']"));
            SelectElement element2 = new SelectElement(yearDropdown);
            element2.SelectByValue(Year);//Select By Text
            Thread.Sleep(2000);
            IWebElement addEducationButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addEducationButton.Click();
            Thread.Sleep(3000);
        }
        public string GetCountry(IWebDriver driver)
        {
            IWebElement actualCountry = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualCountry.Text;
        }
        public string GetName(IWebDriver driver)
        {
            IWebElement actualName = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return actualName.Text;
        }
        public string GetTitle(IWebDriver driver)
        {
            IWebElement actualTitle = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            return actualTitle.Text;
        }
        public string GetDegree(IWebDriver driver)
        {
            IWebElement actualDegree = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return actualDegree.Text;
        }
        public string GetYear(IWebDriver driver)
        {
            IWebElement actualYear = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            return actualYear.Text;
        }
    }
}
