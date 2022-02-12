using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class SkillsToProfileStepDefinitions : Driver
    {
        Skills addSkillObj = new Skills();

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
            string ActualSkill= addSkillObj.GetSkill(driver);
            string ActualSkillLevel = addSkillObj.GetSkillLevel(driver);
            Assert.That(ActualSkill != Skill, "Actual Skill and Expected Skill do not match");
            Assert.That(ActualSkillLevel != SkillLevel, "Actual SkillLevel and Expected SkillLevel do not match");
        }
        [Given(@"\[Navigate to the Skills tab]")]
        public void GivenNavigateToTheSkillsTab()
        {
        }
        [When(@"\[I update '([^']*)' and '([^']*)' to Skills tab]")]
        public void WhenIUpdateAndToSkillsTab(string Skill, string SkillLevel)
        {
            addSkillObj.EditSkills(driver,Skill,SkillLevel);

        }

        [Then(@"\[The '([^']*)' and '([^']*)' should be updated successfully]")]
        public void ThenTheAndShouldBeUpdatedSuccessfully(string Skill1, string SkillLevel1)
        {
            string EditedSkill = addSkillObj.GeteditedSkill(driver);
            string EditedSkillLevel = addSkillObj.GeteditedSkillLevel(driver);
            Assert.That(EditedSkill != Skill1, "Actual Skill and Expected Skill not match");
            Assert.That(EditedSkillLevel != SkillLevel1, "Actual SkillLevel and Expected SkillLevel not match ");
          
          
        }
        [Given(@"\[Navigate to the Skills tab\.]")]
        public void GivenNavigateToTheSkillsTab_()
        {
            
        }

        [When(@"\[I delete a skill in Skills tab]")]
        public void WhenIDeleteASkillInSkillsTab()
        {
            addSkillObj.DeleteSkill(driver);

        }

        [Then(@"\[The skill should be deleted successfully]")]
        public void ThenTheSkillShouldBeDeletedSuccessfully()
        {
            string DeletedSkill = addSkillObj.GetDeletedSkill(driver);
            string DeletedSkillLevel = addSkillObj.GetDeletedSkillLevel(driver);
            Assert.That(DeletedSkill == "SpecFlow", "Skill deleted");
            Assert.That(DeletedSkillLevel == "Intermediate", "SkillLevel deleted");
        }


    }

}
