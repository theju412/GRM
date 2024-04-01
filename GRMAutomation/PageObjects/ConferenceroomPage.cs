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
using System.Threading;

namespace GRMAutomation.PageObjects
{
    class ConferenceroomPage : ScreenCapturer
    {
        #region WebElements

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.SettingsMenu)]
        public IWebElement SettingsMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ConferenceRoomsMenu)]
        public IWebElement ConferenceRoomsMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.SelectHotelDropdown)]
        public IWebElement SelectHotelDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfHotels)]
        public IList<IWebElement> ListOfHotels { get; set; }        

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.SubmitButton)]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.SuccessMessage)]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.OkButton)]
        public IWebElement OkButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.AddMediaButton)]
        public IWebElement AddMediaButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.AddMultipleMediaButton)]
        public IWebElement AddMultipleMediaButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.CloseMediaButton)]
        public IWebElement CloseMediaButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.DeleteConfirmButton)]
        public IWebElement DeleteConfirmButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfMedia)]
        public IList<IWebElement> ListOfMedia { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfDeleteMediaButton)]
        public IList<IWebElement> ListOfDeleteMediaButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.AddMediaShowingAllRecordText)]
        public IWebElement AddMediaShowingAllRecordText { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.SetupHoldShowingAllRecordText)]
        public IWebElement SetupHoldShowingAllRecordText { get; set; }
        
        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.RoomNameRequiredMessage)]
        public IWebElement RoomNameRequiredMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.RoomNameAlreadyExistMessage)]
        public IWebElement RoomNameAlreadyExistMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.MaxAttendeesRequiredMessage)]
        public IWebElement MaxAttendeesRequiredMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.MaxAttendeesValidDataMessage)]
        public IWebElement MaxAttendeesValidDataMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.RoomsPerHoldValidDataMessage)]
        public IWebElement RoomsPerHoldValidDataMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.SetupCostValidDataMessage)]
        public IWebElement SetupCostValidDataMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.SetupCostRequiredMessage)]
        public IWebElement SetupCostRequiredMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.SizeRequiredMessage)]
        public IWebElement SizeRequiredMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.SizeZeroValueMessage)]
        public IWebElement SizeZeroValueMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.SizeValidDataMessage)]
        public IWebElement SizeValidDataMessage { get; set; }

        #region PrimaryRoom
        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.AddPrimaryRoomsButton)]
        public IWebElement AddPrimaryRoomsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.AddMultiplePrimaryRoomsButton)]
        public IWebElement AddMultiplePrimaryRoomsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.PrimaryRoomCancelButton)]
        public IWebElement PrimaryRoomCancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.PrimaryRoomNameField)]
        public IWebElement PrimaryRoomNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.PrimaryRoomDescriptionField)]
        public IWebElement PrimaryRoomDescriptionField { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.PrimaryRoomMaxAttendeesField)]
        public IWebElement PrimaryRoomMaxAttendeesField { get; set; }        

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.PrimaryRoomsPerHoldField)]
        public IWebElement PrimaryRoomsPerHoldField { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.PrimaryRoomSetupCostField)]
        public IWebElement PrimaryRoomSetupCostField { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.PrimaryRoomSizeField)]
        public IWebElement PrimaryRoomSizeField { get; set; }    

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfPrimaryRoomName)]
        public IList<IWebElement> ListOfPrimaryRoomName { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfPrimaryRoomDescription)]
        public IList<IWebElement> ListOfPrimaryRoomDescription { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfPrimaryRoomMaxAttendees)]
        public IList<IWebElement> ListOfPrimaryRoomMaxAttendees { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfPrimaryRoomsPerHold)]
        public IList<IWebElement> ListOfPrimaryRoomsPerHold { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfPrimaryRoomSetUpCost)]
        public IList<IWebElement> ListOfPrimaryRoomSetUpCost { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfPrimaryRoomSize)]
        public IList<IWebElement> ListOfPrimaryRoomSize { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfPrimaryEditButton)]
        public IList<IWebElement> ListOfPrimaryEditButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfEditPrimaryRoomName)]
        public IList<IWebElement> ListOfEditPrimaryRoomName { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfEditPrimaryRoomDescription)]
        public IList<IWebElement> ListOfEditPrimaryRoomDescription { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfEditPrimaryRoomMaxAttendees)]
        public IList<IWebElement> ListOfEditPrimaryRoomMaxAttendees { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfEditPrimaryRoomsPerHold)]
        public IList<IWebElement> ListOfEditPrimaryRoomsPerHold { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfEditPrimaryRoomSetupCost)]
        public IList<IWebElement> ListOfEditPrimaryRoomSetupCost { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfEditPrimaryRoomSize)]
        public IList<IWebElement> ListOfEditPrimaryRoomSize { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfPrimaryAcceptButton)]
        public IList<IWebElement> ListOfPrimaryAcceptButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfPrimaryDeleteButton)]
        public IList<IWebElement> ListOfPrimaryDeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfPrimaryAddMediaIcon)]
        public IList<IWebElement> ListOfPrimaryAddMediaIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.PrimaryRoomShowingAllRecordText)]
        public IWebElement PrimaryRoomShowingAllRecordText { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.PrimaryRoomSingleRightArrow)]
        public IWebElement PrimaryRoomSingleRightArrow { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.PrimaryRoomSingleRightArrowStatus)]
        public IWebElement PrimaryRoomSingleRightArrowStatus { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.PrimaryRoomDoubleLeftArrow)]
        public IWebElement PrimaryRoomDoubleLeftArrow { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.PrimaryRoomDoubleLeftArrowStatus)]
        public IWebElement PrimaryRoomDoubleLeftArrowStatus { get; set; }
        #endregion

        #region BreakoutRooms
        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.AddBreakoutRoomsButton)]
        public IWebElement AddBreakoutRoomsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.AddMultipleBreakoutRoomsButton)]
        public IWebElement AddMultipleBreakoutRoomsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.BreakoutRoomCancelButton)]
        public IWebElement BreakoutRoomCancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.BreakoutRoomNameField)]
        public IWebElement BreakoutRoomNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.BreakoutRoomDescriptionField)]
        public IWebElement BreakoutRoomDescriptionField { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.BreakoutRoomMaxAttendeesField)]
        public IWebElement BreakoutRoomMaxAttendeesField { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.BreakoutRoomsPerHoldField)]
        public IWebElement BreakoutRoomsPerHoldField { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.BreakoutRoomSetupCostField)]
        public IWebElement BreakoutRoomSetupCostField { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.BreakoutRoomSizeField)]
        public IWebElement BreakoutRoomSizeField { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfBreakoutRoomName)]
        public IList<IWebElement> ListOfBreakoutRoomName { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfBreakoutRoomDescription)]
        public IList<IWebElement> ListOfBreakoutRoomDescription { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfBreakoutRoomMaxAttendees)]
        public IList<IWebElement> ListOfBreakoutRoomMaxAttendees { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfBreakoutRoomsPerHold)]
        public IList<IWebElement> ListOfBreakoutRoomsPerHold { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfBreakoutRoomSetUpCost)]
        public IList<IWebElement> ListOfBreakoutRoomSetUpCost { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfBreakoutRoomSize)]
        public IList<IWebElement> ListOfBreakoutRoomSize { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfBreakoutAcceptButton)]
        public IList<IWebElement> ListOfBreakoutAcceptButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfBreakoutDeleteButton)]
        public IList<IWebElement> ListOfBreakoutDeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfBreakoutAddMediaIcon)]
        public IList<IWebElement> ListOfBreakoutAddMediaIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.BreakoutRoomShowingAllRecordText)]
        public IWebElement BreakoutRoomShowingAllRecordText { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.BreakoutRoomSingleRightArrow)]
        public IWebElement BreakoutRoomSingleRightArrow { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.BreakoutRoomSingleRightArrowStatus)]
        public IWebElement BreakoutRoomSingleRightArrowStatus { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.BreakoutRoomDoubleLeftArrow)]
        public IWebElement BreakoutRoomDoubleLeftArrow { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.BreakoutRoomDoubleLeftArrowStatus)]
        public IWebElement BreakoutRoomDoubleLeftArrowStatus { get; set; }
        #endregion

        #region AvailableRoomConfigurations

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.AddAvailableRoomConfigurationsButton)]
        public IWebElement AddAvailableRoomConfigurationsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ConfigurationField)]
        public IWebElement ConfigurationField { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.SqftPerAttendeeField)]
        public IWebElement SqftPerAttendeeField { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.DescriptionField)]
        public IWebElement DescriptionField { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.AvailableRoomConfigurationsAcceptButton)]
        public IWebElement AvailableRoomConfigurationsAcceptButton { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.AddMultipleAvailableRoomConfigurationsButton)]
        public IWebElement AddMultipleAvailableRoomConfigurationsButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfAvailableRoomConfigurations)]
        public IList<IWebElement> ListOfAvailableRoomConfigurations { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfAvailableRoomSqftPerAttendee)]
        public IList<IWebElement> ListOfAvailableRoomSqftPerAttendee { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.ListOfAvailableRoomDescription)]
        public IList<IWebElement> ListOfAvailableRoomDescription { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.RoomConfigurationsSingleRightArrow)]
        public IWebElement RoomConfigurationsSingleRightArrow { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.RoomConfigurationsSingleRightArrowStatus)]
        public IWebElement RoomConfigurationsSingleRightArrowStatus { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.RoomConfigurationsDoubleLeftArrowStatus)]
        public IWebElement RoomConfigurationsDoubleLeftArrowStatus { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.RoomConfigurationsDoubleLeftArrow)]
        public IWebElement RoomConfigurationsDoubleLeftArrow { get; set; }

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.RoomConfigurationsShowingAllRecordText)]
        public IWebElement RoomConfigurationsShowingAllRecordText { get; set; }
        #endregion

        #endregion

        #region Wait Till Load

        [FindsBy(How = How.XPath, Using = ConferenceRoomLocator.WaitTillLoadingWheelAppears)]
        public IWebElement WaitTillLoadingWheelAppears { get; set; }

        #endregion

        #region WaitTillLoading
        public void WaitTillLoading()
        {
            try
            {
                wait = driver.WaitForSpecificElement();
                wait.Until(driver => !driver.FindElement(By.XPath(ConferenceRoomLocator.WaitTillLoadingWheelAppears)).Displayed);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Constructor
        public ConferenceroomPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }
        #endregion

        #region ClickOnSettingsMenu
        public void ClickOnSettingsMenu(ILog log, ExtentTest test)
        {
            Assert.IsTrue(SettingsMenu.Displayed);
            SettingsMenu.ClickOn(driver, 10);
            test.Log(LogStatus.Info, "Clicked on Settings menu");
        }
        #endregion

        #region ClickOnConferenceRoomsMenu
        public void ClickOnConferenceRoomsMenu(ILog log, ExtentTest test)
        {
            Assert.IsTrue(ConferenceRoomsMenu.Displayed);
            ConferenceRoomsMenu.ClickOn(driver, 10);
            test.Log(LogStatus.Info, "Clicked on Conference Room menu");
        }
        #endregion

        #region SelectHotel
        public void SelectHotelDropdownValue(ILog log, ExtentTest test)
        {
            Assert.IsTrue(SelectHotelDropdown.Displayed);
            SelectHotelDropdown.ClickOn(driver, 10);
            test.Log(LogStatus.Info, "Clicked on Select Hotel dropdown");

            string HotelName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", 1, 0).ToString();

            driver.SelectADropDownValue(ListOfHotels, HotelName);

            Assert.AreEqual(HotelName, SelectHotelDropdown.Text);
            test.Log(LogStatus.Info, "Countryard hotel selected");
        }
        #endregion

        #region ClickOnSubmitButton
        public void ClickOnSubmitButton(ILog log, ExtentTest test)
        {
            SubmitButton.WaitForElementContentToLoad(driver, ConferenceRoomLocator.SubmitButton, 60);

            Assert.IsTrue(SubmitButton.Displayed);
            SubmitButton.ClickOn(driver, 60);
            test.Log(LogStatus.Info, "Submit Button is clicked");
        }
        #endregion

        #region ClickOnOkButton

        public void ClickOnOkButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(OkButton.Displayed);
            OkButton.ClickOn(driver, 60);
            test.Log(LogStatus.Info, "Clicked on Ok Button");
        }
        #endregion

        #region ClickOnPrimaryRoomAcceptButton
        public void ClickOnPrimaryRoomAcceptButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(PrimaryRoomAcceptButton.Displayed);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.WaitTillElementToBeClickable(ConferenceRoomLocator.PrimaryRoomAcceptButton, 60);
            js.ExecuteScript("arguments[0].click()", PrimaryRoomAcceptButton);
            test.Log(LogStatus.Info, "Clicked on Add Primary Rooms Accept Button");

        }
        #endregion

        #region ClickOnBreakoutRoomAcceptButton
        public void ClickOnBreakoutRoomAcceptButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(BreakoutRoomAcceptButton.Displayed);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.WaitTillElementToBeClickable(ConferenceRoomLocator.BreakoutRoomAcceptButton, 60);
            js.ExecuteScript("arguments[0].click()", BreakoutRoomAcceptButton);
            test.Log(LogStatus.Info, "Clicked on Add Breakout Rooms Accept Button");

        }
        #endregion


        #region Add Primary Conference Rooms

        #region ClickOnAddPrimaryRoomsButton
        public void ClickOnAddPrimaryRoomsButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(AddPrimaryRoomsButton.Displayed);
            AddPrimaryRoomsButton.ClickOn(driver, 10);
            test.Log(LogStatus.Info, "Clicked on Add primary room button");
        }
        #endregion

        #region ClickOnAddMultiplePrimaryRoomsButton
        public void ClickOnAddMultiplePrimaryRoomsButton(ILog log, ExtentTest test)
        {
            
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.WaitTillElementToBeClickable(ConferenceRoomLocator.AddMultiplePrimaryRoomsButton, 60);
            Assert.IsTrue(AddMultiplePrimaryRoomsButton.Displayed);
            js.ExecuteScript("arguments[0].click()", AddMultiplePrimaryRoomsButton);

            test.Log(LogStatus.Info, "Clicked on Add multiple primary room button");
        }
        #endregion

        public void AddPrimaryConferenceRooms(ILog log, ExtentTest test, string PrimaryRoomName, string PrimaryRoomDescription, string PrimaryRoomMaxAttendees, string PrimaryRoomsPerHold, string PrimaryRoomSetupCost, string PrimaryRoomSize)
        {
            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            PrimaryRoomNameField.EnterValue(PrimaryRoomName);
            test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            Assert.IsTrue(PrimaryRoomDescriptionField.Displayed);
            PrimaryRoomDescriptionField.EnterValue(PrimaryRoomDescription);
            test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

            Assert.IsTrue(PrimaryRoomMaxAttendeesField.Displayed);
            PrimaryRoomMaxAttendeesField.EnterValue(PrimaryRoomMaxAttendees);
            test.Log(LogStatus.Info, "Entered Max attendees :" + PrimaryRoomMaxAttendees);

            Assert.IsTrue(PrimaryRoomsPerHoldField.Displayed);
            PrimaryRoomsPerHoldField.EnterValue(PrimaryRoomsPerHold);
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHold);

            Assert.IsTrue(PrimaryRoomSetupCostField.Displayed);
            PrimaryRoomSetupCostField.EnterValue(PrimaryRoomSetupCost);
            test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCost);

            Assert.IsTrue(PrimaryRoomSizeField.Displayed);
            PrimaryRoomSizeField.EnterValue(PrimaryRoomSize);
            test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSize);

            ClickOnPrimaryRoomAcceptButton(log, test);
            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, SuccessMessage.Text);


            //Verify added Primary Room           
            int flag = 0;
            for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
            {
                if (ListOfPrimaryRoomName[i].Text.Equals(PrimaryRoomName))
                {

                    string Description = ListOfPrimaryRoomDescription[i].Text;
                    string MaxAttendees = ListOfPrimaryRoomMaxAttendees[i].Text;
                    string RoomsPerHold = ListOfPrimaryRoomsPerHold[i].Text;
                    string SetUpCost = ListOfPrimaryRoomSetUpCost[i].Text;
                    string Size = ListOfPrimaryRoomSize[i].Text;

                    Assert.AreEqual(PrimaryRoomDescription, Description);
                    Assert.AreEqual(PrimaryRoomMaxAttendees, MaxAttendees);
                    Assert.AreEqual(PrimaryRoomsPerHold, RoomsPerHold);
                    Assert.AreEqual(PrimaryRoomSetupCost, SetUpCost);
                    Assert.AreEqual(PrimaryRoomSize, Size);
                    flag = 1;

                    break;
                }
                else
                {
                    continue;
                }
            }
            if (flag == 1)
            {
                test.Log(LogStatus.Pass, "Primary Room Verified Successfully!!");
            }
            else
            {
                test.Log(LogStatus.Fail, "Primary Room Verification Failed!!");
                Assert.Fail();
            }

        }

        //Add multiple primary rooms
        public void AddMultiplePrimaryConferenceRoom(ILog log, ExtentTest test)
        {
            int RowCount = ExcelReaderHelper.GetTotalRows(fileLocation, "ConferenceRoom");

            for (int i = 2; i < RowCount; i++)
            {
                String PrimaryRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 1).ToString();
                String PrimaryRoomDescription = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 2).ToString();
                String PrimaryRoomMaxAttendees = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 3).ToString();
                String PrimaryRoomsPerHold = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 4).ToString();
                String PrimaryRoomSetupCost = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 5).ToString();
                String PrimaryRoomSize = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 6).ToString();

                Assert.IsTrue(PrimaryRoomNameField.Displayed);
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("document.getElementById('txtRoomName').value = '" + PrimaryRoomName + "'");
                test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

                Assert.IsTrue(PrimaryRoomDescriptionField.Displayed);
                js.ExecuteScript("document.getElementById('txtPrimaryDesc').value = '" + PrimaryRoomDescription + "'");
                test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

                Assert.IsTrue(PrimaryRoomMaxAttendeesField.Displayed);
                js.ExecuteScript("document.getElementById('txtMaxAttendees').value = '" + PrimaryRoomMaxAttendees + "'");
                test.Log(LogStatus.Info, "Entered Max attendees :" + PrimaryRoomMaxAttendees);

                Assert.IsTrue(PrimaryRoomsPerHoldField.Displayed);
                js.ExecuteScript("document.getElementById('txtRoomsRequired').value = '" + PrimaryRoomsPerHold + "'");
                test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHold);

                Assert.IsTrue(PrimaryRoomSetupCostField.Displayed);
                js.ExecuteScript("document.getElementById('txtSetupCost').value = '" + PrimaryRoomSetupCost + "'");
                test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCost);

                Assert.IsTrue(PrimaryRoomSizeField.Displayed);
                js.ExecuteScript("document.getElementById('txtSize').value = '" + PrimaryRoomSize + "'");
                test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSize);

                ClickOnPrimaryRoomAcceptButton(log, test);
                ClickOnAddMultiplePrimaryRoomsButton(log, test);
            }
        }

        #region SubmitMultiplePrimaryRooms
        public void SubmitMultiplePrimaryRooms(ILog log, ExtentTest test)
        {
            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, SuccessMessage.Text);
        }
        #endregion

        public void VerifyMultiplePrimaryRooms(ILog log, ExtentTest test, string PrimaryRoomName1, string PrimaryRoomDescription1, string PrimaryRoomMaxAttendees1, string PrimaryRoomsPerHold1, string PrimaryRoomSetupCost1, string PrimaryRoomSize1)
        {
            int flag = 0;
            do
            {
                for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
                {
                    if (ListOfPrimaryRoomName[i].Text.Equals(PrimaryRoomName1))
                    {
                        string Description = ListOfPrimaryRoomDescription[i].Text;
                        string MaxAttendees = ListOfPrimaryRoomMaxAttendees[i].Text;
                        string RoomsPerHold = ListOfPrimaryRoomsPerHold[i].Text;
                        string SetUpCost = ListOfPrimaryRoomSetUpCost[i].Text;
                        string Size = ListOfPrimaryRoomSize[i].Text;

                        Assert.AreEqual(PrimaryRoomDescription1, Description);
                        Assert.AreEqual(PrimaryRoomMaxAttendees1, MaxAttendees);
                        Assert.AreEqual(PrimaryRoomsPerHold1, RoomsPerHold);
                        Assert.AreEqual(PrimaryRoomSetupCost1, SetUpCost);
                        Assert.AreEqual(PrimaryRoomSize1, Size);
                        
                        flag = 1;

                        if (PrimaryRoomDoubleLeftArrowStatus.GetAttribute("class").Equals("paginate_button first"))
                        {
                            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                            driver.WaitTillElementToBeClickable(ConferenceRoomLocator.PrimaryRoomDoubleLeftArrow, 60);
                            js.ExecuteScript("arguments[0].click()", PrimaryRoomDoubleLeftArrow);
                            PrimaryRoomShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.PrimaryRoomShowingAllRecordText, 60);
                        }

                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (PrimaryRoomSingleRightArrowStatus.GetAttribute("class").Equals("paginate_button next disabled") || flag == 1)
                {
                    break;
                }
                else
                {
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.PrimaryRoomSingleRightArrow, 60);
                    js.ExecuteScript("arguments[0].click()", PrimaryRoomSingleRightArrow);
                    PrimaryRoomShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.PrimaryRoomShowingAllRecordText, 60);
                }
            } while (PrimaryRoomSingleRightArrowStatus.GetAttribute("class").Equals("paginate_button next disabled") || PrimaryRoomSingleRightArrowStatus.GetAttribute("class").Equals("paginate_button next"));

            if (flag == 1)
            {
                test.Log(LogStatus.Pass, "Primary Room " + PrimaryRoomName1 + " Verified Successfully!!");
            }
            else
            {
                test.Log(LogStatus.Fail, "Primary Room " + PrimaryRoomName1 + " Verification Failed!!");
                Assert.Fail();
            }
        }
        #endregion


        #region Primary Conference Room Field Validations 

        #region ClickOnPrimaryRoomCancelButton
        public void ClickOnPrimaryRoomCancelButton(ILog log, ExtentTest test)
        {
            PrimaryRoomCancelButton.WaitForElementContentToLoad(driver, ConferenceRoomLocator.PrimaryRoomCancelButton, 60);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.WaitTillElementToBeClickable(ConferenceRoomLocator.PrimaryRoomCancelButton, 60);
            Assert.IsTrue(PrimaryRoomCancelButton.Displayed);
            js.ExecuteScript("arguments[0].click()", PrimaryRoomCancelButton);
            test.Log(LogStatus.Info, "Clicked on Cancel Button");
        }
        #endregion

        #region Primary Room Name Field Validation

        public void PrimaryRoomNameFieldValidation(ILog log, ExtentTest test, string ExistingPrimaryRoomName, string PrimaryRoomName)
        {
            ClickOnPrimaryRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);
            
            Assert.IsTrue(RoomNameRequiredMessage.Displayed);
            test.Log(LogStatus.Pass, "Primary Room Name Required Validation Message displayed : " + RoomNameRequiredMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnPrimaryRoomCancelButton(log, test);

            ClickOnAddMultiplePrimaryRoomsButton(log, test);

            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            PrimaryRoomNameField.EnterValue(ExistingPrimaryRoomName);
            test.Log(LogStatus.Info, "Entered Room Name :" + ExistingPrimaryRoomName);

            ClickOnPrimaryRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(RoomNameAlreadyExistMessage.Displayed);
            test.Log(LogStatus.Pass, "Primary Room Name Already Exist Validation Message displayed : " + RoomNameAlreadyExistMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnPrimaryRoomCancelButton(log, test);

            //Add valid room name & click on accept
            //ClickOnAddMultiplePrimaryRoomsButton(log, test);

            //Assert.IsTrue(PrimaryRoomNameField.Displayed);
            //PrimaryRoomNameField.EnterValue(PrimaryRoomName);
            //test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            //ClickOnPrimaryRoomAcceptButton(log, test);

            //OkButton.WaitTillElementToBeClickable(driver, 60);

            //Assert.IsTrue(SizeRequiredMessage.Displayed);
            //test.Log(LogStatus.Pass, "Please Enter a valid value for Size : " + SizeRequiredMessage.Text);

            //ClickOnOkButton(log, test);
            //ClickOnPrimaryRoomCancelButton(log, test);
        }
        #endregion

        #region Primary Room Description field Validation

        public void PrimaryRoomDescriptionFieldValidation(ILog log, ExtentTest test, string PrimaryRoomName, string PrimaryRoomMaxAttendees, string PrimaryRoomsPerHold, string PrimaryRoomSetupCost, string PrimaryRoomSize)
        {

            ClickOnAddMultiplePrimaryRoomsButton(log, test);

            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            PrimaryRoomNameField.EnterValue(PrimaryRoomName);
            test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            Assert.IsTrue(PrimaryRoomMaxAttendeesField.Displayed);
            PrimaryRoomMaxAttendeesField.EnterValue(PrimaryRoomMaxAttendees);
            test.Log(LogStatus.Info, "Entered Max attendees :" + PrimaryRoomMaxAttendees);

            Assert.IsTrue(PrimaryRoomsPerHoldField.Displayed);
            PrimaryRoomsPerHoldField.EnterValue(PrimaryRoomsPerHold);
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHold);

            Assert.IsTrue(PrimaryRoomSetupCostField.Displayed);
            PrimaryRoomSetupCostField.EnterValue(PrimaryRoomSetupCost);
            test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCost);

            Assert.IsTrue(PrimaryRoomSizeField.Displayed);
            PrimaryRoomSizeField.EnterValue(PrimaryRoomSize);
            test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSize);

            ClickOnPrimaryRoomAcceptButton(log, test);

            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            SetupHoldShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.SetupHoldShowingAllRecordText, 60);

            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, "Primary Room Description field is not mandatory");

            //delete added room
            for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
            {
                if (ListOfPrimaryRoomName[i].Text.Equals(PrimaryRoomName))
                {

                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    driver.WaitTillElementToBeClickable(ListOfPrimaryDeleteButton[i], 60);
                    js.ExecuteScript("arguments[0].click()", ListOfPrimaryDeleteButton[i]);
                    test.Log(LogStatus.Info, "Clicked on Delete Primary room button");

                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.SubmitButton, 60);
                    js.ExecuteScript("arguments[0].click()", SubmitButton);
                    test.Log(LogStatus.Info, "Clicked on Submit button");

                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        #endregion

        #region Primary Room Max Attendees field Validation

        public void PrimaryRoomMaxAttendeesFieldValidation(ILog log, ExtentTest test, string PrimaryRoomName, string PrimaryRoomDescription, string PrimaryRoomMaxAttendeesNull, string PrimaryRoomMaxAttendeesInavlidData, string PrimaryRoomMaxAttendees, string PrimaryRoomsPerHold, string PrimaryRoomSetupCost, string PrimaryRoomSize)
        {

            //Max Attendees required validation
            
            ClickOnAddMultiplePrimaryRoomsButton(log, test);

            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('txtRoomName').value = '" + PrimaryRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            Assert.IsTrue(PrimaryRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtPrimaryDesc').value = '" + PrimaryRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

            Assert.IsTrue(PrimaryRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomsRequired').value = '" + PrimaryRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHold);

            Assert.IsTrue(PrimaryRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtSetupCost').value = '" + PrimaryRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCost);

            Assert.IsTrue(PrimaryRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtSize').value = '" + PrimaryRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSize);

            ClickOnPrimaryRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(MaxAttendeesRequiredMessage.Displayed);
            test.Log(LogStatus.Pass, "Primary Room Max Attendees Required Validation Message displayed : " + MaxAttendeesRequiredMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnPrimaryRoomCancelButton(log, test);


            //Max Attendees valid data validation
            ClickOnAddMultiplePrimaryRoomsButton(log, test);
            test.Log(LogStatus.Info, "Clicked on Add Primary Rooms Button");

            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomName').value = '" + PrimaryRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            Assert.IsTrue(PrimaryRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtPrimaryDesc').value = '" + PrimaryRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

            Assert.IsTrue(PrimaryRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtMaxAttendees').value = '" + PrimaryRoomMaxAttendeesInavlidData + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + PrimaryRoomMaxAttendeesInavlidData);

            Assert.IsTrue(PrimaryRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomsRequired').value = '" + PrimaryRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHold);

            Assert.IsTrue(PrimaryRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtSetupCost').value = '" + PrimaryRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCost);

            Assert.IsTrue(PrimaryRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtSize').value = '" + PrimaryRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSize);

            ClickOnPrimaryRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(MaxAttendeesValidDataMessage.Displayed);
            test.Log(LogStatus.Pass, "Primary Room Max Attendees Valid data Validation Message displayed : " + MaxAttendeesValidDataMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnPrimaryRoomCancelButton(log, test);


            //Max Attendees null validation
            ClickOnAddMultiplePrimaryRoomsButton(log, test);

            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomName').value = '" + PrimaryRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            Assert.IsTrue(PrimaryRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtPrimaryDesc').value = '" + PrimaryRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

            Assert.IsTrue(PrimaryRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtMaxAttendees').value = '" + PrimaryRoomMaxAttendeesNull + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + PrimaryRoomMaxAttendeesNull);

            Assert.IsTrue(PrimaryRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomsRequired').value = '" + PrimaryRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHold);

            Assert.IsTrue(PrimaryRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtSetupCost').value = '" + PrimaryRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCost);

            Assert.IsTrue(PrimaryRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtSize').value = '" + PrimaryRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSize);

            ClickOnPrimaryRoomAcceptButton(log, test);
            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            SetupHoldShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.SetupHoldShowingAllRecordText, 60);

            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, SuccessMessage.Text);
            test.Log(LogStatus.Pass, "Primary Room Max Attendees field accept Zero value");

            //delete added room

            for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
            {
                if (ListOfPrimaryRoomName[i].Text.Equals(PrimaryRoomName))
                {

                    driver.WaitTillElementToBeClickable(ListOfPrimaryDeleteButton[i], 60);
                    js.ExecuteScript("arguments[0].click()", ListOfPrimaryDeleteButton[i]);
                    test.Log(LogStatus.Info, "Clicked on Delete Primary room button");

                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.SubmitButton, 60);
                    js.ExecuteScript("arguments[0].click()", SubmitButton);
                    test.Log(LogStatus.Info, "Clicked on Submit button");

                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        #endregion

        #region Primary Rooms Per Hold field Validation
        public void PrimaryRoomsPerHoldFieldValidation(ILog log, ExtentTest test, string PrimaryRoomName, string PrimaryRoomDescription, string PrimaryRoomMaxAttendees, string PrimaryRoomsPerHoldInvalidData, string PrimaryRoomsPerHold, string PrimaryRoomSetupCost, string PrimaryRoomSize)
        {

            //Rooms per hold valid data validation

            ClickOnAddMultiplePrimaryRoomsButton(log, test);
            test.Log(LogStatus.Info, "Clicked on Add Primary Rooms Button");

            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('txtRoomName').value = '" + PrimaryRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            Assert.IsTrue(PrimaryRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtPrimaryDesc').value = '" + PrimaryRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

            Assert.IsTrue(PrimaryRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtMaxAttendees').value = '" + PrimaryRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + PrimaryRoomMaxAttendees);

            Assert.IsTrue(PrimaryRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomsRequired').value = '" + PrimaryRoomsPerHoldInvalidData + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHoldInvalidData);

            Assert.IsTrue(PrimaryRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtSetupCost').value = '" + PrimaryRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCost);

            Assert.IsTrue(PrimaryRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtSize').value = '" + PrimaryRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSize);

            ClickOnPrimaryRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(RoomsPerHoldValidDataMessage.Displayed);
            test.Log(LogStatus.Pass, "Primary Rooms per hold Valid data Validation Message displayed : " + RoomsPerHoldValidDataMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnPrimaryRoomCancelButton(log, test);


            //Rooms per hold accept zero validation
            ClickOnAddMultiplePrimaryRoomsButton(log, test);

            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomName').value = '" + PrimaryRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            Assert.IsTrue(PrimaryRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtPrimaryDesc').value = '" + PrimaryRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

            Assert.IsTrue(PrimaryRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtMaxAttendees').value = '" + PrimaryRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + PrimaryRoomMaxAttendees);

            
            Assert.AreEqual("0", PrimaryRoomsPerHoldField.GetAttribute("value"), "0 Value is not present in Rooms per hold field");

            Assert.IsTrue(PrimaryRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtSetupCost').value = '" + PrimaryRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCost);

            Assert.IsTrue(PrimaryRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtSize').value = '" + PrimaryRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSize);

            ClickOnPrimaryRoomAcceptButton(log, test);

            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            SetupHoldShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.SetupHoldShowingAllRecordText, 60);

            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, SuccessMessage.Text);
            test.Log(LogStatus.Pass, "Primary Rooms Per Hold field accept Zero value");

            //delete added room

            for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
            {
                if (ListOfPrimaryRoomName[i].Text.Equals(PrimaryRoomName))
                {

                    driver.WaitTillElementToBeClickable(ListOfPrimaryDeleteButton[i], 60);
                    js.ExecuteScript("arguments[0].click()", ListOfPrimaryDeleteButton[i]);
                    test.Log(LogStatus.Info, "Clicked on Delete Primary room button");

                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.SubmitButton, 60);
                    js.ExecuteScript("arguments[0].click()", SubmitButton);
                    test.Log(LogStatus.Info, "Clicked on Submit button");

                    WaitTillLoading();
                    SetupHoldShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.SetupHoldShowingAllRecordText, 60);
                    Assert.IsTrue(SuccessMessage.Displayed);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        #endregion

        #region Primary Room Setup Cost field Validation
        public void PrimaryRoomSetupCostFieldValidation(ILog log, ExtentTest test, string PrimaryRoomName, string PrimaryRoomDescription, string PrimaryRoomMaxAttendees, string PrimaryRoomsPerHold, string PrimaryRoomSetupCostNull, string PrimaryRoomSetupCostInvalidData, string PrimaryRoomSetupCost, string PrimaryRoomSize)
        {

            //Setup Cost required validation
            SetupHoldShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.SetupHoldShowingAllRecordText, 60);

            ClickOnAddMultiplePrimaryRoomsButton(log, test);

            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('txtRoomName').value = '" + PrimaryRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            Assert.IsTrue(PrimaryRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtPrimaryDesc').value = '" + PrimaryRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

            Assert.IsTrue(PrimaryRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtMaxAttendees').value = '" + PrimaryRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + PrimaryRoomMaxAttendees);

            Assert.IsTrue(PrimaryRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomsRequired').value = '" + PrimaryRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHold);

            Assert.IsTrue(PrimaryRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtSize').value = '" + PrimaryRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSize);

            ClickOnPrimaryRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(SetupCostRequiredMessage.Displayed);
            test.Log(LogStatus.Pass, "Primary Room Setup Cost Required Validation Message displayed : " + SetupCostRequiredMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnPrimaryRoomCancelButton(log, test);


            //Setup cost valid data validation
            ClickOnAddMultiplePrimaryRoomsButton(log, test);
            test.Log(LogStatus.Info, "Clicked on Add Primary Rooms Button");

            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomName').value = '" + PrimaryRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            Assert.IsTrue(PrimaryRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtPrimaryDesc').value = '" + PrimaryRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

            Assert.IsTrue(PrimaryRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtMaxAttendees').value = '" + PrimaryRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + PrimaryRoomMaxAttendees);

            Assert.IsTrue(PrimaryRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomsRequired').value = '" + PrimaryRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHold);

            Assert.IsTrue(PrimaryRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtSetupCost').value = '" + PrimaryRoomSetupCostInvalidData + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCostInvalidData);

            Assert.IsTrue(PrimaryRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtSize').value = '" + PrimaryRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSize);

            ClickOnPrimaryRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(SetupCostValidDataMessage.Displayed);
            test.Log(LogStatus.Pass, "Primary Room Setup cost Valid data Validation Message displayed : " + SetupCostValidDataMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnPrimaryRoomCancelButton(log, test);


            //Setup Cost field accept zero validation
            ClickOnAddMultiplePrimaryRoomsButton(log, test);

            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomName').value = '" + PrimaryRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            Assert.IsTrue(PrimaryRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtPrimaryDesc').value = '" + PrimaryRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

            Assert.IsTrue(PrimaryRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtMaxAttendees').value = '" + PrimaryRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + PrimaryRoomMaxAttendees);

            Assert.IsTrue(PrimaryRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomsRequired').value = '" + PrimaryRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHold);

            Assert.IsTrue(PrimaryRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtSetupCost').value = '" + PrimaryRoomSetupCostNull + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCostNull);

            Assert.IsTrue(PrimaryRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtSize').value = '" + PrimaryRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSize);

            ClickOnPrimaryRoomAcceptButton(log, test);
            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            SetupHoldShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.SetupHoldShowingAllRecordText, 60);

            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, SuccessMessage.Text);
            test.Log(LogStatus.Pass, "Primary Room Setup Cost field accept Zero value");

            //delete added room

            for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
            {
                if (ListOfPrimaryRoomName[i].Text.Equals(PrimaryRoomName))
                {

                    driver.WaitTillElementToBeClickable(ListOfPrimaryDeleteButton[i], 60);
                    js.ExecuteScript("arguments[0].click()", ListOfPrimaryDeleteButton[i]);
                    test.Log(LogStatus.Info, "Clicked on Delete Primary room button");

                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.SubmitButton, 60);
                    js.ExecuteScript("arguments[0].click()", SubmitButton);
                    test.Log(LogStatus.Info, "Clicked on Submit button");

                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        #endregion

        #region Primary Room Size field Validation
        public void PrimaryRoomSizeFieldValidation(ILog log, ExtentTest test, string PrimaryRoomName, string PrimaryRoomDescription, string PrimaryRoomMaxAttendees, string PrimaryRoomsPerHold, string PrimaryRoomSetupCost, string PrimaryRoomSizeNull, string PrimaryRoomSizeInvalidData, string PrimaryRoomSize)
        {

            //Size required validation

            ClickOnAddMultiplePrimaryRoomsButton(log, test);

            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('txtRoomName').value = '" + PrimaryRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            Assert.IsTrue(PrimaryRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtPrimaryDesc').value = '" + PrimaryRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

            Assert.IsTrue(PrimaryRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtMaxAttendees').value = '" + PrimaryRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + PrimaryRoomMaxAttendees);

            Assert.IsTrue(PrimaryRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomsRequired').value = '" + PrimaryRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHold);

            Assert.IsTrue(PrimaryRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtSetupCost').value = '" + PrimaryRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCost);

            ClickOnPrimaryRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(SizeRequiredMessage.Displayed);
            test.Log(LogStatus.Pass, "Primary Room Size Required Validation Message displayed : " + SizeRequiredMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnPrimaryRoomCancelButton(log, test);

            //Size field shouldn't be zero validation
            ClickOnAddMultiplePrimaryRoomsButton(log, test);

            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomName').value = '" + PrimaryRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            Assert.IsTrue(PrimaryRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtPrimaryDesc').value = '" + PrimaryRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

            Assert.IsTrue(PrimaryRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtMaxAttendees').value = '" + PrimaryRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + PrimaryRoomMaxAttendees);

            Assert.IsTrue(PrimaryRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomsRequired').value = '" + PrimaryRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHold);

            Assert.IsTrue(PrimaryRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtSetupCost').value = '" + PrimaryRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCost);

            Assert.IsTrue(PrimaryRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtSize').value = '" + PrimaryRoomSizeNull + "'");
            test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSizeNull);

            ClickOnPrimaryRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(SizeZeroValueMessage.Displayed);
            test.Log(LogStatus.Pass, "Primary Room Size shouldn't be zero Validation Message displayed : " + SizeZeroValueMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnPrimaryRoomCancelButton(log, test);


            //Size valid data validation
            ClickOnAddMultiplePrimaryRoomsButton(log, test);
            test.Log(LogStatus.Info, "Clicked on Add Primary Rooms Button");

            Assert.IsTrue(PrimaryRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomName').value = '" + PrimaryRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

            Assert.IsTrue(PrimaryRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtPrimaryDesc').value = '" + PrimaryRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

            Assert.IsTrue(PrimaryRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtMaxAttendees').value = '" + PrimaryRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + PrimaryRoomMaxAttendees);

            Assert.IsTrue(PrimaryRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtRoomsRequired').value = '" + PrimaryRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHold);

            Assert.IsTrue(PrimaryRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtSetupCost').value = '" + PrimaryRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCost);

            Assert.IsTrue(PrimaryRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtSize').value = '" + PrimaryRoomSizeInvalidData + "'");
            test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSizeInvalidData);

            ClickOnPrimaryRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(SizeValidDataMessage.Displayed);
            test.Log(LogStatus.Pass, "Primary Room Setup cost Valid data Validation Message displayed : " + SizeValidDataMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnPrimaryRoomCancelButton(log, test);
        }
        #endregion

        public void PrimaryConferenceRoomFieldValidations(ILog log, ExtentTest test, string ExistingPrimaryRoomName, string PrimaryRoomName, string PrimaryRoomDescription, string PrimaryRoomMaxAttendeesNull, string PrimaryRoomMaxAttendeesInavlidData, string PrimaryRoomMaxAttendees, string PrimaryRoomsPerHoldInvalidData, string PrimaryRoomsPerHold, string PrimaryRoomSetupCostNull, string PrimaryRoomSetupCostInvalidData, string PrimaryRoomSetupCost, string PrimaryRoomSizeNull, string PrimaryRoomSizeInvalidData, string PrimaryRoomSize)
        {
                                                                                    
            PrimaryRoomNameFieldValidation(log, test, ExistingPrimaryRoomName, PrimaryRoomName);

            PrimaryRoomDescriptionFieldValidation(log, test, PrimaryRoomName, PrimaryRoomMaxAttendees, PrimaryRoomsPerHold, PrimaryRoomSetupCost, PrimaryRoomSize);

            PrimaryRoomMaxAttendeesFieldValidation(log, test, PrimaryRoomName, PrimaryRoomDescription, PrimaryRoomMaxAttendeesNull, PrimaryRoomMaxAttendeesInavlidData, PrimaryRoomMaxAttendees, PrimaryRoomsPerHold, PrimaryRoomSetupCost, PrimaryRoomSize);

            PrimaryRoomsPerHoldFieldValidation(log, test, PrimaryRoomName, PrimaryRoomDescription, PrimaryRoomMaxAttendees, PrimaryRoomsPerHoldInvalidData, PrimaryRoomsPerHold, PrimaryRoomSetupCost, PrimaryRoomSize);

            PrimaryRoomSetupCostFieldValidation(log, test, PrimaryRoomName, PrimaryRoomDescription, PrimaryRoomMaxAttendees, PrimaryRoomsPerHold, PrimaryRoomSetupCostNull, PrimaryRoomSetupCostInvalidData, PrimaryRoomSetupCost, PrimaryRoomSize);

            PrimaryRoomSizeFieldValidation(log, test, PrimaryRoomName, PrimaryRoomDescription, PrimaryRoomMaxAttendees, PrimaryRoomsPerHold, PrimaryRoomSetupCost, PrimaryRoomSizeNull, PrimaryRoomSizeInvalidData, PrimaryRoomSize); 
        }

        #endregion


        #region Edit Primary Conference Room
        public void EditPrimaryConferenceRoom(ILog log, ExtentTest test, string ExistingPrimaryRoomName, string PrimaryRoomName, string PrimaryRoomDescription, string PrimaryRoomMaxAttendees, string PrimaryRoomsPerHold, string PrimaryRoomSetupCost, string PrimaryRoomSize)
        {
            int flag1 = 0;
            for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
            {
                if (ListOfPrimaryRoomName[i].Text.Equals(ExistingPrimaryRoomName))
                {

                    ListOfPrimaryEditButton[i].Click();
                    
                    Assert.IsTrue(ListOfEditPrimaryRoomName[i].Displayed);
                    ListOfEditPrimaryRoomName[i].EnterValue(PrimaryRoomName);
                    test.Log(LogStatus.Info, "Entered Room Name :" + PrimaryRoomName);

                    Assert.IsTrue(ListOfEditPrimaryRoomDescription[i].Displayed);
                    ListOfEditPrimaryRoomDescription[i].EnterValue(PrimaryRoomDescription);
                    test.Log(LogStatus.Info, "Entered Description :" + PrimaryRoomDescription);

                    Assert.IsTrue(ListOfEditPrimaryRoomMaxAttendees[i].Displayed);
                    ListOfEditPrimaryRoomMaxAttendees[i].EnterValue(PrimaryRoomMaxAttendees);
                    test.Log(LogStatus.Info, "Entered Max attendees : " + PrimaryRoomMaxAttendees);

                    Assert.IsTrue(ListOfEditPrimaryRoomsPerHold[i].Displayed);
                    ListOfEditPrimaryRoomsPerHold[i].EnterValue(PrimaryRoomsPerHold);
                    test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + PrimaryRoomsPerHold);

                    Assert.IsTrue(ListOfEditPrimaryRoomSetupCost[i].Displayed);
                    ListOfEditPrimaryRoomSetupCost[i].EnterValue(PrimaryRoomSetupCost);
                    test.Log(LogStatus.Info, "Entered Setup Cost :" + PrimaryRoomSetupCost);

                    Assert.IsTrue(ListOfEditPrimaryRoomSize[i].Displayed);
                    ListOfEditPrimaryRoomSize[i].EnterValue(PrimaryRoomSize);
                    test.Log(LogStatus.Info, "Entered Size :" + PrimaryRoomSize);
                   
                    //driver.WaitTillElementToBeClickable(ConferenceRoomLocator.ListOfPrimaryAcceptButton, 60);
                    ListOfPrimaryAcceptButton[i].Click();
                    ClickOnSubmitButton(log, test);
                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    test.Log(LogStatus.Pass, SuccessMessage.Text);
                    flag1 = 1;
                    break;
                }
            }

            //Verify updated primary room
            if (flag1 == 1)
            {
                int flag = 0;
                for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
                {
                    if (ListOfPrimaryRoomName[i].Text.Equals(PrimaryRoomName))
                    {
                        string Description = ListOfPrimaryRoomDescription[i].Text;
                        string MaxAttendees = ListOfPrimaryRoomMaxAttendees[i].Text;
                        string RoomsPerHold = ListOfPrimaryRoomsPerHold[i].Text;
                        string SetUpCost = ListOfPrimaryRoomSetUpCost[i].Text;
                        string Size = ListOfPrimaryRoomSize[i].Text;

                        Assert.AreEqual(PrimaryRoomDescription, Description);
                        Assert.AreEqual(PrimaryRoomMaxAttendees, MaxAttendees);
                        Assert.AreEqual(PrimaryRoomsPerHold, RoomsPerHold);
                        Assert.AreEqual(PrimaryRoomSetupCost, SetUpCost);
                        Assert.AreEqual(PrimaryRoomSize, Size);
                        
                        flag = 1;

                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (flag == 1)
                {
                    test.Log(LogStatus.Pass, "Updated Primary Room Verified Successfully!!");
                }
                else
                {
                    test.Log(LogStatus.Fail, "Updated Primary Room Verification Failed!!");
                    Assert.Fail();
                }
            }
            else
            {
                test.Log(LogStatus.Fail, ExistingPrimaryRoomName + "is not Present in Primary Room List");
            }

        }
        #endregion


        #region Add Media for primary conference room

        #region ClickOnAddMultipleMediaButton
        public void ClickOnAddMultipleMediaButton(ILog log, ExtentTest test)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.WaitTillElementToBeClickable(ConferenceRoomLocator.AddMultipleMediaButton, 60);
            Assert.IsTrue(AddMultipleMediaButton.Displayed);
            js.ExecuteScript("arguments[0].click()", AddMultipleMediaButton);

            test.Log(LogStatus.Info, "Clicked on Add Multiple Media button");
        }
        #endregion

        #region ClickOnCloseMediaButton
        public void ClickOnCloseMediaButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(CloseMediaButton.Displayed);
            CloseMediaButton.ClickOn(driver, 10);
            test.Log(LogStatus.Info, "Clicked on Close Media button");
        }
        #endregion

        public void AddMediaForPrimaryConferenceRoom(ILog log, ExtentTest test, string PrimaryRoomName, string PrimaryMediaName)
        {
            int flag = 0;

            for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
            {
                if (ListOfPrimaryRoomName[i].Text.Equals(PrimaryRoomName))
                {

                    PrimaryRoomShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.PrimaryRoomShowingAllRecordText, 60);

                    ListOfPrimaryAddMediaIcon[i].Click();
                    test.Log(LogStatus.Info, "Add media icon clicked");

                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.AddMediaButton, 60);

                    CustomMethods.UploadFileWithSendKeys(Image1FileLocation, 1, AddMediaButton);
                    WaitTillLoading();
                    test.Log(LogStatus.Info, "First Image Uploaded");

                    CustomMethods.UploadFileWithSendKeys(Image2FileLocation, 1, AddMultipleMediaButton);
                    WaitTillLoading();
                    test.Log(LogStatus.Info, "Second Image Uploaded");

                    ClickOnCloseMediaButton(log, test);

                    wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(ConferenceRoomLocator.SubmitButton)));
          
                    ClickOnSubmitButton(log, test);
                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    test.Log(LogStatus.Pass, SuccessMessage.Text);
                    flag = 1;

                    break;
                }
                else
                {
                    continue;
                }

            }
            if (flag == 1)
            {

                VerifyAddedPrimaryMedia(log, test, PrimaryRoomName, PrimaryMediaName);
            }
            else
            {
                test.Log(LogStatus.Fail, "Failed to add media");
                Assert.Fail();
            }
        }

       //Verify Media is added  
        public void VerifyAddedPrimaryMedia(ILog log, ExtentTest test, string PrimaryRoomName, string PrimaryMediaName)
        {
            int flag = 0;
            int flag1 = 0;
            for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
            {
                if (ListOfPrimaryRoomName[i].Text.Equals(PrimaryRoomName))
                {
                    flag = 1;
                    
                    PrimaryRoomShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.PrimaryRoomShowingAllRecordText, 60);

                    ListOfPrimaryAddMediaIcon[i].WaitTillElementToBeClickable(driver, 60);

                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    js.ExecuteScript("arguments[0].click()", ListOfPrimaryAddMediaIcon[i]);
                    test.Log(LogStatus.Info, "Add media icon clicked");

                    AddMediaShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.AddMediaShowingAllRecordText, 60);
                    
                    for (int j = 0; j < ListOfMedia.Count; j++)
                    {
                        if (ListOfMedia[j].Text.Contains(PrimaryMediaName))
                        {

                            flag1 = 1;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if (flag == 1)
                {
                    break;
                }
            }
            if (flag1 == 1)
            {
                test.Log(LogStatus.Pass, "Added media Verfied Successfully!!");
            }
            else
            {
                test.Log(LogStatus.Fail, "Added Media Verfication Failed!! ");
                Assert.Fail();
            }
        }
        #endregion


        #region Delete added primary room media

        #region ClickOnDeleteConfirmButton
        public void ClickOnDeleteConfirmButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(DeleteConfirmButton.Displayed);
            DeleteConfirmButton.ClickOn(driver, 60);
            test.Log(LogStatus.Info, "Clicked on delete Media confirm button");
        }
        #endregion
        public void DeleteAddedPrimaryRoomMedia(ILog log, ExtentTest test, string PrimaryRoomName, string PrimaryMediaName)
        {
            int flag = 0;
            for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
            {
                if (ListOfPrimaryRoomName[i].Text.Equals(PrimaryRoomName))
                {

                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.ListOfPrimaryAddMediaIcon, 60);
                    js.ExecuteScript("arguments[0].click()", ListOfPrimaryAddMediaIcon[i]);
                    test.Log(LogStatus.Info, "Add media icon clicked");

                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(ConferenceRoomLocator.AddMediaShowingAllRecordText)));

                    for (int j = 0; j < ListOfMedia.Count; j++)
                    {
                        if (ListOfMedia[j].Text.Contains(PrimaryMediaName))
                        {

                            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(ConferenceRoomLocator.ListOfDeleteMediaButton)));
                            ListOfDeleteMediaButton[i].Click();
                            test.Log(LogStatus.Info, "Delete media button clicked");

                            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(ConferenceRoomLocator.DeleteConfirmButton)));
                            ClickOnDeleteConfirmButton(log, test);
                            ClickOnCloseMediaButton(log, test);

                            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(ConferenceRoomLocator.SubmitButton)));
                            ClickOnSubmitButton(log, test);
                            WaitTillLoading();
                            Assert.IsTrue(SuccessMessage.Displayed);
                            test.Log(LogStatus.Pass, SuccessMessage.Text);
                            flag = 1;
                            break;
                        }
                        else
                        {
                            continue;
                        }

                    }
                    if (flag == 1)
                    {

                        VerifyPrimaryMediaDeleted(log, test, PrimaryRoomName, PrimaryMediaName);
                    }
                    else
                    {
                        test.Log(LogStatus.Fail, "Failed to delete media");
                        Assert.Fail();
                    }
                }
            }
        }

        //Verify Media is deleted

        public void VerifyPrimaryMediaDeleted(ILog log, ExtentTest test, string PrimaryRoomName, string PrimaryMediaName)
        {
            int flag = 0;
            int flag1 = 0;
            for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
            {
                if (ListOfPrimaryRoomName[i].Text.Equals(PrimaryRoomName))
                {
                    flag = 1;

                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.ListOfPrimaryAddMediaIcon, 60);
                    js.ExecuteScript("arguments[0].click()", ListOfPrimaryAddMediaIcon[i]);
                    test.Log(LogStatus.Info, "Add media icon clicked");

                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(ConferenceRoomLocator.AddMediaShowingAllRecordText)));

                    for (int j = 0; j < ListOfMedia.Count; j++)
                    {
                        if (ListOfMedia[j].Text.Contains(PrimaryMediaName))
                        {

                            flag1 = 1;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if (flag == 1)
                {
                    break;
                }
            }
            if (flag1 == 1)
            {
                test.Log(LogStatus.Fail, "Deleted media verification failed!!");
                Assert.Fail();
            }
            else
            {
                test.Log(LogStatus.Pass, "Deleted media verified successfully!!");

            }
        }
        #endregion


        #region Delete Primary Conference Room
        public void DeletePrimaryConferenceRoom(ILog log, ExtentTest test, string PrimaryRoomName)
        {
            int flag2 = 0;

            for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
            {
                if (ListOfPrimaryRoomName[i].Text.Equals(PrimaryRoomName))
                {

                    ListOfPrimaryDeleteButton[i].Click();

                    ClickOnSubmitButton(log, test);
                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    test.Log(LogStatus.Pass, SuccessMessage.Text);
                    flag2 = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }

            //Verify primary room is deleted
            if (flag2 == 1)
            {
                int flag = 0;
                for (int i = 0; i < ListOfPrimaryRoomName.Count; i++)
                {
                    if (ListOfPrimaryRoomName[i].Text.Equals(PrimaryRoomName))
                    {
                        flag = 1;
                        break;
                    }
                    else
                    {
                        continue;

                    }
                }
                if (flag == 0)
                {
                    test.Log(LogStatus.Pass, "Deleted Primary Room Verified Successfully!!");
                }
                else
                {
                    test.Log(LogStatus.Fail, "Deleted Primary Room Verification Failed!! ");
                    Assert.Fail();
                }
            }
            else
            {
                test.Log(LogStatus.Fail, PrimaryRoomName + "Is Not Present in List");
                Assert.Fail();
            }
        }
        #endregion


        #region Add Breakout Conference Rooms

        #region ClickOnAddBreakoutRoomsButton
        public void ClickOnAddBreakoutRoomsButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(AddBreakoutRoomsButton.Displayed);
            AddBreakoutRoomsButton.ClickOn(driver, 10);
            test.Log(LogStatus.Info, "Clicked on Add breakout room button");
        }
        #endregion

        #region ClickOnAddMultipleBreakoutRoomsButton
        public void ClickOnAddMultipleBreakoutRoomsButton(ILog log, ExtentTest test)
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.WaitTillElementToBeClickable(ConferenceRoomLocator.AddMultipleBreakoutRoomsButton, 60);
            Assert.IsTrue(AddMultipleBreakoutRoomsButton.Displayed);
            js.ExecuteScript("arguments[0].click()", AddMultipleBreakoutRoomsButton);

            test.Log(LogStatus.Info, "Clicked on Add multiple breakout rooms button");
        }
        #endregion

        public void AddBreakoutConferenceRooms(ILog log, ExtentTest test, string BreakoutRoomName, string BreakoutRoomDescription, string BreakoutRoomMaxAttendees, string BreakoutRoomsPerHold, string BreakoutRoomSetupCost, string BreakoutRoomSize)
        {
            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            BreakoutRoomNameField.EnterValue(BreakoutRoomName);
            test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            Assert.IsTrue(BreakoutRoomDescriptionField.Displayed);
            BreakoutRoomDescriptionField.EnterValue(BreakoutRoomDescription);
            test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

            Assert.IsTrue(BreakoutRoomMaxAttendeesField.Displayed);
            BreakoutRoomMaxAttendeesField.EnterValue(BreakoutRoomMaxAttendees);
            test.Log(LogStatus.Info, "Entered Max attendees :" + BreakoutRoomMaxAttendees);

            Assert.IsTrue(BreakoutRoomsPerHoldField.Displayed);
            BreakoutRoomsPerHoldField.EnterValue(BreakoutRoomsPerHold);
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHold);

            Assert.IsTrue(BreakoutRoomSetupCostField.Displayed);
            BreakoutRoomSetupCostField.EnterValue(BreakoutRoomSetupCost);
            test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCost);

            Assert.IsTrue(BreakoutRoomSizeField.Displayed);
            BreakoutRoomSizeField.EnterValue(BreakoutRoomSize);
            test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSize);

            ClickOnBreakoutRoomsAcceptButton(log, test);
            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, SuccessMessage.Text);


            //Verify added breakout Room           
            int flag = 0;
            for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
            {
                if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName))
                {
                    string Description = ListOfBreakoutRoomDescription[i].Text;
                    string MaxAttendees = ListOfBreakoutRoomMaxAttendees[i].Text;
                    string RoomsPerHold = ListOfBreakoutRoomsPerHold[i].Text;
                    string SetUpCost = ListOfBreakoutRoomSetUpCost[i].Text;
                    string Size = ListOfBreakoutRoomSize[i].Text;

                    Assert.AreEqual(BreakoutRoomDescription, Description);
                    Assert.AreEqual(BreakoutRoomMaxAttendees, MaxAttendees);
                    Assert.AreEqual(BreakoutRoomsPerHold, RoomsPerHold);
                    Assert.AreEqual(BreakoutRoomSetupCost, SetUpCost);
                    Assert.AreEqual(BreakoutRoomSize, Size);

                    flag = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (flag == 1)
            {
                test.Log(LogStatus.Pass, "Breakout Room Verified Successfully!!");
            }
            else
            {
                test.Log(LogStatus.Fail, "Breakout Room Verification Failed!!");
                Assert.Fail();
            }

        }

        //Add multiple breakout conference rooms
        public void AddMultipleBreakoutConferenceRoom(ILog log, ExtentTest test)
        {
            int RowCount = ExcelReaderHelper.GetTotalRows(fileLocation, "ConferenceRoom");

            for (int i = 2; i < RowCount; i++)
            {
                String BreakoutRoomName = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 9).ToString();
                String BreakoutRoomDescription = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 10).ToString();
                String BreakoutRoomMaxAttendees = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 11).ToString();
                String BreakoutRoomsPerHold = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 12).ToString();
                String BreakoutRoomSetupCost = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 13).ToString();
                String BreakoutRoomSize = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 14).ToString();

                Assert.IsTrue(BreakoutRoomNameField.Displayed);
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("document.getElementById('txtBRRoomName').value = '" + BreakoutRoomName + "'");
                test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

                Assert.IsTrue(BreakoutRoomDescriptionField.Displayed);
                js.ExecuteScript("document.getElementById('txtBRDesc').value = '" + BreakoutRoomDescription + "'");
                test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

                Assert.IsTrue(BreakoutRoomMaxAttendeesField.Displayed);
                js.ExecuteScript("document.getElementById('txtBRMaxAttendees').value = '" + BreakoutRoomMaxAttendees + "'");
                test.Log(LogStatus.Info, "Entered Max attendees :" + BreakoutRoomMaxAttendees);

                Assert.IsTrue(BreakoutRoomsPerHoldField.Displayed);
                js.ExecuteScript("document.getElementById('txtBRRoomsRequired').value = '" + BreakoutRoomsPerHold + "'");
                test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHold);

                Assert.IsTrue(BreakoutRoomSetupCostField.Displayed);
                js.ExecuteScript("document.getElementById('txtBRSetupCost').value = '" + BreakoutRoomSetupCost + "'");
                test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCost);

                Assert.IsTrue(BreakoutRoomSizeField.Displayed);
                js.ExecuteScript("document.getElementById('txtBRSize').value = '" + BreakoutRoomSize + "'");
                test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSize);

                ClickOnBreakoutRoomAcceptButton(log, test);
                ClickOnAddMultipleBreakoutRoomsButton(log, test);
            }
        }

        #region SubmitMultipleBreakoutRooms
        public void SubmitMultipleBreakoutRooms(ILog log, ExtentTest test)
        {
            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, SuccessMessage.Text);
        }
        #endregion

        public void VerifyMultipleBreakoutRooms(ILog log, ExtentTest test, string BreakoutRoomName1, string BreakoutRoomDescription1, string BreakoutRoomMaxAttendees1, string BreakoutRoomsPerHold1, string BreakoutRoomSetupCost1, string BreakoutRoomSize1)
        {
            int flag = 0;
            do
            {
                for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
                {
                    if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName1))
                    {
                        string Description = ListOfBreakoutRoomDescription[i].Text;
                        string MaxAttendees = ListOfBreakoutRoomMaxAttendees[i].Text;
                        string RoomsPerHold = ListOfBreakoutRoomsPerHold[i].Text;
                        string SetUpCost = ListOfBreakoutRoomSetUpCost[i].Text;
                        string Size = ListOfBreakoutRoomSize[i].Text;

                        Assert.AreEqual(BreakoutRoomDescription1, Description);
                        Assert.AreEqual(BreakoutRoomMaxAttendees1, MaxAttendees);
                        Assert.AreEqual(BreakoutRoomsPerHold1, RoomsPerHold);
                        Assert.AreEqual(BreakoutRoomSetupCost1, SetUpCost);
                        Assert.AreEqual(BreakoutRoomSize1, Size);

                        flag = 1;

                        if (BreakoutRoomDoubleLeftArrowStatus.GetAttribute("class").Equals("paginate_button first"))
                        {
                            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                            driver.WaitTillElementToBeClickable(ConferenceRoomLocator.BreakoutRoomDoubleLeftArrow, 60);
                            js.ExecuteScript("arguments[0].click()", BreakoutRoomDoubleLeftArrow);
                            BreakoutRoomShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.BreakoutRoomShowingAllRecordText, 60);
                        }

                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (BreakoutRoomSingleRightArrowStatus.GetAttribute("class").Equals("paginate_button next disabled") || flag == 1)
                {
                    break;
                }
                else
                {
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.BreakoutRoomSingleRightArrow, 60);
                    js.ExecuteScript("arguments[0].click()", BreakoutRoomSingleRightArrow);
                    BreakoutRoomShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.BreakoutRoomShowingAllRecordText, 60);
                }
            } while (BreakoutRoomSingleRightArrowStatus.GetAttribute("class").Equals("paginate_button next disabled") || BreakoutRoomSingleRightArrowStatus.GetAttribute("class").Equals("paginate_button next"));

            if (flag == 1)
            {
                test.Log(LogStatus.Pass, "Breakout Room " + BreakoutRoomName1 + " Verified Successfully!!");
            }
            else
            {
                test.Log(LogStatus.Fail, "Breakout Room " + BreakoutRoomName1 + " Verification Failed!!");
                Assert.Fail();
            }
        }

        #endregion


        #region Breakout Conference Room Field Validations 

        #region ClickOnBreakoutRoomCancelButton
        public void ClickOnBreakoutRoomCancelButton(ILog log, ExtentTest test)
        {
            BreakoutRoomCancelButton.WaitForElementContentToLoad(driver, ConferenceRoomLocator.BreakoutRoomCancelButton, 60);

            Assert.IsTrue(BreakoutRoomCancelButton.Displayed);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.WaitTillElementToBeClickable(ConferenceRoomLocator.BreakoutRoomCancelButton, 60);
            js.ExecuteScript("arguments[0].click()", BreakoutRoomCancelButton);
            test.Log(LogStatus.Info, "Clicked on Cancel Button");
        }
        #endregion

        #region Breakout Room Name Field Validation

        public void BreakoutRoomNameFieldValidation(ILog log, ExtentTest test, string ExistingBreakoutRoomName, string BreakoutRoomName)
        {
            ClickOnBreakoutRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(RoomNameRequiredMessage.Displayed);
            test.Log(LogStatus.Pass, "Breakout Room Name Required Validation Message displayed : " + RoomNameRequiredMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnBreakoutRoomCancelButton(log, test);

            ClickOnAddMultipleBreakoutRoomsButton(log, test);

            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            BreakoutRoomNameField.EnterValue(ExistingBreakoutRoomName);
            test.Log(LogStatus.Info, "Entered Room Name :" + ExistingBreakoutRoomName);

            ClickOnBreakoutRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(RoomNameAlreadyExistMessage.Displayed);
            test.Log(LogStatus.Pass, "Breakout Room Name Already Exist Validation Message displayed : " + RoomNameAlreadyExistMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnBreakoutRoomCancelButton(log, test);

            //Add valid room name & click on accept
            //ClickOnAddMultipleBreakoutRoomsButton(log, test);

            //Assert.IsTrue(BreakoutRoomNameField.Displayed);
            //BreakoutRoomNameField.EnterValue(BreakoutRoomName);
            //test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            //ClickOnBreakoutRoomAcceptButton(log, test);

            //OkButton.WaitTillElementToBeClickable(driver, 60);

            //Assert.IsTrue(SizeRequiredMessage.Displayed);
            //test.Log(LogStatus.Pass, "Please Enter a valid value for Size : " + SizeRequiredMessage.Text);

            //ClickOnOkButton(log, test);
            //ClickOnBreakoutRoomCancelButton(log, test);
        }
        #endregion

        #region Breakout Room Description field Validation

        public void BreakoutRoomDescriptionFieldValidation(ILog log, ExtentTest test, string BreakoutRoomName, string BreakoutRoomMaxAttendees, string BreakoutRoomsPerHold, string BreakoutRoomSetupCost, string BreakoutRoomSize)
        {

            ClickOnAddMultipleBreakoutRoomsButton(log, test);

            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            BreakoutRoomNameField.EnterValue(BreakoutRoomName);
            test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            Assert.IsTrue(BreakoutRoomMaxAttendeesField.Displayed);
            BreakoutRoomMaxAttendeesField.EnterValue(BreakoutRoomMaxAttendees);
            test.Log(LogStatus.Info, "Entered Max attendees :" + BreakoutRoomMaxAttendees);

            Assert.IsTrue(BreakoutRoomsPerHoldField.Displayed);
            BreakoutRoomsPerHoldField.EnterValue(BreakoutRoomsPerHold);
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHold);

            Assert.IsTrue(BreakoutRoomSetupCostField.Displayed);
            BreakoutRoomSetupCostField.EnterValue(BreakoutRoomSetupCost);
            test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCost);

            Assert.IsTrue(BreakoutRoomSizeField.Displayed);
            BreakoutRoomSizeField.EnterValue(BreakoutRoomSize);
            test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSize);

            ClickOnBreakoutRoomAcceptButton(log, test);

            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, SuccessMessage.Text);
            test.Log(LogStatus.Pass, "Breakout Room Description field is not mandatory");

            //delete added room
            for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
            {
                if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName))
                {

                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    driver.WaitTillElementToBeClickable(ListOfBreakoutDeleteButton[i], 60);
                    js.ExecuteScript("arguments[0].click()", ListOfBreakoutDeleteButton[i]);
                    test.Log(LogStatus.Info, "Clicked on Delete Breakout room button");

                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.SubmitButton, 60);
                    js.ExecuteScript("arguments[0].click()", SubmitButton);
                    test.Log(LogStatus.Info, "Clicked on Submit button");

                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        #endregion

        #region Breakout Room Max Attendees field Validation

        public void BreakoutRoomMaxAttendeesFieldValidation(ILog log, ExtentTest test, string BreakoutRoomName, string BreakoutRoomDescription, string BreakoutRoomMaxAttendeesNull, string BreakoutRoomMaxAttendeesInavlidData, string BreakoutRoomMaxAttendees, string BreakoutRoomsPerHold, string BreakoutRoomSetupCost, string BreakoutRoomSize)
        {

            //Max Attendees required validation
            ClickOnAddMultipleBreakoutRoomsButton(log, test);

            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('txtBRRoomName').value = '" + BreakoutRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            Assert.IsTrue(BreakoutRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRDesc').value = '" + BreakoutRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

            Assert.IsTrue(BreakoutRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomsRequired').value = '" + BreakoutRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHold);

            Assert.IsTrue(BreakoutRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSetupCost').value = '" + BreakoutRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCost);

            Assert.IsTrue(BreakoutRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSize').value = '" + BreakoutRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSize);

            ClickOnBreakoutRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(MaxAttendeesRequiredMessage.Displayed);
            test.Log(LogStatus.Pass, "Breakout Room Max Attendees Required Validation Message displayed : " + MaxAttendeesRequiredMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnBreakoutRoomCancelButton(log, test);


            //Max Attendees valid data validation
            ClickOnAddMultipleBreakoutRoomsButton(log, test);
            test.Log(LogStatus.Info, "Clicked on Add Breakout Rooms Button");

            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomName').value = '" + BreakoutRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            Assert.IsTrue(BreakoutRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRDesc').value = '" + BreakoutRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

            Assert.IsTrue(BreakoutRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRMaxAttendees').value = '" + BreakoutRoomMaxAttendeesInavlidData + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + BreakoutRoomMaxAttendeesInavlidData);

            Assert.IsTrue(BreakoutRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomsRequired').value = '" + BreakoutRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHold);

            Assert.IsTrue(BreakoutRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSetupCost').value = '" + BreakoutRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCost);

            Assert.IsTrue(BreakoutRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSize').value = '" + BreakoutRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSize);

            ClickOnBreakoutRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(MaxAttendeesValidDataMessage.Displayed);
            test.Log(LogStatus.Pass, "Breakout Room Max Attendees Valid data Validation Message displayed : " + MaxAttendeesValidDataMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnBreakoutRoomCancelButton(log, test);


            //Max Attendees null validation
            ClickOnAddMultipleBreakoutRoomsButton(log, test);

            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomName').value = '" + BreakoutRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            Assert.IsTrue(BreakoutRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRDesc').value = '" + BreakoutRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

            Assert.IsTrue(BreakoutRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRMaxAttendees').value = '" + BreakoutRoomMaxAttendeesNull + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + BreakoutRoomMaxAttendeesNull);

            Assert.IsTrue(BreakoutRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomsRequired').value = '" + BreakoutRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHold);

            Assert.IsTrue(BreakoutRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSetupCost').value = '" + BreakoutRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCost);

            Assert.IsTrue(BreakoutRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSize').value = '" + BreakoutRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSize);

            ClickOnBreakoutRoomAcceptButton(log, test);
            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, SuccessMessage.Text);
            test.Log(LogStatus.Pass, "Breakout Room Max Attendees field accept Zero value");

            //delete added room
            for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
            {
                if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName))
                {

                    IWebElement BreakoutRoomDeleteButton = driver.FindElement(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[8]/button[2]"));
                    driver.WaitTillElementToBeClickable(BreakoutRoomDeleteButton, 60);
                    js.ExecuteScript("arguments[0].click()", BreakoutRoomDeleteButton);
                    test.Log(LogStatus.Info, "Clicked on Delete Breakout room button");

                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.SubmitButton, 60);
                    js.ExecuteScript("arguments[0].click()", SubmitButton);
                    test.Log(LogStatus.Info, "Clicked on Submit button");

                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        #endregion

        #region Breakout Rooms Per Hold field Validation
        public void BreakoutRoomsPerHoldFieldValidation(ILog log, ExtentTest test, string BreakoutRoomName, string BreakoutRoomDescription, string BreakoutRoomMaxAttendees, string BreakoutRoomsPerHoldInvalidData, string BreakoutRoomsPerHold, string BreakoutRoomSetupCost, string BreakoutRoomSize)
        {

            //Rooms per hold valid data validation
            ClickOnAddMultipleBreakoutRoomsButton(log, test);
            test.Log(LogStatus.Info, "Clicked on Add Breakout Rooms Button");

            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('txtBRRoomName').value = '" + BreakoutRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            Assert.IsTrue(BreakoutRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRDesc').value = '" + BreakoutRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

            Assert.IsTrue(BreakoutRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRMaxAttendees').value = '" + BreakoutRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + BreakoutRoomMaxAttendees);

            Assert.IsTrue(BreakoutRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomsRequired').value = '" + BreakoutRoomsPerHoldInvalidData + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHoldInvalidData);

            Assert.IsTrue(BreakoutRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSetupCost').value = '" + BreakoutRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCost);

            Assert.IsTrue(BreakoutRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSize').value = '" + BreakoutRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSize);

            ClickOnBreakoutRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(RoomsPerHoldValidDataMessage.Displayed);
            test.Log(LogStatus.Pass, "Breakout Rooms per hold Valid data Validation Message displayed : " + RoomsPerHoldValidDataMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnBreakoutRoomCancelButton(log, test);


            //Rooms per hold accept zero validation
            ClickOnAddMultipleBreakoutRoomsButton(log, test);

            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomName').value = '" + BreakoutRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            Assert.IsTrue(BreakoutRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRDesc').value = '" + BreakoutRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

            Assert.IsTrue(BreakoutRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRMaxAttendees').value = '" + BreakoutRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + BreakoutRoomMaxAttendees);


            Assert.AreEqual("0", BreakoutRoomsPerHoldField.GetAttribute("value"), "0 Value is not present in Rooms per hold field");

            Assert.IsTrue(BreakoutRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSetupCost').value = '" + BreakoutRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCost);

            Assert.IsTrue(BreakoutRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSize').value = '" + BreakoutRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSize);

            ClickOnBreakoutRoomAcceptButton(log, test);

            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, SuccessMessage.Text);
            test.Log(LogStatus.Pass, "Breakout Rooms Per Hold field accept Zero value");

            //delete added room
            for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
            {
                if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName))
                {

                    IWebElement BreakoutRoomDeleteButton = driver.FindElement(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[8]/button[2]"));
                    driver.WaitTillElementToBeClickable(BreakoutRoomDeleteButton, 60);
                    js.ExecuteScript("arguments[0].click()", BreakoutRoomDeleteButton);
                    test.Log(LogStatus.Info, "Clicked on Delete Breakout room button");

                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.SubmitButton, 60);
                    js.ExecuteScript("arguments[0].click()", SubmitButton);
                    test.Log(LogStatus.Info, "Clicked on Submit button");

                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        #endregion

        #region Breakout Room Setup Cost field Validation
        public void BreakoutRoomSetupCostFieldValidation(ILog log, ExtentTest test, string BreakoutRoomName, string BreakoutRoomDescription, string BreakoutRoomMaxAttendees, string BreakoutRoomsPerHold, string BreakoutRoomSetupCostNull, string BreakoutRoomSetupCostInvalidData, string BreakoutRoomSetupCost, string BreakoutRoomSize)
        {

            //Setup Cost required validation
            ClickOnAddMultipleBreakoutRoomsButton(log, test);

            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('txtBRRoomName').value = '" + BreakoutRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            Assert.IsTrue(BreakoutRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRDesc').value = '" + BreakoutRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

            Assert.IsTrue(BreakoutRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRMaxAttendees').value = '" + BreakoutRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + BreakoutRoomMaxAttendees);

            Assert.IsTrue(BreakoutRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomsRequired').value = '" + BreakoutRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHold);

            Assert.IsTrue(BreakoutRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSize').value = '" + BreakoutRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSize);

            ClickOnBreakoutRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(SetupCostRequiredMessage.Displayed);
            test.Log(LogStatus.Pass, "Breakout Room Setup Cost Required Validation Message displayed : " + SetupCostRequiredMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnBreakoutRoomCancelButton(log, test);


            //Setup cost valid data validation
            ClickOnAddMultipleBreakoutRoomsButton(log, test);
            test.Log(LogStatus.Info, "Clicked on Add Breakout Rooms Button");

            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomName').value = '" + BreakoutRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            Assert.IsTrue(BreakoutRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRDesc').value = '" + BreakoutRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

            Assert.IsTrue(BreakoutRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRMaxAttendees').value = '" + BreakoutRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + BreakoutRoomMaxAttendees);

            Assert.IsTrue(BreakoutRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomsRequired').value = '" + BreakoutRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHold);

            Assert.IsTrue(BreakoutRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSetupCost').value = '" + BreakoutRoomSetupCostInvalidData + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCostInvalidData);

            Assert.IsTrue(BreakoutRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSize').value = '" + BreakoutRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSize);

            ClickOnBreakoutRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(SetupCostValidDataMessage.Displayed);
            test.Log(LogStatus.Pass, "Breakout Room Setup cost Valid data Validation Message displayed : " + SetupCostValidDataMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnBreakoutRoomCancelButton(log, test);


            //Setup Cost field accept zero validation
            ClickOnAddMultipleBreakoutRoomsButton(log, test);

            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomName').value = '" + BreakoutRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            Assert.IsTrue(BreakoutRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRDesc').value = '" + BreakoutRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

            Assert.IsTrue(BreakoutRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRMaxAttendees').value = '" + BreakoutRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + BreakoutRoomMaxAttendees);

            Assert.IsTrue(BreakoutRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomsRequired').value = '" + BreakoutRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHold);

            Assert.IsTrue(BreakoutRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSetupCost').value = '" + BreakoutRoomSetupCostNull + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCostNull);

            Assert.IsTrue(BreakoutRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSize').value = '" + BreakoutRoomSize + "'");
            test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSize);

            ClickOnBreakoutRoomAcceptButton(log, test);
            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, SuccessMessage.Text);
            test.Log(LogStatus.Pass, "Breakout Room Setup Cost field accept Zero value");

            //delete added room
            for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
            {
                if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName))
                {

                    IWebElement BreakoutRoomDeleteButton = driver.FindElement(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[8]/button[2]"));
                    driver.WaitTillElementToBeClickable(BreakoutRoomDeleteButton, 60);
                    js.ExecuteScript("arguments[0].click()", BreakoutRoomDeleteButton);
                    test.Log(LogStatus.Info, "Clicked on Delete Breakout room button");

                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.SubmitButton, 60);
                    js.ExecuteScript("arguments[0].click()", SubmitButton);
                    test.Log(LogStatus.Info, "Clicked on Submit button");

                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        #endregion

        #region Breakout Room Size field Validation
        public void BreakoutRoomSizeFieldValidation(ILog log, ExtentTest test, string BreakoutRoomName, string BreakoutRoomDescription, string BreakoutRoomMaxAttendees, string BreakoutRoomsPerHold, string BreakoutRoomSetupCost, string BreakoutRoomSizeNull, string BreakoutRoomSizeInvalidData, string BreakoutRoomSize)
        {

            //Size required validation
            ClickOnAddMultipleBreakoutRoomsButton(log, test);

            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('txtBRRoomName').value = '" + BreakoutRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            Assert.IsTrue(BreakoutRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRDesc').value = '" + BreakoutRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

            Assert.IsTrue(BreakoutRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRMaxAttendees').value = '" + BreakoutRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + BreakoutRoomMaxAttendees);

            Assert.IsTrue(BreakoutRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomsRequired').value = '" + BreakoutRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHold);

            Assert.IsTrue(BreakoutRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSetupCost').value = '" + BreakoutRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCost);

            ClickOnBreakoutRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(SizeRequiredMessage.Displayed);
            test.Log(LogStatus.Pass, "Breakout Room Size Required Validation Message displayed : " + SizeRequiredMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnBreakoutRoomCancelButton(log, test);

            //Size field shouldn't be zero validation
            ClickOnAddMultipleBreakoutRoomsButton(log, test);

            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomName').value = '" + BreakoutRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            Assert.IsTrue(BreakoutRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRDesc').value = '" + BreakoutRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

            Assert.IsTrue(BreakoutRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRMaxAttendees').value = '" + BreakoutRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + BreakoutRoomMaxAttendees);

            Assert.IsTrue(BreakoutRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomsRequired').value = '" + BreakoutRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHold);

            Assert.IsTrue(BreakoutRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSetupCost').value = '" + BreakoutRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCost);

            Assert.IsTrue(BreakoutRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSize').value = '" + BreakoutRoomSizeNull + "'");
            test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSizeNull);

            ClickOnBreakoutRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(SizeZeroValueMessage.Displayed);
            test.Log(LogStatus.Pass, "Breakout Room Size shouldn't be zero Validation Message displayed : " + SizeZeroValueMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnBreakoutRoomCancelButton(log, test);


            //Size valid data validation
            ClickOnAddMultipleBreakoutRoomsButton(log, test);
            test.Log(LogStatus.Info, "Clicked on Add Breakout Rooms Button");

            Assert.IsTrue(BreakoutRoomNameField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomName').value = '" + BreakoutRoomName + "'");
            test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

            Assert.IsTrue(BreakoutRoomDescriptionField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRDesc').value = '" + BreakoutRoomDescription + "'");
            test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

            Assert.IsTrue(BreakoutRoomMaxAttendeesField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRMaxAttendees').value = '" + BreakoutRoomMaxAttendees + "'");
            test.Log(LogStatus.Info, "Entered Max attendees :" + BreakoutRoomMaxAttendees);

            Assert.IsTrue(BreakoutRoomsPerHoldField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRRoomsRequired').value = '" + BreakoutRoomsPerHold + "'");
            test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHold);

            Assert.IsTrue(BreakoutRoomSetupCostField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSetupCost').value = '" + BreakoutRoomSetupCost + "'");
            test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCost);

            Assert.IsTrue(BreakoutRoomSizeField.Displayed);
            js.ExecuteScript("document.getElementById('txtBRSize').value = '" + BreakoutRoomSizeInvalidData + "'");
            test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSizeInvalidData);

            ClickOnBreakoutRoomAcceptButton(log, test);

            OkButton.WaitTillElementToBeClickable(driver, 60);

            Assert.IsTrue(SizeValidDataMessage.Displayed);
            test.Log(LogStatus.Pass, "Breakout Room Setup cost Valid data Validation Message displayed : " + SizeValidDataMessage.Text);

            ClickOnOkButton(log, test);
            ClickOnBreakoutRoomCancelButton(log, test);
        }
        #endregion

        public void BreakoutConferenceRoomFieldValidations(ILog log, ExtentTest test, string ExistingBreakoutRoomName, string BreakoutRoomName, string BreakoutRoomDescription, string BreakoutRoomMaxAttendeesNull, string BreakoutRoomMaxAttendeesInavlidData, string BreakoutRoomMaxAttendees, string BreakoutRoomsPerHoldInvalidData, string BreakoutRoomsPerHold, string BreakoutRoomSetupCostNull, string BreakoutRoomSetupCostInvalidData, string BreakoutRoomSetupCost, string BreakoutRoomSizeNull, string BreakoutRoomSizeInvalidData, string BreakoutRoomSize)
        {

            BreakoutRoomNameFieldValidation(log, test, ExistingBreakoutRoomName, BreakoutRoomName);

            BreakoutRoomDescriptionFieldValidation(log, test, BreakoutRoomName, BreakoutRoomMaxAttendees, BreakoutRoomsPerHold, BreakoutRoomSetupCost, BreakoutRoomSize);

            BreakoutRoomMaxAttendeesFieldValidation(log, test, BreakoutRoomName, BreakoutRoomDescription, BreakoutRoomMaxAttendeesNull, BreakoutRoomMaxAttendeesInavlidData, BreakoutRoomMaxAttendees, BreakoutRoomsPerHold, BreakoutRoomSetupCost, BreakoutRoomSize);

            BreakoutRoomsPerHoldFieldValidation(log, test, BreakoutRoomName, BreakoutRoomDescription, BreakoutRoomMaxAttendees, BreakoutRoomsPerHoldInvalidData, BreakoutRoomsPerHold, BreakoutRoomSetupCost, BreakoutRoomSize);

            BreakoutRoomSetupCostFieldValidation(log, test, BreakoutRoomName, BreakoutRoomDescription, BreakoutRoomMaxAttendees, BreakoutRoomsPerHold, BreakoutRoomSetupCostNull, BreakoutRoomSetupCostInvalidData, BreakoutRoomSetupCost, BreakoutRoomSize);

            BreakoutRoomSizeFieldValidation(log, test, BreakoutRoomName, BreakoutRoomDescription, BreakoutRoomMaxAttendees, BreakoutRoomsPerHold, BreakoutRoomSetupCost, BreakoutRoomSizeNull, BreakoutRoomSizeInvalidData, BreakoutRoomSize);
        }

        #endregion


        #region Edit Breakout Conference Room

        public void EditBreakoutConferenceRoom(ILog log, ExtentTest test, string ExistingBreakoutRoomName, string BreakoutRoomName, string BreakoutRoomDescription, string BreakoutRoomMaxAttendees, string BreakoutRoomsPerHold, string BreakoutRoomSetupCost, string BreakoutRoomSize)
        {
            int flag1 = 0;
            for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
            {
                if (ListOfBreakoutRoomName[i].Text.Equals(ExistingBreakoutRoomName))
                {

                    IWebElement BreakoutRoomEditButton = driver.FindElement(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[8]/button[1]"));
                    BreakoutRoomEditButton.Click();
                    IWebElement EditBreakoutRoomName = driver.FindElement(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[1]//input[@type='text']"));
                    IWebElement EditBreakoutRoomDescription = driver.FindElement(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[2]//input[@type='text']"));
                    IWebElement EditBreakoutRoomMaxAttendees = driver.FindElement(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[3]//input[@type='text']"));
                    IWebElement EditBreakoutRoomsPerHold = driver.FindElement(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[4]//input[@type='text']"));
                    IWebElement EditBreakoutSetUpCost = driver.FindElement(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[5]//input[@type='text']"));
                    IWebElement EditBreakoutSize = driver.FindElement(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[6]//input[@type='text']"));

                    Assert.IsTrue(EditBreakoutRoomName.Displayed);
                    EditBreakoutRoomName.EnterValue(BreakoutRoomName);
                    test.Log(LogStatus.Info, "Entered Room Name :" + BreakoutRoomName);

                    Assert.IsTrue(EditBreakoutRoomDescription.Displayed);
                    EditBreakoutRoomDescription.EnterValue(BreakoutRoomDescription);
                    test.Log(LogStatus.Info, "Entered Description :" + BreakoutRoomDescription);

                    Assert.IsTrue(EditBreakoutRoomMaxAttendees.Displayed);
                    EditBreakoutRoomMaxAttendees.EnterValue(BreakoutRoomMaxAttendees);
                    test.Log(LogStatus.Info, "Entered Max attendees : " + BreakoutRoomMaxAttendees);

                    Assert.IsTrue(EditBreakoutRoomsPerHold.Displayed);
                    EditBreakoutRoomsPerHold.EnterValue(BreakoutRoomsPerHold);
                    test.Log(LogStatus.Info, "Entered Rooms Per Hold :" + BreakoutRoomsPerHold);

                    Assert.IsTrue(EditBreakoutSetUpCost.Displayed);
                    EditBreakoutSetUpCost.EnterValue(BreakoutRoomSetupCost);
                    test.Log(LogStatus.Info, "Entered Setup Cost :" + BreakoutRoomSetupCost);

                    Assert.IsTrue(EditBreakoutSize.Displayed);
                    EditBreakoutSize.EnterValue(BreakoutRoomSize);
                    test.Log(LogStatus.Info, "Entered Size :" + BreakoutRoomSize);

                    IWebElement BreakoutRoomAcceptButton1 = driver.FindElement(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[8]/button[1]"));
                    BreakoutRoomAcceptButton1.Click();
                    ClickOnSubmitButton(log, test);
                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    test.Log(LogStatus.Pass, SuccessMessage.Text);
                    flag1 = 1;
                    break;

                }
            }

            //Verify updated breakout room
            if (flag1 == 1)
            {
                int flag = 0;
                for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
                {
                    if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName))
                    {
                        string Description = ListOfBreakoutRoomDescription[i].Text;
                        string MaxAttendees = ListOfBreakoutRoomMaxAttendees[i].Text;
                        string RoomsPerHold = ListOfBreakoutRoomsPerHold[i].Text;
                        string SetUpCost = ListOfBreakoutRoomSetUpCost[i].Text;
                        string Size = ListOfBreakoutRoomSize[i].Text;

                        Assert.AreEqual(BreakoutRoomDescription, Description);
                        Assert.AreEqual(BreakoutRoomMaxAttendees, MaxAttendees);
                        Assert.AreEqual(BreakoutRoomsPerHold, RoomsPerHold);
                        Assert.AreEqual(BreakoutRoomSetupCost, SetUpCost);
                        Assert.AreEqual(BreakoutRoomSize, Size);

                        flag = 1;

                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (flag == 1)
                {
                    test.Log(LogStatus.Pass, "Updated Breakout Room Verified Successfully!!");
                }
                else
                {
                    test.Log(LogStatus.Fail, "Updated Breakout Room Verification Failed!!");
                    Assert.Fail();
                }
            }
            else
            {
                test.Log(LogStatus.Fail, ExistingBreakoutRoomName + "is not Present in Breakout Room List");
            }

        }
        #endregion


        #region Add Media for breakout conference room

        public void AddMediaForBreakoutConferenceRoom(ILog log, ExtentTest test, string BreakoutRoomName, string BreakoutMediaName)
        {
            int flag = 0;

            for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
            {
                if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName))
                {

                    PrimaryRoomShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.PrimaryRoomShowingAllRecordText, 60);

                    ListOfPrimaryAddMediaIcon[i].Click();
                    test.Log(LogStatus.Info, "Add media icon clicked");

                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.AddMediaButton, 60);

                    CustomMethods.UploadFileWithSendKeys(Image3FileLocation, 1, AddMediaButton);
                    WaitTillLoading();
                    test.Log(LogStatus.Info, "First Image Uploaded");

                    CustomMethods.UploadFileWithSendKeys(Image4FileLocation, 1, AddMultipleMediaButton);
                    WaitTillLoading();
                    test.Log(LogStatus.Info, "Second Image Uploaded");

                    ClickOnCloseMediaButton(log, test);

                    wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(ConferenceRoomLocator.SubmitButton)));

                    ClickOnSubmitButton(log, test);
                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    test.Log(LogStatus.Pass, SuccessMessage.Text);
                    flag = 1;
                    break;
                }
                else
                {
                    continue;
                }

            }
            if (flag == 1)
            {

                VerifyAddedBreakoutMedia(log, test, BreakoutRoomName, BreakoutMediaName);
            }
            else
            {
                test.Log(LogStatus.Fail, "Failed to add media");
                Assert.Fail();
            }
        }

        //Verify Media is added  
        public void VerifyAddedBreakoutMedia(ILog log, ExtentTest test, string BreakoutRoomName, string BreakoutMediaName)
        {
            int flag = 0;
            int flag1 = 0;
            for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
            {
                if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName))
                {
                    flag = 1;

                    BreakoutRoomShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.BreakoutRoomShowingAllRecordText, 60);

                    ListOfBreakoutAddMediaIcon[i].WaitTillElementToBeClickable(driver, 60);

                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    js.ExecuteScript("arguments[0].click()", ListOfPrimaryAddMediaIcon[i]);
                    test.Log(LogStatus.Info, "Add media icon clicked");

                    AddMediaShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.AddMediaShowingAllRecordText, 60);

                    for (int j = 0; j < ListOfMedia.Count; j++)
                    {
                        if (ListOfMedia[j].Text.Contains(PrimaryMediaName))
                        {

                            flag1 = 1;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if (flag == 1)
                {
                    break;
                }
            }
            if (flag1 == 1)
            {
                test.Log(LogStatus.Pass, "Added media Verfied Successfully!!");
            }
            else
            {
                test.Log(LogStatus.Fail, "Added Media Verfication Failed!! ");
                Assert.Fail();
            }




            int flag = 0;
            int flag1 = 0;
            for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
            {
                if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName))
                {
                    flag = 1;

                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    IWebElement e = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[7]//span[@class='fa fa-upload']")));
                    js.ExecuteScript("arguments[0].click()", e);

                    test.Log(LogStatus.Info, "Add media icon clicked");

                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(ConferenceRoomLocator.AddMediaShowingAllRecordText)));

                    for (int j = 0; j < ListOfMedia.Count; j++)
                    {
                        if (ListOfMedia[j].Text.Contains(BreakoutMediaName))
                        {

                            flag1 = 1;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if (flag == 1)
                {
                    break;
                }
            }
            if (flag1 == 1)
            {
                test.Log(LogStatus.Pass, "Added media Verified Successfully!!");
            }
            else
            {
                test.Log(LogStatus.Fail, "Added Media Verification Failed!! ");
                Assert.Fail();
            }
        }
        #endregion


        #region Delete added Breakout room Media

        public void DeleteAddedBreakoutRoomMedia(ILog log, ExtentTest test, string BreakoutRoomName, string BreakoutMediaName)
        {
            int flag = 0;
            for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
            {
                if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName))
                {

                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    IWebElement e = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[7]//span[@class='fa fa-upload']")));
                    js.ExecuteScript("arguments[0].click()", e);

                    test.Log(LogStatus.Info, "Add media icon clicked");

                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(ConferenceRoomLocator.AddMediaShowingAllRecordText)));

                    for (int j = 0; j < ListOfMedia.Count; j++)
                    {
                        if (ListOfMedia[j].Text.Contains(BreakoutMediaName))
                        {

                            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//table[@id='tblMedia']/tbody/tr[" + (i + 1) + "]/td[4]/div/button[3]")));
                            IWebElement DeleteMediaButton = driver.FindElement(By.XPath("//table[@id='tblMedia']/tbody/tr[" + (i + 1) + "]/td[4]/div/button[3]/i"));
                            DeleteMediaButton.Click();
                            test.Log(LogStatus.Info, "Delete media button clicked");

                            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(ConferenceRoomLocator.DeleteConfirmButton)));
                            ClickOnDeleteConfirmButton(log, test);
                            ClickOnCloseMediaButton(log, test);

                            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(ConferenceRoomLocator.SubmitButton)));
                            ClickOnSubmitButton(log, test);
                            WaitTillLoading();
                            Assert.IsTrue(SuccessMessage.Displayed);
                            test.Log(LogStatus.Pass, SuccessMessage.Text);
                            flag = 1;
                            break;
                        }
                        else
                        {
                            continue;
                        }

                    }
                    if (flag == 1)
                    {

                        VerifyBreakoutMediaDeleted(log, test, BreakoutRoomName, BreakoutMediaName);
                    }
                    else
                    {
                        test.Log(LogStatus.Fail, "Failed to delete media");
                        Assert.Fail();
                    }
                }
            }
        }

        //Verify Media is deleted

        public void VerifyBreakoutMediaDeleted(ILog log, ExtentTest test, string BreakoutRoomName, string BreakoutMediaName)
        {
            int flag = 0;
            int flag1 = 0;
            for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
            {
                if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName))
                {
                    flag = 1;

                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    IWebElement e = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[7]//span[@class='fa fa-upload']")));
                    js.ExecuteScript("arguments[0].click()", e);

                    test.Log(LogStatus.Info, "Add media icon clicked");

                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(ConferenceRoomLocator.AddMediaShowingAllRecordText)));

                    for (int j = 0; j < ListOfMedia.Count; j++)
                    {
                        if (ListOfMedia[j].Text.Contains(BreakoutMediaName))
                        {

                            flag1 = 1;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if (flag == 1)
                {
                    break;
                }
            }
            if (flag1 == 1)
            {
                test.Log(LogStatus.Fail, "Deleted media verification failed!!");
                Assert.Fail();
            }
            else
            {
                test.Log(LogStatus.Pass, "Deleted media verified successfully!!");

            }
        }
        #endregion


        #region Delete Breakout Conference Room
        public void DeleteBreakoutConferenceRoom(ILog log, ExtentTest test, string BreakoutRoomName)
        {
            int flag2 = 0;

            for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
            {
                if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName))
                {

                    IWebElement BreakoutRoomDeleteButton = driver.FindElement(By.XPath("//table[@id='tblBreakOutRooms']/tbody/tr[" + (i + 1) + "]/td[8]/button[2]"));
                    BreakoutRoomDeleteButton.Click();
                    ClickOnSubmitButton(log, test);
                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    test.Log(LogStatus.Pass, SuccessMessage.Text);
                    flag2 = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }

            //Verify primary room is deleted
            if (flag2 == 1)
            {
                int flag = 0;
                for (int i = 0; i < ListOfBreakoutRoomName.Count; i++)
                {
                    if (ListOfBreakoutRoomName[i].Text.Equals(BreakoutRoomName))
                    {
                        flag = 1;
                        break;
                    }
                    else
                    {
                        continue;

                    }
                }
                if (flag == 0)
                {
                    test.Log(LogStatus.Pass, "Deleted Breakout Room Verified Successfully!!");
                }
                else
                {
                    test.Log(LogStatus.Fail, "Deleted Breakout Room Verification Failed!! ");
                    Assert.Fail();
                }
            }
            else
            {
                test.Log(LogStatus.Fail, BreakoutRoomName + "Is Not Present in List");
                Assert.Fail();
            }
        }
        #endregion


        #region Add Available Room Configuration

        #region ClickOnAddAvailableRoomConfigurationsButton
        public void ClickOnAddAvailableRoomConfigurationsButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(AddAvailableRoomConfigurationsButton.Displayed);
            AddAvailableRoomConfigurationsButton.ClickOn(driver, 10);
            test.Log(LogStatus.Info, "Clicked on Add available room configurations button");
        }
        #endregion

        #region ClickOnAvailableRoomConfigurationsAcceptButton
        public void ClickOnAvailableRoomConfigurationsAcceptButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(AvailableRoomConfigurationsAcceptButton.Displayed);
            AvailableRoomConfigurationsAcceptButton.ClickOn(driver, 10);
            test.Log(LogStatus.Info, "Clicked on Accept button");
        }
        #endregion

        #region ClickOnAddMultipleAvailableRoomConfigurationsButton
        public void ClickOnAddMultipleAvailableRoomConfigurationsButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(AddMultipleAvailableRoomConfigurationsButton.Displayed);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.WaitTillElementToBeClickable(ConferenceRoomLocator.AddMultipleAvailableRoomConfigurationsButton, 60);
            js.ExecuteScript("arguments[0].click()", AddMultipleAvailableRoomConfigurationsButton);

            test.Log(LogStatus.Info, "Clicked on Add multiple room configurations button");
        }
        #endregion

        public void AddAvailableRoomConfigurations(ILog log, ExtentTest test, string Configuration, string SqftPerAttendee, string Description)
        {
            Assert.IsTrue(ConfigurationField.Displayed);
            ConfigurationField.EnterValue(Configuration);
            test.Log(LogStatus.Info, "Entered Configuration name :" + Configuration);

            Assert.IsTrue(SqftPerAttendeeField.Displayed);
            SqftPerAttendeeField.EnterValue(SqftPerAttendee);
            test.Log(LogStatus.Info, "Entered Sqft per attendee :" + SqftPerAttendee);

            Assert.IsTrue(DescriptionField.Displayed);
            DescriptionField.EnterValue(Description);
            test.Log(LogStatus.Info, "Entered Description :" + Description);

            ClickOnAvailableRoomConfigurationsAcceptButton(log, test);
            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, SuccessMessage.Text);


            //Verify added Room configuration           
            int flag = 0;
            for (int i = 0; i < ListOfAvailableRoomConfigurations.Count; i++)
            {
                if (ListOfAvailableRoomConfigurations[i].Text.Equals(Configuration))
                {

                    string SqftPerAttendees = ListOfAvailableRoomSqftPerAttendee[i].Text;
                    string Descriptions = ListOfAvailableRoomDescription[i].Text;

                    Assert.AreEqual(SqftPerAttendee, SqftPerAttendees);
                    Assert.AreEqual(Description, Descriptions);

                    flag = 1;

                    break;
                }
                else
                {
                    continue;
                }
            }
            if (flag == 1)
            {
                test.Log(LogStatus.Pass, "Room Configuration Verified Successfully!!");
            }
            else
            {
                test.Log(LogStatus.Fail, "Room Configuration Verification Failed!!");
                Assert.Fail();
            }

        }

        //Add multiple room configurations
        public void AddMultipleAvailableRoomConfigurations(ILog log, ExtentTest test)
        {
            int RowCount = ExcelReaderHelper.GetTotalRows(fileLocation, "ConferenceRoom");

            for (int i = 2; i < RowCount; i++)
            {
                String Configuration = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 23).ToString();
                String SqftPerAttendee = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 24).ToString();
                String Description = ExcelReaderHelper.GetCellData(fileLocation, "ConferenceRoom", i, 25).ToString();

                Assert.IsTrue(ConfigurationField.Displayed);
                ConfigurationField.EnterValue(Configuration);
                test.Log(LogStatus.Info, "Entered Configuration :" + Configuration);

                Assert.IsTrue(SqftPerAttendeeField.Displayed);
                SqftPerAttendeeField.EnterValue(SqftPerAttendee);
                test.Log(LogStatus.Info, "Entered SqftPerAttendee :" + SqftPerAttendee);

                Assert.IsTrue(DescriptionField.Displayed);
                DescriptionField.EnterValue(Description);
                test.Log(LogStatus.Info, "Entered Description :" + Description);

                ClickOnAvailableRoomConfigurationsAcceptButton(log, test);
                ClickOnAddMultipleAvailableRoomConfigurationsButton(log, test);
            }
        }

        #region SubmitMultipleRoomConfigurations
        public void SubmitMultipleRoomConfigurations(ILog log, ExtentTest test)
        {
            ClickOnSubmitButton(log, test);
            WaitTillLoading();
            Assert.IsTrue(SuccessMessage.Displayed);
            test.Log(LogStatus.Pass, SuccessMessage.Text);
        }
        #endregion

        public void VerifyMultipleRoomConfigurations(ILog log, ExtentTest test, string Configuration1, string SqftPerAttendee1, string Description1)
        {
            int flag = 0;
            do
            {
                for (int i = 0; i < ListOfAvailableRoomConfigurations.Count; i++)
                {
                    if (ListOfAvailableRoomConfigurations[i].Text.Equals(Configuration1))
                    {
                        string SqftPerAttendees = ListOfAvailableRoomSqftPerAttendee[i].Text;
                        string Descriptions = ListOfAvailableRoomDescription[i].Text;

                        Assert.AreEqual(SqftPerAttendee1, SqftPerAttendees);
                        Assert.AreEqual(Description1, Descriptions);

                        flag = 1;

                        if (RoomConfigurationsDoubleLeftArrowStatus.GetAttribute("class").Equals("paginate_button first"))
                        {
                            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                            driver.WaitTillElementToBeClickable(ConferenceRoomLocator.RoomConfigurationsDoubleLeftArrow, 60);
                            js.ExecuteScript("arguments[0].click()", RoomConfigurationsDoubleLeftArrow);
                            RoomConfigurationsShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.RoomConfigurationsShowingAllRecordText, 60);
                        }

                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (RoomConfigurationsSingleRightArrowStatus.GetAttribute("class").Equals("paginate_button next disabled") || flag == 1)
                {
                    break;
                }
                else
                {
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    driver.WaitTillElementToBeClickable(ConferenceRoomLocator.RoomConfigurationsSingleRightArrow, 60);
                    js.ExecuteScript("arguments[0].click()", RoomConfigurationsSingleRightArrow);
                    RoomConfigurationsShowingAllRecordText.WaitTillVisibilityOfAllElements(driver, ConferenceRoomLocator.RoomConfigurationsShowingAllRecordText, 60);
                }
            } while (RoomConfigurationsSingleRightArrowStatus.GetAttribute("class").Equals("paginate_button next disabled") || RoomConfigurationsSingleRightArrowStatus.GetAttribute("class").Equals("paginate_button next"));

            if (flag == 1)
            {
                test.Log(LogStatus.Pass, "Available Room Configuration " + Configuration1 + " Verified Successfully!!");
            }
            else
            {
                test.Log(LogStatus.Fail, "Available Room Configuration " + Configuration1 + " Verification Failed!!");
                Assert.Fail();
            }

        }
            #endregion


        #region Edit Available Room Configurations

        public void EditAvailableRoomConfigurations(ILog log, ExtentTest test, string ExistingConfiguration, string Configuration, string SqftPerAttendee, string Description)
        {
            int flag1 = 0;
            for (int i = 0; i < ListOfAvailableRoomConfigurations.Count; i++)
            {
                if (ListOfAvailableRoomConfigurations[i].Text.Equals(ExistingConfiguration))
                {

                    IWebElement AvailableRoomConfigurationsEditButton = driver.FindElement(By.XPath("//table[@id='tblSqftMapping']/tbody/tr[" + (i + 1) + "]/td[4]/button/i[@class='fa fa-pencil']"));
                    AvailableRoomConfigurationsEditButton.Click();
                    IWebElement EditConfiguration = driver.FindElement(By.XPath("//table[@id='tblSqftMapping']/tbody/tr[" + (i + 1) + "]/td[1]//input[@type='text']"));
                    IWebElement EditSqftPerAttendee = driver.FindElement(By.XPath("//table[@id='tblSqftMapping']/tbody/tr[" + (i + 1) + "]/td[2]//input[@type='text']"));
                    IWebElement EditDescription = driver.FindElement(By.XPath("//table[@id='tblSqftMapping']/tbody/tr[" + (i + 1) + "]/td[3]//input[@type='text']"));

                    Assert.IsTrue(EditConfiguration.Displayed);
                    EditConfiguration.EnterValue(Configuration);
                    test.Log(LogStatus.Info, "Entered Configuration :" + Configuration);

                    Assert.IsTrue(EditSqftPerAttendee.Displayed);
                    EditSqftPerAttendee.EnterValue(SqftPerAttendee);
                    test.Log(LogStatus.Info, "Entered SqftPerAttendee :" + SqftPerAttendee);

                    Assert.IsTrue(EditDescription.Displayed);
                    EditDescription.EnterValue(Description);
                    test.Log(LogStatus.Info, "Entered Description : " + Description);

                    IWebElement AvailableRoomConfigurationsAcceptButton1 = driver.FindElement(By.XPath("//table[@id='tblSqftMapping']/tbody/tr[" + (i + 1) + "]/td[4]//button[@title='Save']"));
                    AvailableRoomConfigurationsAcceptButton1.Click();
                    ClickOnSubmitButton(log, test);
                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    test.Log(LogStatus.Pass, SuccessMessage.Text);
                    flag1 = 1;
                    break;
                }
            }

            //Verify updated room configuration
            if (flag1 == 1)
            {
                int flag = 0;
                for (int i = 0; i < ListOfAvailableRoomConfigurations.Count; i++)
                {
                    if (ListOfAvailableRoomConfigurations[i].Text.Equals(Configuration))
                    {

                        string SqftPerAttendees = ListOfAvailableRoomSqftPerAttendee[i].Text;
                        string Descriptions = ListOfAvailableRoomDescription[i].Text;

                        Assert.AreEqual(SqftPerAttendee, SqftPerAttendees);
                        Assert.AreEqual(Description, Descriptions);
                        flag = 1;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (flag == 1)
                {
                    test.Log(LogStatus.Pass, "Updated Room Configuration Verified Successfully!!");
                }
                else
                {
                    test.Log(LogStatus.Fail, "Updated Room Configuration Verification Failed!!");
                    Assert.Fail();
                }
            }
            else
            {
                test.Log(LogStatus.Fail, ExistingConfiguration + "is not Present in Available Room Configuration List");
            }

        }
        #endregion


        #region Delete Available Room Configuration
        public void DeleteAvailableRoomConfiguration(ILog log, ExtentTest test, string Configuration)
        {
            int flag2 = 0;

            for (int i = 0; i < ListOfAvailableRoomConfigurations.Count; i++)
            {
                if (ListOfAvailableRoomConfigurations[i].Text.Equals(Configuration))
                {

                    IWebElement RoomConfigurationDeleteButton = driver.FindElement(By.XPath("//table[@id='tblSqftMapping']/tbody/tr[" + (i + 1) + "]/td[4]/button[2]"));
                    RoomConfigurationDeleteButton.Click();
                    ClickOnSubmitButton(log, test);
                    WaitTillLoading();
                    Assert.IsTrue(SuccessMessage.Displayed);
                    test.Log(LogStatus.Pass, SuccessMessage.Text);
                    flag2 = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }

            //Verify room configuration is deleted
            if (flag2 == 1)
            {
                int flag = 0;
                for (int i = 0; i < ListOfAvailableRoomConfigurations.Count; i++)
                {
                    if (ListOfAvailableRoomConfigurations[i].Text.Equals(Configuration))
                    {
                        flag = 1;
                        break;
                    }
                    else
                    {
                        continue;

                    }
                }
                if (flag == 0)
                {
                    test.Log(LogStatus.Pass, "Deleted Room Configuration Verified Successfully!!");
                }
                else
                {
                    test.Log(LogStatus.Fail, "Deleted Room Configuration Verification Failed!! ");
                    Assert.Fail();
                }
            }
            else
            {
                test.Log(LogStatus.Fail, Configuration + "Is Not Present in List");
                Assert.Fail();
            }
        }
        #endregion
        
    }
}
