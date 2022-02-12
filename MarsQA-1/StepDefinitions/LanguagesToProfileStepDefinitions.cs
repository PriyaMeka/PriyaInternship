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
        Language addLanguageObj = new Language();

        [Given(@"\[Navigate to Language tab]")]
        public void GivenNavigateToLanguageTab()
        {
        }
        [When(@"\[I add '([^']*)' and '([^']*)' to Languages tab]")]
        public void WhenIAddAndToLanguagesTab(string Language, string LanguageLevel)
        {
            addLanguageObj.AddLanguage(driver, Language, LanguageLevel);
        }    
        [Then(@"\[The '([^']*)' and '([^']*)' should be created successfully\.]")]
        public void ThenTheAndShouldBeCreatedSuccessfully_(string Language, string LanguageLevel)
        {
            string ActualLanguage = addLanguageObj.GetLanguage(driver);
            string ActualLanguageLevel = addLanguageObj.GetLanguageLevel(driver);
            Assert.That(ActualLanguage != Language, "Actual Language and Expected Language do not match");
            Assert.That(ActualLanguageLevel != LanguageLevel, "Actual LanguageLevel and Expected  LanguageLevel do not match");
        }
        [Given(@"\[Navigate to the Languages tab]")]
        public void GivenNavigateToTheLanguagesTab()
        {

        }

        [When(@"\[I update '([^']*)' and '([^']*)' in Languages tab]")]
        public void WhenIUpdateAndInLanguagesTab(string Language1, string LanguageLevel1)
        {
            addLanguageObj.EditLanguage(driver, Language1, LanguageLevel1);

        }

        [Then(@"\[The '([^']*)' and '([^']*)' should be updated successfully\.]")]
        public void ThenTheAndShouldBeUpdatedSuccessfully_(string Language1, string LanguageLevel1)
        {
            string EditedLanguage = addLanguageObj.GeteditedLanguage(driver);
            string EditedLanguageLevel = addLanguageObj.GeteditedLanguageLevel(driver);
            Assert.That(EditedLanguage != Language1, "Edited Language and Expected Language not match");
            Assert.That(EditedLanguageLevel == LanguageLevel1, "Edited LanguageLevel and Expected LanguageLevel match");
        }

        [Given(@"\[Navigate to the Languages tab\.]")]
        public void GivenNavigateToTheLanguagesTab_()
        {

        }

        [When(@"\[I delete a Language in Languages tab]")]
        public void WhenIDeleteALanguageInLanguagesTab()
        {
            addLanguageObj.DeleteLanguage(driver);

        }

        [Then(@"\[The language should be deleted successfully]")]
        public void ThenTheLanguageShouldBeDeletedSuccessfully()
        {
            string DeletedLanguage = addLanguageObj.GetDeletedLanguage(driver);
            string DeletedLanguageLevel = addLanguageObj.GetDeletedLanguageLevel(driver);
            Assert.That(DeletedLanguage == "Sanskrit", "Language Deleted");
            Assert.That(DeletedLanguageLevel == "Native/Bilingual", "LanguageLevel deleted");
        }

    }
}
