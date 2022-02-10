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
     class Language
    {
        public void AddLanguage(IWebDriver driver, string Language, string LanguageLevel)
        {
          IWebElement gotoLanguageTab = driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[1]"));
          gotoLanguageTab.Click();
            // click on Add New button
          IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
          addNewButton.Click();
          Thread.Sleep(2000);
          IWebElement addLanguageTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
          addLanguageTextBox.SendKeys(Language);
          IWebElement languageLevelDropdown = driver.FindElement(By.XPath(".//*[@name='level']"));
          SelectElement element = new SelectElement(languageLevelDropdown);
          element.SelectByValue(LanguageLevel);//Select By Text
          Thread.Sleep(2000);
          IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
          addButton.Click();
          Thread.Sleep(3000);
        }
        public string GetLanguage(IWebDriver driver)
        {
            IWebElement actualLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualLanguage.Text;
        }
        public string GetLanguageLevel(IWebDriver driver)
        {
            IWebElement actualLanguageLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return actualLanguageLevel.Text;
        }
    }
}
