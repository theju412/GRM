using GRMAutomation.DataReader;
using GRMAutomation.DataWriter;
using GRMAutomation.PageObjects.Locator;
using GRMAutomation.Utilities;
using log4net;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMAutomation.PageObjects
{
    class CreateUserPage: ScreenCapturer
    {
        #region WebElements

        [FindsBy(How = How.XPath, Using = CreateUserLocator.ProductKeyField)]
        public IWebElement ProductKeyField { get; set; }

        [FindsBy(How = How.XPath, Using = CreateUserLocator.TitleField)]
        public IWebElement TitleField { get; set; }

        [FindsBy(How = How.XPath, Using = CreateUserLocator.FirstNameField)]
        public IWebElement FirstNameField { get; set; }

        [FindsBy(How = How.XPath, Using = CreateUserLocator.LastNameField)]
        public IWebElement LastNameField { get; set; }

        [FindsBy(How = How.XPath, Using = CreateUserLocator.EmailIdField)]
        public IWebElement EmailIdField { get; set; }

        [FindsBy(How = How.XPath, Using = CreateUserLocator.PasswordField)]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = CreateUserLocator.ConfirmPasswordField)]
        public IWebElement ConfirmPasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = CreateUserLocator.UserRoleDropdown)]
        public IWebElement UserRoleDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = CreateUserLocator.ListOfUserRoles)]
        public IList<IWebElement> ListOfUserRoles { get; set; }

        [FindsBy(How = How.XPath, Using = CreateUserLocator.SubmitButton)]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = CreateUserLocator.InvalidProductKeyMessage)]
        public IWebElement InvalidProductKeyMessage { get; set; }

        [FindsBy(How = How.XPath, Using = CreateUserLocator.AlreadyExistMessage)]
        public IWebElement AlreadyExistMessage { get; set; }

        [FindsBy(How = How.XPath, Using = CreateUserLocator.UserCreatedMessage)]
        public IWebElement UserCreatedMessage { get; set; }

        #endregion

        #region Constructor
        public CreateUserPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }
        #endregion


        #region CreateUserWithInvalidProductKey

        public void CreateUserWithInvalidProductKey(ILog log, ExtentTest test, string ProductKey, string Title, string FirstName, string LastName, string EmailId, string Password, string ConfirmPassword)
        {
            Assert.IsTrue(ProductKeyField.Displayed);
            ProductKeyField.EnterValue(ProductKey);
            test.Log(LogStatus.Info, "Entered Product Key :" + ProductKey);

            Assert.IsTrue(TitleField.Displayed);
            TitleField.EnterValue(Title);
            test.Log(LogStatus.Info, "Entered Title :" + Title);

            Assert.IsTrue(FirstNameField.Displayed);
            FirstNameField.EnterValue(FirstName);
            test.Log(LogStatus.Info, "Entered First Name :" + FirstName);

            Assert.IsTrue(LastNameField.Displayed);
            LastNameField.EnterValue(LastName);
            test.Log(LogStatus.Info, "Entered Last Name :" + LastName);

            Assert.IsTrue(EmailIdField.Displayed);
            EmailIdField.EnterValue(EmailId);
            test.Log(LogStatus.Info, "Entered Email Id :" + EmailId);

            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            string jsString = "document.getElementById('" + "txtNewPassword" + "').value='" + Password + "'";
            executor.ExecuteScript(jsString);

            string jsString1 = "document.getElementById('" + "txtConfirmPassword" + "').value='" + ConfirmPassword + "'";
            executor.ExecuteScript(jsString1);

            SelectUserRole(log, test);
            ClickOnSubmitButton(log, test);
            ErrorMessage(log, test);

        }
        public void SelectUserRole(ILog log, ExtentTest test)
        {
            Assert.IsTrue(UserRoleDropdown.Displayed);
            UserRoleDropdown.ClickOn(driver, 10);
            test.Log(LogStatus.Info, "Clicked on Select Userrole dropdown");

            string UserRole = ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 8, 1).ToString();

            driver.SelectADropDownValue(ListOfUserRoles, UserRole);
            Assert.AreEqual(UserRole, UserRoleDropdown.GetSelectedTextValue());
            test.Log(LogStatus.Info, "Super Admin selected");

        }
        public void ClickOnSubmitButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(SubmitButton.Displayed);
            SubmitButton.ClickOn(driver, 10);
            test.Log(LogStatus.Info, "Submit Button is clicked");

        }
        public void ErrorMessage(ILog log, ExtentTest test)
        {
            Assert.IsTrue(InvalidProductKeyMessage.Displayed);
            test.Log(LogStatus.Pass, "The product key entered is not valid");
        }
        #endregion


        #region CreateUserWithvalidProductKeyForGRM

        public void CreateUserWithValidProductKeyForGRM(ILog log, ExtentTest test, string ProductKey, string Title, string FirstName, string LastName, string EmailId, string Password, string ConfirmPassword)
        {
            Assert.IsTrue(ProductKeyField.Displayed);
            ProductKeyField.EnterValue(ProductKey);
            test.Log(LogStatus.Info, "Entered Product Key :" + ProductKey);

            Assert.IsTrue(TitleField.Displayed);
            TitleField.EnterValue(Title);
            test.Log(LogStatus.Info, "Entered Title :" + Title);

            Assert.IsTrue(FirstNameField.Displayed);
            FirstNameField.EnterValue(FirstName);
            test.Log(LogStatus.Info, "Entered First Name :" + FirstName);

            Assert.IsTrue(LastNameField.Displayed);
            LastNameField.EnterValue(LastName);
            test.Log(LogStatus.Info, "Entered Last Name :" + LastName);

            Assert.IsTrue(EmailIdField.Displayed);
            EmailIdField.EnterValue(EmailId);
            test.Log(LogStatus.Info, "Entered Email Id :" + EmailId);

            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            string jsString = "document.getElementById('" + "txtNewPassword" + "').value='" + Password + "'";
            executor.ExecuteScript(jsString);

            string jsString1 = "document.getElementById('" + "txtConfirmPassword" + "').value='" + ConfirmPassword + "'";
            executor.ExecuteScript(jsString1);

            SelectUserRole1(log, test);
            VerifyEmailIdAlreadyExistForGRM(log, test, EmailId, Password);

        }
        public void SelectUserRole1(ILog log, ExtentTest test)
        {
            Assert.IsTrue(UserRoleDropdown.Displayed);
            UserRoleDropdown.ClickOn(driver, 10);
            test.Log(LogStatus.Info, "Clicked on Select Userrole dropdown");

            string UserRole = ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 8, 2).ToString();

            driver.SelectADropDownValue(ListOfUserRoles, UserRole);
            Assert.AreEqual(UserRole, UserRoleDropdown.GetSelectedTextValue());
            test.Log(LogStatus.Info, "Super Admin selected");

        }
        public void ClickOnSubmitButton1(ILog log, ExtentTest test)
        {
            Assert.IsTrue(SubmitButton.Displayed);
            SubmitButton.ClickOn(driver, 10);
            test.Log(LogStatus.Info, "Submit Button is clicked");

        }
        public void VerifyEmailIdAlreadyExistForGRM(ILog log, ExtentTest test, string EmailId, string Password)
        {

            int status = 0;
           
            string companyID= ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData",33, 2).ToString();
            string query = "select Email from [User] where companyID="+companyID;
            dataSet = DBConnection.GetDBData(query);

            List<string> ListOfEmail = new List<string>();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                ListOfEmail.Add(dataSet.Tables[0].Rows[i]["Email"].ToString());
                Console.WriteLine(ListOfEmail[i].ToString());
            }

            int RowCount = ExcelReaderHelper.GetTotalRows(fileLocation, "CreatedUserEmailsForGRM");

            for (int j = 0; j < ListOfEmail.Count; j++)
            {
                if (EmailId.Equals(ListOfEmail[j]))
                {
                    ClickOnSubmitButton1(log, test);
                    Assert.IsTrue(AlreadyExistMessage.Displayed);
                    test.Log(LogStatus.Pass, AlreadyExistMessage.Text + " which is: " + EmailId);
                    status = 1;
                    break;
                }
            }
            if (status ==0)
            {
                ClickOnSubmitButton1(log, test);
                Assert.IsTrue(UserCreatedMessage.Displayed);
                test.Log(LogStatus.Pass, "User is created: "+ EmailId);

                ExcelWriterHelper.WriteInToExcel(fileLocation, "CreatedUserEmailsForGRM", RowCount, 0, EmailId);
                ExcelWriterHelper.WriteInToExcel(fileLocation, "CreatedUserEmailsForGRM", RowCount, 1, Password);
            }

        }
        #endregion


        #region CreateUserWithvalidProductKeyForMarketPlace

        public void CreateUserWithValidProductKeyForMarketPlace(ILog log, ExtentTest test, string ProductKey, string Title, string FirstName, string LastName, string EmailId, string Password, string ConfirmPassword)
        {
            Assert.IsTrue(ProductKeyField.Displayed);
            ProductKeyField.EnterValue(ProductKey);
            test.Log(LogStatus.Info, "Entered Product Key :" + ProductKey);

            Assert.IsTrue(TitleField.Displayed);
            TitleField.EnterValue(Title);
            test.Log(LogStatus.Info, "Entered Title :" + Title);

            Assert.IsTrue(FirstNameField.Displayed);
            FirstNameField.EnterValue(FirstName);
            test.Log(LogStatus.Info, "Entered First Name :" + FirstName);

            Assert.IsTrue(LastNameField.Displayed);
            LastNameField.EnterValue(LastName);
            test.Log(LogStatus.Info, "Entered Last Name :" + LastName);

            Assert.IsTrue(EmailIdField.Displayed);
            EmailIdField.EnterValue(EmailId);
            test.Log(LogStatus.Info, "Entered Email Id :" + EmailId);

            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            string jsString = "document.getElementById('" + "txtNewPassword" + "').value='" + Password + "'";
            executor.ExecuteScript(jsString);

            string jsString1 = "document.getElementById('" + "txtConfirmPassword" + "').value='" + ConfirmPassword + "'";
            executor.ExecuteScript(jsString1);

            SelectUserRole1(log, test);
            VerifyEmailIdAlreadyExistForMarketPlace(log, test, EmailId, Password);

        }
       
        public void VerifyEmailIdAlreadyExistForMarketPlace(ILog log, ExtentTest test, string EmailId, string Password)
        {

            int status = 0;

            string companyID = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 33, 3).ToString();
            string query = "select Email from [User] where companyID=" + companyID;
            dataSet = DBConnection.GetDBData(query);

            List<string> ListOfEmail = new List<string>();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                ListOfEmail.Add(dataSet.Tables[0].Rows[i]["Email"].ToString());
                Console.WriteLine(ListOfEmail[i].ToString());
            }

            int RowCount = ExcelReaderHelper.GetTotalRows(fileLocation, "CreatedUserEmailsForMarketPlace");

            for (int j = 0; j < ListOfEmail.Count; j++)
            {
                if (EmailId.Equals(ListOfEmail[j]))
                {
                    ClickOnSubmitButton1(log, test);
                    Assert.IsTrue(AlreadyExistMessage.Displayed);
                    test.Log(LogStatus.Pass, AlreadyExistMessage.Text+" which is: " + EmailId);
                    status = 1;
                    break;
                }
            }
            if (status == 0)
            {
                ClickOnSubmitButton1(log, test);
                Assert.IsTrue(UserCreatedMessage.Displayed);
                test.Log(LogStatus.Pass, "User is created : "+EmailId);

                ExcelWriterHelper.WriteInToExcel(fileLocation, "CreatedUserEmailsForMarketPlace", RowCount, 0, EmailId);
                ExcelWriterHelper.WriteInToExcel(fileLocation, "CreatedUserEmailsForMarketPlace", RowCount, 1, Password);
            }

        }
        #endregion
    }
}
