using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Steps objt = new Steps();
                objt.LaunchApp();
                objt.VerifyApplicationTitle();
                objt.FilterJobTypeToApply();
                objt.VerifyJobPageTitleAndInfo();
                objt.BasicInfo();
                objt.AddressInfo();
                objt.ProfessionalInfo();
                objt.OtherInfo();
                objt.UploadFileAndVerifySubmit();
                
            }
            catch(Exception e)
            {
                Console.WriteLine("TestMethod1 Failed");
            }
        }
    }
}
