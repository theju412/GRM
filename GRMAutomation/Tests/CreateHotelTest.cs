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
    [TestFixture, Order(2)]
    class CreateHotelTest : ScreenCapturer
    {
        /*
      *  Openning the browser and opening the Create Hotel Page 
   */

        [SetUp]
        public void LaunchingBrowser()
        {
            driver = LaunchingTheBrowserAndOpeningCreateCompanyOrHotelPage();
        }

        #region Creating Hotel with Newly Created Company details

        [Test, Order(1)]
        public void CreateHotelWithNewlyCreatedCompany()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(CreateHotelTest));

            test = extent.StartTest("CreateHotelPage", "Check whether able to Create Hotel with Newly Created Company details");

            CreateHotelPage obj = new CreateHotelPage(driver);            

            string companyName = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 1, 2).ToString();
            obj.SelectCompanyName(log, test, companyName);
            string hotelName = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 2, 1).ToString();
            obj.EnterHotelName(log, test, hotelName);
            string city = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 3, 2).ToString();
            obj.EnterCityName(log, test, city);
            string state = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 4, 2).ToString();
            obj.EnterStateName(log, test, state);
            string country = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 5, 2).ToString();
            obj.SelectCountry(log, test, country);
            string Zip = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 6, 2).ToString();
            obj.EnterZipCode(log, test, Zip);
            string address1 = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 7, 2).ToString();
            obj.EnterAddress1(log, test, address1);
            string address2 = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 8, 2).ToString();
            obj.EnterAddress2(log, test, address2);
            string phone = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 9, 1).ToString();
            obj.EnterPhoneNo(log, test, phone);
            string FaxNo = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 10, 1).ToString();
            obj.EnterFaxNo(log, test, FaxNo);
            string Venuetype = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 11, 1).ToString();
            obj.SelectVenueType(log, test, Venuetype);
            string starRating = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 12, 1).ToString();
            obj.SelectStarRating(log, test, starRating);
            string features = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 13, 1).ToString();
            obj.SelectFeatures(log, test, features);
            string Url = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 14, 1).ToString();
            obj.SelectURL(log, test, Url);

            obj.SelectStripeAccountForPayment(log, test);
            obj.ClickOnSubmitButton(log, test);

            Assert.IsTrue(obj.VerifyForSuccessMessageWithHotelIDfornewlycreatedHotel(log, test));

            test.Log(LogStatus.Pass, "Hotel created Successfully with Newly Created Company details");
        }

        #endregion

        #region Creating Hotel with Existing Company details

        [Test, Order(2)]
        public void CreateHotelWithExistingCompany()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(CreateHotelTest));

            test = extent.StartTest("CreateHotelPage", "Check whether able to Create Hotel with Existing Company details");

            CreateHotelPage obj = new CreateHotelPage(driver);

            string companyName = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 1, 1).ToString();
            obj.SelectCompanyName(log, test, companyName);
            string hotelName = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 2, 1).ToString();
            obj.EnterHotelName(log, test, hotelName);
            string city = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 3, 1).ToString();
            obj.EnterCityName(log, test, city);
            string state = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 4, 1).ToString();
            obj.EnterStateName(log, test, state);
            string country = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 5, 1).ToString();
            obj.SelectCountry(log, test, country);
            string Zip = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 6, 1).ToString();
            obj.EnterZipCode(log, test, Zip);
            string address1 = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 7, 1).ToString();
            obj.EnterAddress1(log, test,address1);
            string address2 = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 8, 1).ToString();
            obj.EnterAddress2(log, test, address2);
            string phone = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 9, 1).ToString();
            obj.EnterPhoneNo(log, test, phone);
            string FaxNo = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 10, 1).ToString();
            obj.EnterFaxNo(log, test, FaxNo);
            string Venuetype = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 11, 1).ToString();
            obj.SelectVenueType(log, test, Venuetype);
            string starRating = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 12, 1).ToString();
            obj.SelectStarRating(log, test, starRating);
            string features = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 13, 1).ToString();
            obj.SelectFeatures(log, test, features);
            string Url = ExcelReaderHelper.GetCellData(fileLocation, "CreateHotelData", 14, 1).ToString();
            obj.SelectURL(log, test, Url);

            obj.SelectStripeAccountForPayment(log, test);
            obj.ClickOnSubmitButton(log, test);

            Assert.IsTrue(obj.VerifyForSuccessMessageWithHotelIDfornewlycreatedHotel(log, test));

            test.Log(LogStatus.Pass, "Hotel created Successfully with Existing Company details");
        }

        #endregion

        [TearDown]
        public void ClosingBrowser()
        {
            CloseBrowser(extent);
        }
    }
}
