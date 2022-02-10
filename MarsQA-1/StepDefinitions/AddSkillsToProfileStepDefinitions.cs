using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class AddSkillsToProfileStepDefinitions : Driver
    {
        AddSkill addSkillObj = new AddSkill();

        [Given(@"\[Navigate to Skills tab]")]
        public void GivenNavigateToSkillsTab()
        {
        }

        [When(@"\[I add '([^']*)' and '([^']*)' to Skills tab]")]
        public void WhenIAddAndToSkillsTab(string Skill, string SkillLevel)
        {
            addSkillObj.AddSkills(driver, Skill, SkillLevel);

        }

        [Then(@"\[The '([^']*)' and '([^']*)' should be created successfully]")]
        public void ThenTheAndShouldBeCreatedSuccessfully(string Skill, string SkillLevel)
        {
            string actualSkill= addSkillObj.GetSkill(driver);
            string actualSkillLevel = addSkillObj.GetSkillLevel(driver);
            Assert.Pass();
        }
    }
}
