using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
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
        private static IWebElement EditLanguageTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
        private static IWebElement EditedLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
        private static IWebElement EditedLanguageLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
        private static IWebElement UpdateLanguageButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
       private static IWebElement DeletedRecord => Driver. driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr"));

        public void AddLanguage(IWebDriver driver, string Language, string LanguageLevel)
        {
            LanguageTab.Click();
            Wait.ElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 2);
            AddLanguageButton.Click();
            AddLanguageTextBox.SendKeys(Language);
            SelectElement element = new SelectElement(LanguageLevelDropdown);
            element.SelectByValue(LanguageLevel);
            AddButton.Click();
        }

        public int ReadLanguagerecord(IWebDriver driver)
        {
            IList<IWebElement> actualLanguageRecord = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody"));
            foreach (IWebElement aPart in actualLanguageRecord)
            {
                
                Console.WriteLine(aPart.Text);

            }
            int count = actualLanguageRecord.Count;
            return count;

        }
        public void EditLanguageButton(string Language)
        {
            LanguageTab.Click();
            IWebElement EditButton = Driver.driver.FindElement(By.XPath("//td[text()='" + Language + "']/following::td[2]/descendant::i[@class='outline write icon']"));
            EditButton.Click();
        }
        internal void EditLanguage(string Language1, string LanguageLevel1)
        {
            EditLanguageTextBox.Clear();
            EditLanguageTextBox.SendKeys(Language1);
            SelectElement element = new SelectElement(LanguageLevelDropdown);
            element.SelectByValue(LanguageLevel1);
            UpdateLanguageButton.Click();

        }
        public string GeteditedLanguage(IWebDriver driver)
        {
            string EditedLanguagetext = EditedLanguage.Text;
            return EditedLanguagetext;
        }
        public string GeteditedLanguageLevel(IWebDriver driver)
        {
            string EditedLanguageLeveltext = EditedLanguageLevel.Text;
            return EditedLanguageLeveltext;
        }
        internal void DeleteLanguage(string Language1)
        {
            LanguageTab.Click();
            IWebElement DeleteLanguageButton = Driver.driver.FindElement(By.XPath("//td[text()='" + Language1 + "']/following::td[2]/descendant::i[@class='remove icon']"));
            DeleteLanguageButton.Click();
        }
        public string VerifyDeletedLanguage(IWebDriver driver)
        {
            string deletedrecordtext = DeletedRecord.Text;
            return deletedrecordtext;
        }


    }
}
