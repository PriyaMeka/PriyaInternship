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
    public class AddLanguagesToProfileStepDefinitions : Driver
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
            string actualLanguage = addLanguageObj.GetLanguage(driver);
            string actualLanguageLevel = addLanguageObj.GetLanguageLevel(driver);
            Assert.Pass();

        }

    }
}
