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
        [Given(@"I am on my Profile page")]
        public void GivenIAmOnMyProfilePage()
        {
            HomePage homePage = new HomePage();
            homePage.GoToProfile(driver);
        }


        [When(@"\[I add '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' to Education tab]")]
        public void WhenIAddAndAndAndAndToEducationTab(string Country, string University, string Title, string Degree, int Year)
        {
            Education addEducationObj = new Education();
            addEducationObj.AddEducation(Country, University, Title, Degree, Year); 
        }

        [Then(@"\[The Education Record with '([^']*)' should be created successfully]")]
        public void ThenTheEducationRecordWithShouldBeCreatedSuccessfully(string Degree)
        {
            Education addEducationObj = new Education();
            addEducationObj.VerifyEducationAdded(Degree);
        }
    }
}
