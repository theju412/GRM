using GRMAutomation.PageObjects;
using GRMAutomation.Utilities;
using log4net;
using log4net.Config;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMAutomation.Tests
{
    class ForgotPasswordTest : ScreenCapturer
    {
        [SetUp]
        public void LauchingBrowser()
        {
            driver = LaunchingTheBrowserAndOpeningGrmLoginPage();
        }

        [Test, Order(1)]
        public void ForgotPasswordFunctionalityWithValidUserName()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ForgotPasswordTest));

            test = extent.StartTest("Testing Forgot Functionality with valid username", "Entering valid user name");

            ForgotPasswordPage ForgotpassObj = new ForgotPasswordPage(driver);
            GRMLoginPage Objgrm = new GRMLoginPage(driver);
            Objgrm.IsGRMLogoPresent(log, test);
            ForgotpassObj.ClickOnForgotPasswordLink(log, test);
            ForgotpassObj.ClickOnResetButtonWithUserName(log, test);
        }

        [Test, Order(2)]
        public void ForgotPasswordFunctionalityWithInvalidUserName()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ForgotPasswordTest));
            test = extent.StartTest("Testing Forgot Functionality with invalid user name", "Entering Invaliduser name");
            ForgotPasswordPage ForgotpassObj = new ForgotPasswordPage(driver);
            GRMLoginPage Objgrm = new GRMLoginPage(driver);
            Objgrm.IsGRMLogoPresent(log, test);
            ForgotpassObj.ClickOnForgotPasswordLink(log, test);
            ForgotpassObj.ClickOnResetButtonWithInvalidUserName(log, test);
        }

        [Test, Order(3)]
        public void VerifyingPageAfterBackbuttonClicked()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ForgotPasswordTest));
            test = extent.StartTest("Testing Back button functionality", "Clicking on back button");
            ForgotPasswordPage ForgotpassObj = new ForgotPasswordPage(driver);
            ForgotpassObj.ClickOnForgotPasswordLink(log, test);
            ForgotpassObj.ClickOnBackButtonForForgotPassword(log, test);
        }

        [TearDown]
        public void ClosingBrowser()
        {
            CloseBrowser(extent);

        }

    }
}
