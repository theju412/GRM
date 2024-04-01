using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMAutomation.PageObjects.Locator
{
    class ConferenceRoomLocator
    {
        #region PrimaryConferenceRoom
        public const string AddPrimaryRoomsButton = "//button[@id='btnAddConferenceRooms']//i[@class='fa fa-plus'][contains(text(),'Add')]";
        public const string AddMultiplePrimaryRoomsButton = "//table[@id='tblConferenceRooms']//button[@title='Add']";
        public const string PrimaryRoomNameField = "//input[@id='txtRoomName']";
        public const string PrimaryRoomDescriptionField = "//input[@id='txtPrimaryDesc']";
        public const string PrimaryRoomMaxAttendeesField = "//input[@id='txtMaxAttendees']";
        public const string PrimaryRoomsPerHoldField = "//input[@id='txtRoomsRequired']";        
        public const string PrimaryRoomSetupCostField = "//input[@id='txtSetupCost']";        
        public const string PrimaryRoomSizeField = "//input[@id='txtSize']";       
        public const string PrimaryRoomCancelButton = "//table[@id='tblConferenceRooms']//button[@title='Cancel']";
        public const string PrimaryRoomSingleRightArrow = "//li[3][@id='tblConferenceRooms_next']/a";
        public const string PrimaryRoomSingleRightArrowStatus = "//li[3][@id='tblConferenceRooms_next']";
        public const string PrimaryRoomDoubleLeftArrowStatus = "//li[@id='tblConferenceRooms_first']";
        public const string PrimaryRoomDoubleLeftArrow = "//li[@id='tblConferenceRooms_first']/a";
        public const string PrimaryRoomShowingAllRecordText = "//div[@id='tblConferenceRooms_info'and contains(.,'Showing ')]";       
        #endregion

        #region ButtonsAndAlert
        public const string SettingsMenu = "//li[@id='mnuSettings']//a[@class='dropdown-toggle']";
        public const string ConferenceRoomsMenu = "//a[contains(text(),'Conference Rooms')]";
        public const string SelectHotelDropdown = "//span[@class='filter-option pull-left']";
        public const string SubmitButton = "//button[@id='ctl00_ContentPlaceHolder1_UC_ConferenceRooms_BtnSubmit']";
        public const string SuccessMessage = "//div[@id='dvError']";
        public const string OkButton = "//button[text()='OK']";
        public const string RoomNameRequiredMessage = "//div[@class='modal-body']//div[contains(text(),'Enter Room Name')]";
        public const string RoomNameAlreadyExistMessage = "//div[@class='modal-body']//div[contains(text(),'The RoomName you have entered is already exists')]";
        public const string MaxAttendeesRequiredMessage = "//div[@class='modal-body']//div[contains(text(),':Please Enter a valid value for  Max Attendees')]";
        public const string MaxAttendeesValidDataMessage = "//div[@class='modal-body']//div[contains(text(),':Please enter valid Max Attendees')]";
        public const string RoomsPerHoldValidDataMessage = "//div[@class='modal-body']//div[contains(text(),':Please enter valid Rooms Required')]";
        public const string SetupCostRequiredMessage = "//div[@class='modal-body']//div[contains(text(),':Please Enter a valid value for  Setup Cost')]";
        public const string SetupCostValidDataMessage = "//div[@class='modal-body']//div[contains(text(),':Please enter valid Setup Cost')]";
        public const string SizeRequiredMessage = "//div[@class='modal-body']//div[contains(text(),':Please Enter a valid value for Size')]";
        public const string SizeZeroValueMessage = "//div[@class='bootbox-body']";
        public const string SizeValidDataMessage = "//div[@class='modal-body']//div[contains(text(),':Please enter valid Size')]";
        #endregion

        #region AddMediaForPrimaryConferenceRoom
        public const string AddMediaButton = "//i[contains(text(),'Add Media')]";
        public const string AddMultipleMediaButton = "//label[@class='custom-file-upload']//i[@class='fa fa-plus']";
        public const string CloseMediaButton = "//a[@class='btn btn-danger']//span[@class='btn-label']";
        public const string AddMediaShowingAllRecordText = "//div[@id='tblMedia_info'and contains(.,'Showing ')]";
        public const string SetupHoldShowingAllRecordText = "//div[@id='tblSetupHoldPeriod_info'and contains(.,'Showing ')]";
        public const string DeleteConfirmButton = "//div[@class='modal-footer']//button[2]";
        #endregion

        #region AddMultipleLanguageDescription
        public const string AddMultipleLanguageDescriptionButton = "//i[contains(text(),'Add New')]";
        #endregion

        #region List
        public const string ListOfHotels = "//a[contains(@tabindex,'0')]";
        public const string ListOfPrimaryRoomName = "//table[@id='tblConferenceRooms']/tbody/tr/td[1]/div[2]";
        public const string ListOfPrimaryRoomDescription = "//table[@id='tblConferenceRooms']/tbody/tr/td[2]/div[2]";
        public const string ListOfPrimaryRoomMaxAttendees = "//table[@id='tblConferenceRooms']/tbody/tr/td[3]/div[2]";
        public const string ListOfPrimaryRoomsPerHold = "//table[@id='tblConferenceRooms']/tbody/tr/td[4]/div[2]";
        public const string ListOfPrimaryRoomSetUpCost = "//table[@id='tblConferenceRooms']/tbody/tr/td[5]/div[2]";
        public const string ListOfPrimaryRoomSize = "//table[@id='tblConferenceRooms']/tbody/tr/td[6]/div[2]";
        public const string ListOfPrimaryAddMediaIcon = "//table[@id='tblConferenceRooms']/tbody/tr/td[7]/div/a";
        public const string ListOfPrimaryEditButton = "//table[@id='tblConferenceRooms']/tbody/tr/td[8]/button[1]";
        public const string ListOfEditPrimaryRoomName = "//table[@id='tblConferenceRooms']/tbody/tr/td[1]//input[@type='text']";
        public const string ListOfEditPrimaryRoomDescription = "//table[@id='tblConferenceRooms']/tbody/tr/td[2]//input[@type='text']";
        public const string ListOfEditPrimaryRoomMaxAttendees = "//table[@id='tblConferenceRooms']/tbody/tr/td[3]//input[@type='text']";
        public const string ListOfEditPrimaryRoomsPerHold = "//table[@id='tblConferenceRooms']/tbody/tr/td[4]//input[@type='text']";
        public const string ListOfEditPrimaryRoomSetupCost = "//table[@id='tblConferenceRooms']/tbody/tr/td[5]//input[@type='text']";
        public const string ListOfEditPrimaryRoomSize = "//table[@id='tblConferenceRooms']/tbody/tr/td[6]//input[@type='text']";
        public const string ListOfPrimaryAcceptButton = "//table[@id='tblConferenceRooms']/tbody/tr/td[8]//button[@title='Save Room Types']";
        public const string ListOfPrimaryDeleteButton = "//table[@id='tblConferenceRooms']/tbody/tr/td[8]/button[2]";

        public const string ListOfBreakoutRoomName = "//table[@id='tblBreakOutRooms']/tbody/tr/td[1]/div[2]";
        public const string ListOfBreakoutRoomDescription = "//table[@id='tblBreakOutRooms']/tbody/tr/td[2]/div[2]";
        public const string ListOfBreakoutRoomMaxAttendees = "//table[@id='tblBreakOutRooms']/tbody/tr/td[3]/div[2]";
        public const string ListOfBreakoutRoomsPerHold = "//table[@id='tblBreakOutRooms']/tbody/tr/td[4]/div[2]";
        public const string ListOfBreakoutRoomSetUpCost = "//table[@id='tblBreakOutRooms']/tbody/tr/td[5]/div[2]";
        public const string ListOfBreakoutRoomSize = "//table[@id='tblBreakOutRooms']/tbody/tr/td[6]/div[2]";
        public const string ListOfBreakoutAddMediaIcon = "//table[@id='tblBreakOutRooms']/tbody/tr/td[7]/div/a";
        public const string ListOfBreakoutEditButton = "//table[@id='tblBreakOutRooms']/tbody/tr/td[8]/button[1]";
        public const string ListOfBreakoutAcceptButton = "//table[@id='tblBreakOutRooms']/tbody/tr/td[8]//button[@title='Save Room Types']";
        public const string ListOfBreakoutDeleteButton = "//table[@id='tblBreakOutRooms']/tbody/tr/td[8]/button[2]";

        public const string ListOfMedia = "//table[@id='tblMedia']/tbody/tr/td[1]";
        public const string ListOfDeleteMediaButton = "//table[@id='tblMedia']/tbody/tr/td[4]/div//i[@class='fa fa-trash-o']";

        public const string ListOfAvailableRoomConfigurations = "//table[@id='tblSqftMapping']/tbody/tr/td[1]/div[2]";
        public const string ListOfAvailableRoomSqftPerAttendee = "//table[@id='tblSqftMapping']/tbody/tr/td[2]/div[2]";
        public const string ListOfAvailableRoomDescription = "//table[@id='tblSqftMapping']/tbody/tr/td[3]/div[2]";
        #endregion

        #region BreakoutConferenceRoom
        public const string AddBreakoutRoomsButton = "//button[@id='btnAddBreakOutRooms']//i[@class='fa fa-plus'][contains(text(),'Add')]";
        public const string AddMultipleBreakoutRoomsButton = "//table[@id='tblBreakOutRooms']//i[@class='fa fa-plus']";
        public const string BreakoutRoomNameField = "//input[@id='txtBRRoomName']";
        public const string BreakoutRoomDescriptionField = "//input[@id='txtBRDesc']";
        public const string BreakoutRoomMaxAttendeesField = "//input[@id='txtBRMaxAttendees']";
        public const string BreakoutRoomsPerHoldField = "//input[@id='txtBRRoomsRequired']";
        public const string BreakoutRoomSetupCostField = "//input[@id='txtBRSetupCost']";
        public const string BreakoutRoomSizeField = "//input[@id='txtBRSize']";
        public const string BreakoutRoomCancelButton = "//table[@id='tblBreakOutRooms']//button[@title='Cancel']";
        public const string BreakoutRoomSingleRightArrow = "//li[3][@id='tblBreakOutRooms_next']/a";
        public const string BreakoutRoomSingleRightArrowStatus = "//li[3][@id='tblBreakOutRooms_next']";
        public const string BreakoutRoomDoubleLeftArrowStatus = "//li[@id='tblBreakOutRooms_first']";
        public const string BreakoutRoomDoubleLeftArrow = "//li[@id='tblBreakOutRooms_first']/a";
        public const string BreakoutRoomShowingAllRecordText = "//div[@id='tblBreakOutRooms_info'and contains(.,'Showing ')]";
        #endregion

        #region AvailableRoomConfigurations
        public const string AddAvailableRoomConfigurationsButton = "//button[@id='btnAddConfiguration']//i[@class='fa fa-plus'][contains(text(),'Add')]";
        public const string ConfigurationField = "//input[@id='txtSetupType']";
        public const string SqftPerAttendeeField = "//input[@id='txtSqftPerAttendee']";
        public const string DescriptionField = "//input[@id='txtDescription']";
        public const string AddMultipleAvailableRoomConfigurationsButton = "//table[@id='tblSqftMapping']/tbody/tr/td[4]/button/i[@class='fa fa-plus']";
        public const string AvailableRoomConfigurationsAcceptButton = "//table[@id='tblSqftMapping']//i[@class='icon-accept']";
        public const string RoomConfigurationsSingleRightArrow = "//li[3][@id='tblSqftMapping_next']/a";
        public const string RoomConfigurationsSingleRightArrowStatus = "//li[3][@id='tblSqftMapping_next']";
        public const string RoomConfigurationsDoubleLeftArrowStatus = "//li[@id='tblSqftMapping_first']";
        public const string RoomConfigurationsDoubleLeftArrow = "//li[@id='tblSqftMapping_first']/a";
        public const string RoomConfigurationsShowingAllRecordText = "//div[@id='tblSqftMapping_info'and contains(.,'Showing ')]";
        #endregion

        #region Wait Till 
        public const string WaitTillLoadingWheelAppears = "//img[@src='../NewGRM/images/loading.gif']";
        #endregion
    }
}

