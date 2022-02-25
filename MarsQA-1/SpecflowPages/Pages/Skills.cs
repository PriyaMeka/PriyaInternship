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
    class Skills
    {
        private static IWebElement SkillTab => Driver.driver.FindElement(By.XPath("//div/a[text()='Skills']"));
        private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement AddSkillTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement SkillLevelDropdown => Driver.driver.FindElement(By.XPath(".//*[@name='level']"));
        private static IWebElement AddSkillButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private static IWebElement EditSkillTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private static IWebElement UpdateSkillButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        private static IWebElement DeletedRecord => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr"));

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
        public void VerifySkillAdded(string Skills)
        {
            bool SkillFound = false;
            IWebElement tableElement = Driver.driver.FindElement(By.XPath("(//table[@class='ui fixed table'])[2]"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            foreach (IWebElement row in tableRow)
            {
                if (row.Text.Contains(Skills))
                {
                    SkillFound = true;
                    Console.WriteLine("Skill Added") ;
                    break;
                }
            }
        }
        public void EditSkillButton(string Skill)
        {
            SkillTab.Click();
            IWebElement EditButton = Driver.driver.FindElement(By.XPath("//td[text()='" + Skill + "']/following::td[2]/descendant::i[@class='outline write icon']"));
            EditButton.Click();
        }
        public void EditSkills(IWebDriver driver, string Skill1, string SkillLevel1)
        {
            SkillTab.Click();
            Wait.ElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 2);
            EditSkillTextBox.Clear();
            EditSkillTextBox.SendKeys(Skill1);
            SelectElement element = new SelectElement(SkillLevelDropdown);
            element.SelectByValue(SkillLevel1);
            UpdateSkillButton.Click();
        }
        public void VerifySkillUpdated(string Skill1, string SkillLevel1)

        {
            SkillTab.Click();
            IList<IWebElement> LangTableRow = Driver.driver.FindElements(By.XPath("(//table[@class='ui fixed table'])[2]/tbody/tr"));
            var rownum = LangTableRow.Count;
            for (var i = 1; i <= rownum; i++)
            {
                if ((Skill1 == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[2]/tbody/tr[1]/td[1])[" + i + "]")).Text) &&
                    (SkillLevel1 == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[2]/tbody/tr[1]/td[2])[" + i + "]")).Text))
                    Console.WriteLine("Skill level updated");
                break;
            }
        }
        internal void DeleteSkill(string Skill1)
        {
            SkillTab.Click();
            IWebElement DeleteSkillButton = Driver.driver.FindElement(By.XPath("//td[text()='" + Skill1 + "']/following::td[2]/descendant::i[@class='remove icon']"));
            DeleteSkillButton.Click();
        }
        public string VerifyDeletedSkill(IWebDriver driver)
        {
            string deletedrecordtext = DeletedRecord.Text;
            return deletedrecordtext;
        }
    }
}
