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
    class Skills
    {
        private static IWebElement SkillTab => Driver.driver.FindElement(By.XPath("//div/a[text()='Skills']"));
        private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement AddSkillTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement SkillLevelDropdown => Driver.driver.FindElement(By.XPath(".//*[@name='level']"));
        private static IWebElement AddSkillButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private static IWebElement ActualSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[1]"));
        private static IWebElement ActualSkillLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[2]"));
        private static IWebElement EditSkillButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]"));
        private static IWebElement EditSkillTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td/div/div[1]/input"));
        private static IWebElement EditSkillLevelDropdown => Driver.driver.FindElement(By.XPath(".//*[@name='level']"));
        private static IWebElement UpdateSkillButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td/div/span/input[1]"));
        private static IWebElement EditedSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
        private static IWebElement EditedSkillLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[2]"));
        private static IWebElement DeleteSkillButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[2]/i"));
        private static IWebElement DeletedSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
        private static IWebElement DeletedSkillLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[2]"));

        internal void AddSkills(IWebDriver driver,string Skill, string SkillLevel)
        {
            SkillTab.Click();
            Wait.ElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 2);
            AddButton.Click();
            AddSkillTextBox.SendKeys(Skill);
            SelectElement element = new SelectElement(SkillLevelDropdown);
            element.SelectByValue(SkillLevel);
            AddSkillButton.Click();
        }
        public string GetSkill(IWebDriver driver)
        {
           return ActualSkill.Text;
        }
        public string GetSkillLevel(IWebDriver driver)
        {
           return ActualSkillLevel.Text;
        }
        internal void EditSkills(IWebDriver driver, string Skill1,string SkillLevel1)
        {
            SkillTab.Click();
            Wait.ElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 2);
            IWebElement FindCreatedSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
            EditSkillButton.Click();
            EditSkillTextBox.Clear();
            EditSkillTextBox.SendKeys(Skill1);
            SelectElement element = new SelectElement(EditSkillLevelDropdown);
            element.SelectByValue(SkillLevel1);
            UpdateSkillButton.Click();
        }
       public string GeteditedSkill(IWebDriver driver)
       {
            return EditedSkill.Text;
       }
        public string GeteditedSkillLevel(IWebDriver driver)
        {
            return EditedSkillLevel.Text;
        }
        internal void DeleteSkill(IWebDriver driver)
        {
            SkillTab.Click();
            Wait.ElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]", 2);
            IWebElement FindEditedSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
            DeleteSkillButton.Click();
        }
        public string GetDeletedSkill(IWebDriver driver)
        {
            return DeletedSkill.Text;
        }
        public string GetDeletedSkillLevel(IWebDriver driver)
        {
            return DeletedSkillLevel.Text;
        }
    }
}
