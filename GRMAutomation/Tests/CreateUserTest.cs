using GRMAutomation.DataReader;
using GRMAutomation.PageObjects;
using GRMAutomation.Utilities;
using log4net;
using log4net.Config;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMAutomation.Tests
{
    [TestFixture, Order(3)]
    class CreateUserTest : ScreenCapturer
    {

        [SetUp]
        public void LaunchingBrowser()
        {
            driver = LaunchingTheBrowserAndOpeningSignUpPage();
        }

        #region Create User With Invalid ProductKey
        [Test, Order(1)]
        public void CreateUserWithInvalidProductKey()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(CreateUserTest));

            test = extent.StartTest("Create User with Invalid Product Key", "Check whether user creation is done with invalid product key");
            CreateUserPage CreateUserPageObj = new CreateUserPage(driver);

            string ProductKey = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 1, 1).ToString();
            string Title = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 2, 1).ToString();
            string FirstName = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 3, 1).ToString();
            string LastName = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 4, 1).ToString();
            string EmailId = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 5, 1).ToString();
            string Password = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 6, 1).ToString();
            string ConfirmPassword = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 7, 1).ToString();

            CreateUserPageObj.CreateUserWithInvalidProductKey(log, test, ProductKey, Title, FirstName, LastName, EmailId, Password, ConfirmPassword);

        }
        #endregion

        #region Create User With Valid ProductKey For GRM
        [Test, Order(2)]
        public void CreateUserWithValidProductKeyForGRM()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(CreateUserTest));

            test = extent.StartTest("Create User with Valid product Key for GRM", "Check whether user creation is done successfully with valid product key");
            CreateUserPage CreateUserPageObj = new CreateUserPage(driver);

            string ProductKey = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 1, 2).ToString();
            string Title = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 2, 2).ToString();
            string FirstName = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 3, 2).ToString();
            string LastName = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 4, 2).ToString();
            string EmailId = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 5, 2).ToString();
            string Password = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 6, 2).ToString();
            string ConfirmPassword = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 7, 2).ToString();

            CreateUserPageObj.CreateUserWithValidProductKeyForGRM(log, test, ProductKey, Title, FirstName, LastName, EmailId, Password, ConfirmPassword);
        }
        #endregion

        #region Create User With Valid ProductKey For MarketPlace
        [Test, Order(3)]
        public void CreateUserWithValidProductKeyForMarketPlace()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(CreateUserTest));

            test = extent.StartTest("Create User with Valid product Key for MarketPlace", "Check whether user creation is done successfully with valid product key");
            CreateUserPage CreateUserPageObj = new CreateUserPage(driver);

            string ProductKey = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 1, 3).ToString();
            string Title = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 2, 3).ToString();
            string FirstName = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 3, 3).ToString();
            string LastName = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 4, 3).ToString();
            string EmailId = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 5, 3).ToString();
            string Password = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 6, 3).ToString();
            string ConfirmPassword = DataReader.ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", 7, 3).ToString();

            CreateUserPageObj.CreateUserWithValidProductKeyForMarketPlace(log, test, ProductKey, Title, FirstName, LastName, EmailId, Password, ConfirmPassword);
        }
        #endregion


        [TearDown]
        public void ClosingBrowser()
        {
            CloseBrowser(extent);
        }
    }
}


