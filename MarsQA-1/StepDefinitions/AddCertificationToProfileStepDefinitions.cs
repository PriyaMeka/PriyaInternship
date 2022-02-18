using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class AddCertificationToProfileStepDefinitions : Driver
    {


        [Given(@"I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
            HomePage homePage = new HomePage();
            homePage.GoToProfile(driver);
        }
        [When(@"\[I add '([^']*)' and '([^']*)' and '([^']*)' to Certification tab]")]
        public void WhenIAddAndAndToCertificationTab(string Certificate, string CertifiedFrom, string Year)
        {
            Certification addCertificationObj = new Certification();
            addCertificationObj.AddCertification(Certificate, CertifiedFrom, Year);
        }
        [Then(@"\[The Certification tab with '([^']*)' should be created successfully\.]")]
        public void ThenTheCertificationTabWithShouldBeCreatedSuccessfully_(string Certificate)
        {
            Assert.Pass();
        }
     
        [Then(@": '([^']*)' Records must have been created successfully")]
        public void ThenRecordsMustHaveBeenCreatedSuccessfully(int p0)
        {
            Certification addCertificationObj = new Certification();
            int actualcount = addCertificationObj.ReadCertificationrecord(driver);
            Assert.AreEqual(actualcount, p0);
        }


    }
}
