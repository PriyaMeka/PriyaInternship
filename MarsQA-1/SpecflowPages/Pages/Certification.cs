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
        public void AddCertification(IWebDriver driver, string Certificate, string CertifiedFrom, string Year)
        {
            IWebElement gotoCertificationTab = driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[4]"));
            gotoCertificationTab.Click();
            // click on Add New button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewButton.Click();
            Thread.Sleep(2000);
            IWebElement addCertificateTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            addCertificateTextBox.SendKeys(Certificate);
            IWebElement addCertifiedFromTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            addCertifiedFromTextBox.SendKeys(CertifiedFrom);
            IWebElement yearDropdown = driver.FindElement(By.XPath(".//*[@name='certificationYear']"));
            SelectElement element3 = new SelectElement(yearDropdown);
            element3.SelectByValue(Year);//Select By Text
            Thread.Sleep(2000);
            IWebElement addCertificationButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addCertificationButton.Click();
            Thread.Sleep(3000);
        }
        public string GetCertificate(IWebDriver driver)
        {
            IWebElement actualCertificate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[1]"));
            return actualCertificate.Text;
        }
        public string GetCertifiedFrom(IWebDriver driver)
        {
            IWebElement actualCertifiedFrom = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[2]"));
            return actualCertifiedFrom.Text;
        }
        public string GetYear(IWebDriver driver)
        {
            IWebElement actualYear = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[2]"));
            return actualYear.Text;
        }
    }
}
