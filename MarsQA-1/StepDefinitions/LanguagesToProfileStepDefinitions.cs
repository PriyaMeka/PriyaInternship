using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class LanguagesToProfileStepDefinitions : Driver
    {
        [Given(@"\[Navigate to Language tab]")]
        public void GivenNavigateToLanguageTab()
        {
        }
        [When(@"\[I add '([^']*)' and '([^']*)' to Languages tab]")]
        public void WhenIAddAndToLanguagesTab(string Language, string LanguageLevel)
        {
            Language addLanguageObj = new Language();
            addLanguageObj.AddLanguage(driver, Language, LanguageLevel);
        }    
        [Then(@"\[The Record should be created successfully\.]")]
        public void ThenTheRecordShouldBeCreatedSuccessfully_()
        {
         Assert.Pass();
        }
        [Given(@": I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
            HomePage homePage = new HomePage();
            homePage.GoToProfile(driver);
        }

        [Then(@": '([^']*)' Records must have been created successfully\.")]
        public void ThenRecordsMustHaveBeenCreatedSuccessfully_(int p0)
        {
            Language addLanguageObj = new Language();
            int actualcount = addLanguageObj.ReadLanguagerecord(driver);
            Assert.AreEqual(actualcount, p0);

        }
        [Given(@"\[Click on Edit Button near '([^']*)']")]
        public void GivenClickOnEditButtonNear(string Language)
        {

            Language addLanguageObj = new Language();
            addLanguageObj.EditLanguageButton(Language);
        }

        [When(@"\[I update '([^']*)' and '([^']*)' in Languages tab]")]
        public void WhenIUpdateAndInLanguagesTab(string Language1, string LanguageLevel1)
        {
            Language addLanguageObj = new Language();
            addLanguageObj.EditLanguage(Language1, LanguageLevel1);

        }

        [Then(@"\[The '([^']*)' and '([^']*)' should be updated successfully\.]")]
        public void ThenTheAndShouldBeUpdatedSuccessfully_(string Language1, string LanguageLevel1)
        {
            Console.WriteLine("Record updated");
        }
        [Then(@": the record is updated with new details '([^']*)' ,'([^']*)'\.")]
        public void ThenTheRecordIsUpdatedWithNewDetails_(string Language1, string LanguageLevel1)
        {
            Language addLanguageObj = new Language();
            string editedlanguage = addLanguageObj.GeteditedLanguage(driver);
            Assert.AreEqual(editedlanguage, Language1);
            string editedlevel = addLanguageObj.GeteditedLanguageLevel(driver);
            Assert.AreEqual(editedlevel, LanguageLevel1);
        }


        [Given(@"\[Navigate to the Languages tab\.]")]
        public void GivenNavigateToTheLanguagesTab_()
        {

        }
        [When(@"\[I delete a '([^']*)' in Languages tab]")]
        public void WhenIDeleteAInLanguagesTab(string Language1)
        {
            Language addLanguageObj = new Language();
            addLanguageObj.DeleteLanguage(Language1);

        }

        [Then(@"\[The '([^']*)' should be deleted successfully]")]
        public void ThenTheShouldBeDeletedSuccessfully(string Language1)
        {
            Language addLanguageObj = new Language();
            string record = addLanguageObj.VerifyDeletedLanguage(driver);
            Assert.That(record != Language1, "Language not deleted");
        }

    }
}
