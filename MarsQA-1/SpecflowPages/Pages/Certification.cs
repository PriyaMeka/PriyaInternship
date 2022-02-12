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
    class Certification
    {
        private static IWebElement CertificationTab => Driver.driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[4]"));
        private static IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private static IWebElement AddCertificateTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
        private static IWebElement AddCertifiedFromTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
        private static IWebElement YearDropDown => Driver.driver.FindElement(By.XPath(".//*[@name='certificationYear']"));
        private static IWebElement AddCertificationButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
        private static IWebElement ActualCertificate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[1]"));
        private static IWebElement ActualCertifiedFrom => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[2]"));
        private static IWebElement ActualYear => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[3]"));

        public void AddCertification(IWebDriver driver, string Certificate, string CertifiedFrom, string Year)
        {
            CertificationTab.Click();
            AddNewButton.Click();
            AddCertificateTextBox.SendKeys(Certificate);
            AddCertifiedFromTextBox.SendKeys(CertifiedFrom);
            SelectElement element3 = new SelectElement(YearDropDown);
            element3.SelectByValue(Year);
            AddCertificationButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        public string GetCertificate(IWebDriver driver)
        {
            return ActualCertificate.Text;
        }
        public string GetCertifiedFrom(IWebDriver driver)
        {
            return ActualCertifiedFrom.Text;
        }
        public string GetYear(IWebDriver driver)
        {
            return ActualYear.Text;
        }
    }
}
