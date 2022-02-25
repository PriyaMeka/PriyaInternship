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
        [Then(@"\[The '([^']*)' Record should be added successfully]")]
        public void ThenTheRecordShouldBeAddedSuccessfully(string Skill)
        {
            addSkillObj.VerifySkillAdded(Skill);  
        }
        [Given(@"\[Click on Edit Button near '([^']*)'\.]")]
        public void GivenClickOnEditButtonNear_(string Skill)
        {
            addSkillObj.EditSkillButton(Skill);

        }

        [When(@"\[I update '([^']*)' and '([^']*)' to Skills tab]")]
        public void WhenIUpdateAndToSkillsTab(string Skill, string SkillLevel)
        {
            addSkillObj.EditSkills(driver,Skill,SkillLevel);

        }

        [Then(@"\[The '([^']*)' and '([^']*)' should be updated successfully]")]
        public void ThenTheAndShouldBeUpdatedSuccessfully(string Skill1, string SkillLevel1)
        {
            addSkillObj.VerifySkillUpdated(Skill1, SkillLevel1);
        }
        [Given(@"\[Navigate to the Skills tab\.]")]
        public void GivenNavigateToTheSkillsTab_()
        {
            
        }

        [When(@"\[I delete '([^']*)' in Skills tab]")]
        public void WhenIDeleteInSkillsTab(string Skill1)
        {
            addSkillObj.DeleteSkill(Skill1);

        }

        [Then(@"\[The '([^']*)' should be deleted successfully\.]")]
        public void ThenTheShouldBeDeletedSuccessfully_(string Skill1)
        {
            string record = addSkillObj.VerifyDeletedSkill(driver);
            Assert.That(record != Skill1, "Skill Record not deleted");
        }


    }

}
