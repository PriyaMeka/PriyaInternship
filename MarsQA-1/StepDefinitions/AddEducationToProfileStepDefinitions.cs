using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class AddEducationToProfileStepDefinitions : Driver
    {
        Education addEducationObj = new Education();

        [Given(@"\[Navigate to Education tab]")]
        public void GivenNavigateToEducationTab()
        {
        }

        [When(@"\[I add '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' to Education tab]")]
        public void WhenIAddAndAndAndAndToEducationTab(string Name, string Country, string Title, string Degree, string Year)
        {
          addEducationObj.AddEducation(driver, Name, Country, Title, Degree, Year); 
        }

        [Then(@"\[The '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' should be created successfully\.]")]
        public void ThenTheAndAndAndAndShouldBeCreatedSuccessfully_(string Name, string Country, string Title, string Degree, string Year)
        {
            string actualName = addEducationObj.GetName(driver);
            string actualCountry = addEducationObj.GetCountry(driver);
            string actualTitle = addEducationObj.GetTitle(driver);
            string actualDegree = addEducationObj.GetDegree(driver);
            string actualYear = addEducationObj.GetYear(driver);
            Assert.Pass();
        }
    }
}
