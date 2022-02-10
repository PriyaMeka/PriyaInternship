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
    class AddSkill
    {
        public void AddSkills(IWebDriver driver, string Skill, string SkillLevel)
        {
            IWebElement gotoSkillTab = driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[2]"));
            gotoSkillTab.Click();
            // click on Add New button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            Thread.Sleep(2000);
            IWebElement addSkillTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addSkillTextBox.SendKeys(Skill);
            IWebElement skillLevelDropdown = driver.FindElement(By.XPath(".//*[@name='level']"));
            SelectElement element = new SelectElement(skillLevelDropdown);
            element.SelectByValue(SkillLevel);//Select By Text
            Thread.Sleep(2000);
            IWebElement addSkillButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addSkillButton.Click();
            Thread.Sleep(3000);
        }
        public string GetSkill(IWebDriver driver)
        {
            IWebElement actualSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[1]"));
            return actualSkill.Text;
        }
        public string GetSkillLevel(IWebDriver driver)
        {
            IWebElement actualSkillLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[2]"));
            return actualSkillLevel.Text;
        }
    }
}
