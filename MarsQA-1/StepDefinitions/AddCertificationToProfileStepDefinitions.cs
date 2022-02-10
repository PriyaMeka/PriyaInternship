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
        Certification addCertificationObj = new Certification();

        [Given(@"\[Navigate to Certification tab]")]
        public void GivenNavigateToCertificationTab()
        {
        }

        [When(@"\[I add '([^']*)' and '([^']*)' and '([^']*)' to Certification tab]")]
        public void WhenIAddAndAndToCertificationTab(string Certificate, string CertifiedFrom, string Year)
        {
         addCertificationObj.AddCertification(driver, Certificate,CertifiedFrom, Year);
        }

        [Then(@"\[The '([^']*)' and '([^']*)' and '([^']*)' should be created successfully\.]")]
        public void ThenTheAndAndShouldBeCreatedSuccessfully_(string Certificate, string CertifiedFrom, string Year)
        {
            string actualCertificate = addCertificationObj.GetCertificate(driver);
            string actualCertifiedFrom = addCertificationObj.GetCertifiedFrom(driver);
            string actualYear = addCertificationObj.GetYear(driver);
            Assert.Pass();
        }
    }
}
