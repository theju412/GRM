using GRMAutomation.DataReader;
using GRMAutomation.PageObjects.Locator;
using GRMAutomation.Utilities;
using log4net;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GRMAutomation.PageObjects
{
    class ForgotPasswordPage : ScreenCapturer
    {
        #region
        //finding element for forgotpassword
        [FindsBy(How = How.Id, Using = ForgotPasswordLocator.ForgotpassworduserName)]
        public IWebElement ForgotpassworduserName { get; set; }

        [FindsBy(How = How.Id, Using = ForgotPasswordLocator.BackButton)]
        public IWebElement BackButton { get; set; }

        [FindsBy(How = How.Id, Using = ForgotPasswordLocator.ResetPasswordButton)]
        public IWebElement ResetPasswordButton { get; set; }

        #endregion

        #region Initialization of web page element
        public ForgotPasswordPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        #endregion

        #region Click on forgotpassword
        public void ClickOnForgotPasswordLink(ILog log, ExtentTest test)
        {
            GRMLoginPage loginobj = new GRMLoginPage(driver);
            loginobj.LoginButton.WaitTillElementToBeClickable(driver, 60);
            driver.FindElement(By.LinkText("Forgot Password?")).Click();
            log.Info("Clicked on forgotpassword link");
            test.Log(LogStatus.Pass, "Clicked on forgotpassword link");
        }
        #endregion

        #region Resetting the password
        public void EnterUserNameForForgotpasswordLink(ILog log, ExtentTest test)
        {
            var Wait = WaitHelper.WaitForSpecificElement(driver);
            string SetforgotpassworduserName = ExcelReaderHelper.GetCellData(fileLocation, "ValidCredentials", 5, 0).ToString();
            ForgotpassworduserName.EnterValue(SetforgotpassworduserName);
            log.Info("User name has been entred for forgot password");
            test.Log(LogStatus.Pass, "User name has been entred for forgot password");
        }
        #endregion

        #region Verfiying page navigation for back button
        public void ClickOnBackButtonForForgotPassword(ILog log, ExtentTest test)
        {
            BackButton.Click();
            log.Info("Clicked on back button");
            test.Log(LogStatus.Pass, "Clicked on back button");
            GRMLoginPage loginobj = new GRMLoginPage(driver);
            loginobj.LoginButton.WaitTillElementToBeClickable(driver, 60);
            log.Info("Navigated to login page");
            test.Log(LogStatus.Pass, "Navigated to login page");
        }
        #endregion

        #region Clicking on reset button with valid username
        public void ClickOnResetButtonWithUserName(ILog log, ExtentTest test)
        {
            EnterUserNameForForgotpasswordLink(log, test);
            ResetPasswordButton.Click();
            string alertText = driver.SwitchTo().Alert().Text;
            Assert.IsTrue(alertText.Contains("A message has been sent to your email with password reset instructions if the login name you entered exists in the system"));
            log.Info("Mail send successfully to rest the password");
            test.Log(LogStatus.Pass, "Mail send successfully to rest the password");

            IAlert alert = driver.SwitchTo().Alert();
            alert.Dismiss();
            log.Info("Closed the alert pop up");
            test.Log(LogStatus.Pass, "Closed the alert pop up");
        }
        #endregion

        #region Clicking on reset button with invalid username
        public void ClickOnResetButtonWithInvalidUserName(ILog log, ExtentTest test)
        {
            int row_count = ExcelReaderHelper.GetTotalRows(fileLocation, "InvalidCredentials");
            for (int i = 1; i < row_count; i++)
            {
                string Name = ExcelReaderHelper.GetCellData(fileLocation, "InValidCredentials", i, 5).ToString();
                ForgotpassworduserName.SendKeys(Keys.Control + "a");
                ForgotpassworduserName.SendKeys(Keys.Delete);
                ForgotpassworduserName.EnterValue(Name);
                ResetPasswordButton.Click();

                string alertText = driver.SwitchTo().Alert().Text;
                Assert.IsTrue(alertText.Contains("Not a valid e-mail address"));
                log.Info("Entered user name is either invalid");
                test.Log(LogStatus.Pass, "Entered user name is either invalid");
                IAlert alert = driver.SwitchTo().Alert();
                alert.Dismiss();
                log.Info("Closed the alert pop up");
                test.Log(LogStatus.Pass, "Closed the alert pop up");
                ResetPasswordButton.WaitTillElementToBeClickable(driver, 60);
               // Thread.Sleep(3000);
            }
            #endregion
        }
    }
}
