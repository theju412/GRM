using GRMAutomation.DataReader;
using GRMAutomation.PageObjects;
using GRMAutomation.Utilities;
using log4net;
using log4net.Config;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMAutomation.Tests
{
    [TestFixture, Order(5)]
    class ConferenceroomTest: ScreenCapturer
    {
        [SetUp]
        public void LauchingBrowser()
        {
            driver = LaunchingTheBrowserAndOpeningGrmLoginPage();

        }

        #region Add Primary Conference Rooms
        [Test, Order(1)]
        public void AddPrimaryConferenceRooms()
        {

            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check whether primary conference rooms is added successfully");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);
            ConferenceroomObj.ClickOnAddPrimaryRoomsButton(log, test);

            string PrimaryRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 1).ToString();
            string PrimaryRoomDescription = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 2).ToString();
            string PrimaryRoomMaxAttendees = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 3).ToString();
            string PrimaryRoomsPerHold = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 4).ToString();
            string PrimaryRoomSetupCost = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 5).ToString();
            string PrimaryRoomSize = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 6).ToString();

            ConferenceroomObj.AddPrimaryConferenceRooms(log, test, PrimaryRoomName, PrimaryRoomDescription, PrimaryRoomMaxAttendees, PrimaryRoomsPerHold, PrimaryRoomSetupCost, PrimaryRoomSize);

            ConferenceroomObj.ClickOnAddMultiplePrimaryRoomsButton(log, test);
            ConferenceroomObj.AddMultiplePrimaryConferenceRoom(log, test);
            ConferenceroomObj.SubmitMultiplePrimaryRooms(log, test);

            int RowCount = ExcelReaderHelper.GetTotalRows(fileLocation, "ConferenceRoom");

            for (int i = 2; i < RowCount; i++)
            {
                String PrimaryRoomName1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 1).ToString();
                String PrimaryRoomDescription1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 2).ToString();
                String PrimaryRoomMaxAttendees1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 3).ToString();
                String PrimaryRoomsPerHold1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 4).ToString();
                String PrimaryRoomSetupCost1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 5).ToString();
                String PrimaryRoomSize1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 6).ToString();

                ConferenceroomObj.VerifyMultiplePrimaryRooms(log, test, PrimaryRoomName1, PrimaryRoomDescription1, PrimaryRoomMaxAttendees1, PrimaryRoomsPerHold1, PrimaryRoomSetupCost1, PrimaryRoomSize1);

            }
        }
        #endregion

        #region Primary Conference Room Field Validations
        [Test, Order(2)]
        public void PrimaryConferenceRoomFieldValidations()
        {

            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check Primary conference room Field validations");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);
            ConferenceroomObj.ClickOnAddMultiplePrimaryRoomsButton(log, test);

            string ExistingPrimaryRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 1).ToString();
            string PrimaryRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 17).ToString();
            string PrimaryRoomDescription = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 2, 17).ToString();
            string PrimaryRoomMaxAttendees = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 3, 17).ToString();
            string PrimaryRoomsPerHold = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 4, 17).ToString();
            string PrimaryRoomSetupCost = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 5, 17).ToString();
            string PrimaryRoomSize = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 6, 17).ToString();

            string PrimaryRoomMaxAttendeesNull = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 3, 18).ToString();
            string PrimaryRoomSetupCostNull = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 5, 18).ToString();
            string PrimaryRoomSizeNull = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 6, 18).ToString();
            string PrimaryRoomMaxAttendeesInavlidData = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 3, 19).ToString();
            string PrimaryRoomsPerHoldInvalidData = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 4, 19).ToString();
            string PrimaryRoomSetupCostInvalidData = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 5, 19).ToString();
            string PrimaryRoomSizeInvalidData = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 6, 19).ToString();

            ConferenceroomObj.PrimaryConferenceRoomFieldValidations(log, test, ExistingPrimaryRoomName, PrimaryRoomName, PrimaryRoomDescription, PrimaryRoomMaxAttendeesNull, PrimaryRoomMaxAttendeesInavlidData, PrimaryRoomMaxAttendees, PrimaryRoomsPerHoldInvalidData, PrimaryRoomsPerHold, PrimaryRoomSetupCostNull, PrimaryRoomSetupCostInvalidData, PrimaryRoomSetupCost, PrimaryRoomSizeNull, PrimaryRoomSizeInvalidData, PrimaryRoomSize);

        }
        #endregion

        #region Edit Primary Conference Room
        [Test, Order(3)]
        public void EditPrimaryConferenceRoom()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check whether primary conference room added can be updated successfully");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);

            string ExistingPrimaryRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 1).ToString();
            string PrimaryRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 7).ToString();
            string PrimaryRoomDescription = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 2, 7).ToString();
            string PrimaryRoomMaxAttendees = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 3, 7).ToString();
            string PrimaryRoomsPerHold = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 4, 7).ToString();
            string PrimaryRoomSetupCost = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 5, 7).ToString();
            string PrimaryRoomSize = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 6, 7).ToString();

            ConferenceroomObj.EditPrimaryConferenceRoom(log, test, ExistingPrimaryRoomName, PrimaryRoomName, PrimaryRoomDescription, PrimaryRoomMaxAttendees, PrimaryRoomsPerHold, PrimaryRoomSetupCost, PrimaryRoomSize);
        }
        #endregion

        #region Add Media for Primary Conference Room
        [Test, Order(4)]
        public void AddMediaForPrimaryConferenceRoom()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check whether Media is added successfully");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);

            string PrimaryRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 7).ToString();
            string PrimaryMediaName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 8).ToString();

            ConferenceroomObj.AddMediaForPrimaryConferenceRoom(log, test, PrimaryRoomName, PrimaryMediaName);
        }
        #endregion

        #region Delete Added Media for Primary Conference Room
        [Test, Order(5)]
        public void DeleteAddedPrimaryRoomMedia()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check whether Media is deleted successfully");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);

            string PrimaryRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 7).ToString();
            string PrimaryMediaName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 8).ToString();

            ConferenceroomObj.DeleteAddedPrimaryRoomMedia(log, test, PrimaryRoomName, PrimaryMediaName);
        }
        #endregion

        #region Delete Primary Conference Room
        [Test, Order(6)]
        public void DeletePrimaryConferenceRoom()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check whether primary conference room is deleted successfully");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);

            string PrimaryRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 7).ToString();

            ConferenceroomObj.DeletePrimaryConferenceRoom(log, test, PrimaryRoomName);
        }
        #endregion
    
        #region Add Breakout Conference Rooms
        [Test, Order(7)]
        public void AddBreakoutConferenceRooms()
        {

            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check whether breakout conference rooms is added successfully");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);
            ConferenceroomObj.ClickOnAddBreakoutRoomsButton(log, test);

            string BreakoutRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 9).ToString();
            string BreakoutRoomDescription = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 10).ToString();
            string BreakoutRoomMaxAttendees = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 11).ToString();
            string BreakoutRoomsPerHold = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 12).ToString();
            string BreakoutRoomSetupCost = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 13).ToString();
            string BreakoutRoomSize = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 14).ToString();

            ConferenceroomObj.AddBreakoutConferenceRooms(log, test, BreakoutRoomName, BreakoutRoomDescription, BreakoutRoomMaxAttendees, BreakoutRoomsPerHold, BreakoutRoomSetupCost, BreakoutRoomSize);

            ConferenceroomObj.ClickOnAddMultipleBreakoutRoomsButton(log, test);
            ConferenceroomObj.AddMultipleBreakoutConferenceRoom(log, test);
            ConferenceroomObj.SubmitMultipleBreakoutRooms(log, test);

            int RowCount = ExcelReaderHelper.GetTotalRows(fileLocation, "ConferenceRoom");

            for (int i = 2; i < RowCount; i++)
            {
                String BreakoutRoomName1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 9).ToString();
                String BreakoutRoomDescription1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 10).ToString();
                String BreakoutRoomMaxAttendees1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 11).ToString();
                String BreakoutRoomsPerHold1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 12).ToString();
                String BreakoutRoomSetupCost1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 13).ToString();
                String BreakoutRoomSize1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 14).ToString();

                ConferenceroomObj.VerifyMultipleBreakoutRooms(log, test, BreakoutRoomName1, BreakoutRoomDescription1, BreakoutRoomMaxAttendees1, BreakoutRoomsPerHold1, BreakoutRoomSetupCost1, BreakoutRoomSize1);

            }

        }
        #endregion        

        #region Breakout Conference Room Field Validations
        [Test, Order(8)]
        public void BreakoutConferenceRoomFieldValidations()
        {

            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check Breakout conference room Field validations");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);
            ConferenceroomObj.ClickOnAddMultipleBreakoutRoomsButton(log, test);

            string ExistingBreakoutRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 9).ToString();
            string BreakoutRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 20).ToString();
            string BreakoutRoomDescription = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 2, 20).ToString();
            string BreakoutRoomMaxAttendees = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 3, 20).ToString();
            string BreakoutRoomsPerHold = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 4, 20).ToString();
            string BreakoutRoomSetupCost = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 5, 20).ToString();
            string BreakoutRoomSize = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 6, 20).ToString();

            string BreakoutRoomMaxAttendeesNull = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 3, 21).ToString();
            string BreakoutRoomSetupCostNull = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 5, 21).ToString();
            string BreakoutRoomSizeNull = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 6, 21).ToString();
            string BreakoutRoomMaxAttendeesInavlidData = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 3, 22).ToString();
            string BreakoutRoomsPerHoldInvalidData = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 4, 22).ToString();
            string BreakoutRoomSetupCostInvalidData = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 5, 22).ToString();
            string BreakoutRoomSizeInvalidData = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 6, 22).ToString();

            ConferenceroomObj.BreakoutConferenceRoomFieldValidations(log, test, ExistingBreakoutRoomName, BreakoutRoomName, BreakoutRoomDescription, BreakoutRoomMaxAttendeesNull, BreakoutRoomMaxAttendeesInavlidData, BreakoutRoomMaxAttendees, BreakoutRoomsPerHoldInvalidData, BreakoutRoomsPerHold, BreakoutRoomSetupCostNull, BreakoutRoomSetupCostInvalidData, BreakoutRoomSetupCost, BreakoutRoomSizeNull, BreakoutRoomSizeInvalidData, BreakoutRoomSize);

        }
        #endregion

        #region Edit Breakout Conference Room
        [Test, Order(9)]
        public void EditBreakoutConferenceRoom()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check whether breakout conference room added can be updated successfully");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);

            string ExistingBreakoutRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 15).ToString();
            string BreakoutRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 2, 15).ToString();
            string BreakoutRoomDescription = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 3, 15).ToString();
            string BreakoutRoomMaxAttendees = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 4, 15).ToString();
            string BreakoutRoomsPerHold = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 5, 15).ToString();
            string BreakoutRoomSetupCost = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 6, 15).ToString();
            string BreakoutRoomSize = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 7, 15).ToString();

            ConferenceroomObj.EditBreakoutConferenceRoom(log, test, ExistingBreakoutRoomName, BreakoutRoomName, BreakoutRoomDescription, BreakoutRoomMaxAttendees, BreakoutRoomsPerHold, BreakoutRoomSetupCost, BreakoutRoomSize);
        }
        #endregion

        #region Add Media for Breakout Conference Room
        [Test, Order(10)]
        public void AddMediaForBreakoutConferenceRoom()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check whether Media is added successfully");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);

            string BreakoutRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 15).ToString();
            string BreakoutMediaName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 16).ToString();

            ConferenceroomObj.AddMediaForBreakoutConferenceRoom(log, test, BreakoutRoomName, BreakoutMediaName);
        }
        #endregion

        #region Delete Added Media for Breakout Conference Room
        [Test, Order(11)]
        public void DeleteAddedBreakoutRoomMedia()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check whether Media is deleted successfully");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);

            string BreakoutRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 15).ToString();
            string BreakoutMediaName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 16).ToString();

            ConferenceroomObj.DeleteAddedBreakoutRoomMedia(log, test, BreakoutRoomName, BreakoutMediaName);
        }
        #endregion

        #region Delete Breakout Conference Room
        [Test, Order(12)]
        public void DeleteBreakoutConferenceRoom()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check whether breakout conference room is deleted successfully");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);

            string BreakoutRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 15).ToString();

            ConferenceroomObj.DeleteBreakoutConferenceRoom(log, test, BreakoutRoomName);
        }
        #endregion        

        #region Add Available Room Configurations
        [Test, Order(13)]
        public void AddAvailableRoomConfigurations()
        {

            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check whether room configurations is added successfully");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);
            ConferenceroomObj.ClickOnAddAvailableRoomConfigurationsButton(log, test);

            string Configuration = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 23).ToString();
            string SqftPerAttendee = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 24).ToString();
            string Description = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 25).ToString();

            ConferenceroomObj.AddAvailableRoomConfigurations(log, test, Configuration, SqftPerAttendee, Description);

            ConferenceroomObj.ClickOnAddMultipleAvailableRoomConfigurationsButton(log, test);
            ConferenceroomObj.AddMultipleAvailableRoomConfigurations(log, test);
            ConferenceroomObj.SubmitMultipleRoomConfigurations(log, test);

            int RowCount = ExcelReaderHelper.GetTotalRows(fileLocation, "ConferenceRoom");

            for (int i = 2; i < RowCount; i++)
            {
                String Configuration1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 23).ToString();
                String SqftPerAttendee1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 24).ToString();
                String Description1 = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 25).ToString();

                ConferenceroomObj.VerifyMultipleRoomConfigurations(log, test, Configuration1, SqftPerAttendee1, Description1);
            }

        }
        #endregion

        #region Edit Available Room Configurations
        [Test, Order(14)]
        public void EditAvailableRoomConfigurations()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check whether available room configurations can be updated successfully");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);

            string ExistingConfiguration = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 23).ToString();
            string Configuration = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 26).ToString();
            string SqftPerAttendee = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 2, 26).ToString();
            string Description = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 3, 26).ToString();

            ConferenceroomObj.EditAvailableRoomConfigurations(log, test, ExistingConfiguration, Configuration, SqftPerAttendee, Description);
        }
        #endregion

        #region Delete Available Room Configuration
        [Test, Order(1)]
        public void DeleteAvailableRoomConfiguration()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(ConferenceroomTest));
            test = extent.StartTest("ConferenceroomPage", "Check whether available room configuration is deleted successfully");

            LoginPage Objgrm = new LoginPage(driver);
            Objgrm.SetUserName(log, test);
            Objgrm.SetPassword(log, test);
            Objgrm.ClickLoginButton(log, test);

            ConferenceroomPage ConferenceroomObj = new ConferenceroomPage(driver);
            ConferenceroomObj.ClickOnSettingsMenu(log, test);
            ConferenceroomObj.ClickOnConferenceRoomsMenu(log, test);
            ConferenceroomObj.SelectHotelDropdownValue(log, test);

            string Configuration = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 26).ToString();

            ConferenceroomObj.DeleteAvailableRoomConfiguration(log, test, Configuration);
        }
        #endregion        


        [TearDown]
        public void ClosingBrowser()
        {
            CloseBrowser(extent);
        }
    }
}