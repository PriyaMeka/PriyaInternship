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

        [Given(@"\[Navigate to Skills tab]")]
        public void GivenNavigateToSkillsTab()
        {
        }

        [When(@"\[I add '([^']*)' and '([^']*)' to Skills tab]")]
        public void WhenIAddAndToSkillsTab(string Skill, string SkillLevel)
        {
            Skills addSkillObj = new Skills();
            addSkillObj.AddSkills(driver, Skill, SkillLevel);

        }

        [Then(@"\[The Skill Record should be created successfully]")]
        public void ThenTheSkillRecordShouldBeCreatedSuccessfully()
        {
            Assert.Pass();
        }

        [Given(@": I am on my Profile Page\.")]
        public void GivenIAmOnMyProfilePage_()
        {
            HomePage homePage = new HomePage();
            homePage.GoToProfile(driver);
        }

        [Then(@": '([^']*)' Records must have been created successfully in Skills tab\.")]
        public void ThenRecordsMustHaveBeenCreatedSuccessfullyInSkillsTab_(int p0)
        {
            Skills addSkillObj = new Skills();
            int actualcount = addSkillObj.ReadSkillrecord(driver);
            Assert.AreEqual(actualcount, p0);
        }


        [Given(@"\[Click on Edit Button near '([^']*)'\.]")]
        public void GivenClickOnEditButtonNear_(string Skill)
        {
            Skills addSkillObj = new Skills();
            addSkillObj.EditSkillButton(Skill);

        }

        [When(@"\[I update '([^']*)' and '([^']*)' to Skills tab]")]
        public void WhenIUpdateAndToSkillsTab(string Skill, string SkillLevel)
        {
            Skills addSkillObj = new Skills();
            addSkillObj.EditSkills(driver,Skill,SkillLevel);

        }

        [Then(@"\[The '([^']*)' and '([^']*)' should be updated successfully]")]
        public void ThenTheAndShouldBeUpdatedSuccessfully(string Skill1, string SkillLevel1)
        {
            Console.WriteLine("Skill Record updated");
        }
        [Then(@"Then the record is updated with new details '([^']*)' and '([^']*)'\.")]
        public void ThenThenTheRecordIsUpdatedWithNewDetailsAnd_(string Skill1, string SkillLevel1)
        {
            Skills addSkillObj = new Skills();
            string EditedSkill = addSkillObj.GetEditedSkill(driver);
            Assert.AreNotEqual(EditedSkill, Skill1);
            string EditedSkillLevel = addSkillObj.GetEditedSkillLevel(driver);
            Assert.AreNotEqual(EditedSkillLevel, SkillLevel1);
        }

        [Given(@"\[Navigate to the Skills tab\.]")]
        public void GivenNavigateToTheSkillsTab_()
        {
            
        }

        [When(@"\[I delete '([^']*)' in Skills tab]")]
        public void WhenIDeleteInSkillsTab(string Skill1)
        {
            Skills addSkillObj = new Skills();
            addSkillObj.DeleteSkill(Skill1);

        }

        [Then(@"\[The '([^']*)' should be deleted successfully\.]")]
        public void ThenTheShouldBeDeletedSuccessfully_(string Skill1)
        {
            Skills addSkillObj = new Skills();
            string record = addSkillObj.VerifyDeletedSkill(driver);
            Assert.That(record != Skill1, "Skill Record not deleted");
        }


    }

}
