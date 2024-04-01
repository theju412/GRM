using GRMAutomation.DataReader;
using GRMAutomation.PageObjects.SettingsPage;
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

namespace GRMAutomation.Tests.SettingsTest
{

    [TestFixture, Order(1)]
    class CreateCompanyTest : ScreenCapturer
    {
        /*
       *  Openning the browser and opening the Create Company Page 
    */
        [SetUp]
        public void LaunchingBrowser()
        {
            driver = LaunchingTheBrowserAndOpeningCreateCompanyOrHotelPage();
        }

        #region Creating Company with GRM Features

        [Test, Order(1)]
        public void CreateCompanyWithGRMFeature()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(CreateCompanyTest));

            test = extent.StartTest("CreateCompanyPage", "Check whether able to Create Company with entered details");
            string companyName = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 1, 1).ToString();
            string city = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 2, 1).ToString();
            string state = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 3, 1).ToString();
            string countryName = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 4, 1).ToString();
            string zipCode = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 5, 1).ToString();
            string address1 = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 6, 1).ToString();
            string address2 = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 7, 1).ToString();
            string licensedGuestRoom = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 8, 1).ToString();
            string licensedConferenceSpace = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 9, 1).ToString();
            string licensedType = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 10, 1).ToString();


            CreateCompanyPage obj = new CreateCompanyPage(driver);
            obj.EnterCompanyName(companyName, log, test);
            obj.EnterCityName(city, log, test);
            obj.EnterStateName(state, log, test);
            obj.SelectCountry(countryName, log, test);
            obj.EnterZipCode(zipCode, log, test);
            obj.EnterAddress1(address1, log, test);
            obj.EnterAddress2(address2, log, test);
            obj.EnterLicensedGuestRoom(licensedGuestRoom, log, test);
            obj.EnterLicensedConferenceSpace(licensedConferenceSpace, log, test);
            obj.SelectLicensedType(licensedType, log, test);
            obj.SelectCompanyFeaturesForGRM(log, test);

            obj.ClickOnSubmitButton(log, test);
            Assert.IsTrue(obj.VerifyForSuccessMessageWithProductKeyAndCompanyIDWithGRMFeatures(log, test));

            test.Log(LogStatus.Pass, "Company created with GRM features Successfully");
        }

        #endregion

        #region Creating Company with Marketplace Features

        [Test, Order(2)]
        public void CreateCompanyWithMarketplaceFeature()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(CreateCompanyTest));

            test = extent.StartTest("CreateCompanyPage", "Check whether able to Create Company with entered details");
            string companyName = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 1, 2).ToString();
            string city = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 2, 2).ToString();
            string state = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 3, 2).ToString();
            string countryName = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 4, 2).ToString();
            string zipCode = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 5, 2).ToString();
            string address1 = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 6, 2).ToString();
            string address2 = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 7, 2).ToString();
            string licensedGuestRoom = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 8, 2).ToString();
            string licensedConferenceSpace = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 9, 2).ToString();
            string licensedType = ExcelReaderHelper.GetCellData(fileLocation, "CreateCompanyData", 10, 2).ToString();

            CreateCompanyPage obj = new CreateCompanyPage(driver);
            obj.EnterCompanyName(companyName, log, test);
            obj.EnterCityName(city, log, test);
            obj.EnterStateName(state, log, test);
            obj.SelectCountry(countryName, log, test);
            obj.EnterZipCode(zipCode, log, test);
            obj.EnterAddress1(address1, log, test);
            obj.EnterAddress2(address2, log, test);
            obj.EnterLicensedGuestRoom(licensedGuestRoom, log, test);
            obj.EnterLicensedConferenceSpace(licensedConferenceSpace, log, test);
            obj.SelectLicensedType(licensedType, log, test);
            obj.SelectCompanyFeaturesForMarketplace(log, test);

            obj.ClickOnSubmitButton(log, test);
            Assert.IsTrue(obj.VerifyForSuccessMessageWithProductKeyAndCompanyIDWithMarketplaceFeatures(log, test));

            test.Log(LogStatus.Pass, "Company created with Marketplace features Successfully");
        }

        #endregion

        [TearDown]
        public void ClosingBrowser()
        {
            CloseBrowser(extent);
        }
    }
}
