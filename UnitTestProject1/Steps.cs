using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class Steps
    {

        static IWebDriver driver = new ChromeDriver();
        #region Feilds
        private static By appTitle = By.XPath(Resource1.AppTitle);
        private static By ftrJobBtn = By.XPath(Resource1.DrpDwnFilterJobType);
        private static By fltrJobCat = By.XPath(Resource1.FilterJobCategory);
        private static By jobName = By.XPath(Resource1.JobName);
        private static By jobPageDetails = By.XPath(Resource1.JobPageTitle);
        private static By jobInterest = By.XPath(Resource1.JobInterest);
        private static By drpDwnSalutation = By.XPath(Resource1.SalutationDrpdwn);
        private static By salutation = By.XPath(Resource1.Salutation);
        private static By firstName = By.XPath(Resource1.FirstName);
        private static By lastName = By.XPath(Resource1.LastName);
        private static By email = By.XPath(Resource1.Email);
        private static By mobile = By.XPath(Resource1.Mobile);
        private static By drpDwnState_Province = By.XPath(Resource1.State_ProvinceDrpDwn);
        private static By state_Province = By.XPath(Resource1.State_Province);
        private static By currentEmployer = By.XPath(Resource1.CurrentEmployer);
        private static By drpDwnCurrentJobTitle = By.XPath(Resource1.CurrentJobTitleDrpDwn);
        private static By currentJobTitle = By.XPath(Resource1.CurrentJobTitle);
        private static By drpDwnSkillSet = By.XPath(Resource1.SkillSetDrpDwn);
        private static By skillSet = By.XPath(Resource1.SkillSet);
        private static By currentCTC = By.XPath(Resource1.CurrentCTC);
        private static By expectedCTC = By.XPath(Resource1.ExpectedCTC);
        private static By reasonForChange = By.XPath(Resource1.ReasonForChange);
        private static By whyJoinNumadic = By.XPath(Resource1.WhyJoinNumadic);
        private static By linkedIn = By.XPath(Resource1.LinkedIn);
        private static By browse = By.XPath(Resource1.BrowseBtn);
        private static By submit = By.XPath(Resource1.SubmitBtn);
        private static By submitionError = By.XPath(Resource1.SubmitApplicationError);
        #endregion

        public void LaunchApp()
        {
            var url = "https://jobs.numadic.com/jobs/Careers";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
        }
        
        
        public void VerifyApplicationTitle()
        {
            IWebElement AppTitle = driver.FindElement(appTitle);
            if (AppTitle.Text == "JOIN OUR CREW")
            {
                Console.WriteLine("JOIN OUR CREW Text is verified");
            }
            else
            {
                Console.WriteLine("JOIN OUR CREW Text is not verified");
            }
            Thread.Sleep(1000);
        }

        public void FilterJobTypeToApply()
        {
            IWebElement FltrJobBtn = driver.FindElement(ftrJobBtn);       
            FltrJobBtn.Click();
            Thread.Sleep(1000);
            IWebElement FltrJobCat = driver.FindElement(fltrJobCat);
            FltrJobCat.Click();
            Console.WriteLine("Engineering is selected in the filter");
            IWebElement JobName = driver.FindElement(jobName);
            JobName.Click();
            Console.WriteLine("QA Engineer Job Post is selected");
            Thread.Sleep(1000);
        }

        public void VerifyJobPageTitleAndInfo()
        {
            IWebElement JobPageDetails = driver.FindElement(jobPageDetails);
            if (JobPageDetails.Text.Contains("Numadic Iot Pvt. Ltd."))
            {
                Console.WriteLine("Numadic Iot Pvt. Ltd Text is verified");
                if (JobPageDetails.Text.Contains("QA Engineer"))
                {
                    IWebElement JobInterest = driver.FindElement(jobInterest);
                    JobInterest.Click();                   
                    Console.WriteLine("QA Engineer Text is verified");
                    Console.WriteLine("I'm Interested button is clicked to fill the application");
                }
                else
                {
                    Console.WriteLine("QA Engineer Text is not verified");
                }
            }
            else
            {
                Console.WriteLine("Numadic Iot Pvt. Ltd Text is not verified");
            }
            Thread.Sleep(1000);
        }
        public void BasicInfo()
        {
            IWebElement DrpDwnSalutation = driver.FindElement(drpDwnSalutation);         
            IWebElement FirstName = driver.FindElement(firstName);
            IWebElement LastName = driver.FindElement(lastName);
            IWebElement Email = driver.FindElement(email);
            IWebElement Mobile = driver.FindElement(mobile);
            DrpDwnSalutation.Click();
            Thread.Sleep(1000);
            IWebElement Salutation = driver.FindElement(salutation);
            Salutation.Click();
            FirstName.SendKeys("Meghashree");
            LastName.SendKeys("BB");
            Email.SendKeys("MeghashreeBB@gmail.com");
            Mobile.SendKeys("7236736730");
            Console.WriteLine("Basic informations are filled");
            Thread.Sleep(1000);
        }
        public void AddressInfo()
        {
            IWebElement DrpDwnState_Province = driver.FindElement(drpDwnState_Province);
            DrpDwnState_Province.SendKeys("Karnataka");
            Thread.Sleep(1000);
            IWebElement State_Province = driver.FindElement(state_Province);
            State_Province.Click();
            Console.WriteLine("Address informations are filled");
            Thread.Sleep(1000);
        }
        public void ProfessionalInfo()
        {
            IWebElement CurrentEmployer = driver.FindElement(currentEmployer);
            IWebElement DrpDwnCurrentJobTitle = driver.FindElement(drpDwnCurrentJobTitle);
            IWebElement DrpDwnSkillSet = driver.FindElement(drpDwnSkillSet);
            IWebElement CurrentCTC = driver.FindElement(currentCTC);
            IWebElement ExpectedCTC = driver.FindElement(expectedCTC);
            CurrentEmployer.SendKeys("AMDOCS");
            DrpDwnCurrentJobTitle.Click();
            Thread.Sleep(20);
            IWebElement CurrentJobTitle = driver.FindElement(currentJobTitle);
            CurrentJobTitle.Click();
            DrpDwnSkillSet.SendKeys("JAVA");
            Thread.Sleep(1000);
            IWebElement SkillSet = driver.FindElement(skillSet);
            SkillSet.Click();
            CurrentCTC.SendKeys("6LPA");
            ExpectedCTC.SendKeys("6LPA");
            Console.WriteLine("Professional informations are filled");
            Thread.Sleep(1000);
        }
        public void OtherInfo()
        {
            IWebElement ReasonForChange = driver.FindElement(reasonForChange);
            IWebElement WhyJoinNumadic = driver.FindElement(whyJoinNumadic);
            IWebElement LinkedIn = driver.FindElement(linkedIn);
            ReasonForChange.SendKeys("Changing");
            WhyJoinNumadic.SendKeys("Interested");
            LinkedIn.SendKeys("http://linkedin.com/in/meghashree-b-b-33a2751b0");
            Console.WriteLine("Other informations are filled");
            Thread.Sleep(1000);
        }
        public void UploadFileAndVerifySubmit()
        {
            IWebElement Browse = driver.FindElement(browse);
            IWebElement Submit = driver.FindElement(submit);
            var path = @"C:\Users\da\source\repos\ConsoleApp3\ConsoleApp3\Files\Meghashree_B_B.pdf";
            Browse.SendKeys(path);
            Console.WriteLine("File got uploaded by Browse button");
            Submit.Click();
            Console.WriteLine("Submit button is clicked");
            IWebElement SubmitionError = driver.FindElement(submitionError);
            if (SubmitionError.Text.Contains("Notice Period (days) cannot be empty."))
            {
                Console.WriteLine("Application not submitted due to Notice Period (days) is blank");
            }
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}
