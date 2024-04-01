using GRMAutomation.DataReader;
using GRMAutomation.PageObjects.Locator;
using GRMAutomation.Utilities;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMAutomation.PageObjects
{
    class LoginPage: ScreenCapturer
    {
        #region
        [FindsBy(How = How.Id, Using = LoginPageLocator.UserName)]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = LoginPageLocator.Password)]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = LoginPageLocator.LoginButton)]
        public IWebElement LoginButton { get; set; }

        #endregion

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #region Passing User Name
        public void SetUserName(ILog log, ExtentTest test)
        {
            string UserNameValue = ExcelReaderHelper.GetCellData(fileLocation, "ValidCredentials", 1, 1).ToString();
            var Wait = WaitHelper.WaitForSpecificElement(driver);
            Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(LoginPageLocator.LoginButton)));
            UserName.EnterValue(UserNameValue);
            log.Info("User name has been entred ");
            test.Log(LogStatus.Pass, "User name has been entred");
        }
        #endregion

        #region Passing password

        public void SetPassword(ILog log, ExtentTest test)
        {
            string PasswordValue = ExcelReaderHelper.GetCellData(fileLocation, "ValidCredentials", 2, 1).ToString();
            IJavaScriptExecutor javascriptExecutor = (IJavaScriptExecutor)driver;
            string jsString = "document.getElementById('" + LoginPageLocator.Password + "').value='" + PasswordValue + "'";
            javascriptExecutor.ExecuteScript(jsString);
            javascriptExecutor.ExecuteScript("arguments[0].click()", Password);
            log.Info("Password entered successfully");
            test.Log(LogStatus.Info, "Password entered successfully");
        }
        #endregion
        public void ClickLoginButton(ILog log, ExtentTest test)
        {
            LoginButton.Click();
            log.Info("clicked on login button");
            test.Log(LogStatus.Info, "clicked on login button");
        }
    }
}
