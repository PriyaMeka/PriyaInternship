using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
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
        private static IWebElement LanguageTab => Driver.driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[1]"));
        private static IWebElement AddLanguageButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement AddLanguageTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement LanguageLevelDropdown => Driver.driver.FindElement(By.XPath(".//*[@name='level']"));
        private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        private static IWebElement ActualLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[1]"));
        private static IWebElement ActualLanguageLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[2]"));
        private static IWebElement EditLanguageButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]"));
        private static IWebElement EditLanguageTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
        private static IWebElement EditLanguageLevelDropdown => Driver.driver.FindElement(By.XPath(".//*[@name='level']"));
        private static IWebElement UpdateLanguageButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
        private static IWebElement EditedLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
        private static IWebElement EditedLanguageLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
        private static IWebElement DeleteLanguageButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]"));
        private static IWebElement DeletedLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
        private static IWebElement DeletedLanguageLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[2]"));

        internal void AddLanguage(IWebDriver driver, string Language, string LanguageLevel)
        {
          LanguageTab.Click();
          Wait.ElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 2);
          AddLanguageButton.Click();
          AddLanguageTextBox.SendKeys(Language);
          SelectElement element = new SelectElement(LanguageLevelDropdown);
          element.SelectByValue(LanguageLevel);
          AddButton.Click();
          

        }
        public string GetLanguage(IWebDriver driver)
        {
            return ActualLanguage.Text;
        }
        public string GetLanguageLevel(IWebDriver driver)
        {
            return ActualLanguageLevel.Text;
        }
        internal void EditLanguage(IWebDriver driver, string Language1, string LanguageLevel1)
        {
            LanguageTab.Click();
            IWebElement FindCreatedLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr"));
            EditLanguageButton.Click();
            EditLanguageTextBox.Clear();
            EditLanguageTextBox.SendKeys(Language1);
            SelectElement element = new SelectElement(EditLanguageLevelDropdown);
            element.SelectByValue(LanguageLevel1);
            UpdateLanguageButton.Click();

        }
        public string GeteditedLanguage(IWebDriver driver)
        {
            return EditedLanguage.Text;
        }
        public string GeteditedLanguageLevel(IWebDriver driver)
        {
            return EditedLanguageLevel.Text;
        }
        internal void DeleteLanguage(IWebDriver driver)
        {
            LanguageTab.Click();
            IWebElement FindEditedLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            DeleteLanguageButton.Click();
        }
        public string GetDeletedLanguage(IWebDriver driver)
        {
            return DeletedLanguage.Text;
        }
        public string GetDeletedLanguageLevel(IWebDriver driver)
        {
            return DeletedLanguageLevel.Text;
        }

    }
}
