using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMAutomation.PageObjects.Locator
{
    class GRMLoginLocator
    {
        //login page webelement
        public const string UserName = "txtUserName";
        public const string Password = "txtPassword";
        public const string LoginButton = "btnLogin";
        public const string GrmLogo = "imgGrmLogo";
        public const string ErrorMessage = "divError";
        public const string WaitTillLoadingWheelAppears = "//img[@src='../NewGRM/images/loading.gif']";

        //menu locators
        public const string Lead_Menu = "//li[@id='mnuLeads']";
        public const string Quote_Menu = "//li[@id='mnuQuotesBookings']";
        public const string Account_Menu = "//li[@id='mnuAccounts']";
        public const string Contact_Menu = "//li[@id='mnuContact']";
        public const string Events_Menu = "//li[@id='mnuEvents']";
        public const string WebBooking_Menu = "//li[@id='mnuWebBookings']";
        public const string Setting_Menu = "//li[@id='mnuSettings']";
        public const string Report_Menu = "//li[@id='mnuReports']";
        public const string Data_Menu = "//li[@id='mnuDataImport']";
        public const string Schedule_Menu = "//li[@id='mnuSchedule']";
        public const string GRMLogoAfterLogin = "//img[contains(@alt,'Logo')]";

        //Sub menu locatots
        public const string ViewWebleads = "//a[contains(.,'View Web Leads')]";
        public const string ViewInternalLeads = "//a[contains(.,'View Internal Leads')]";
        public const string CreateLead = "//a[contains(.,'Create Lead')]";
        public const string SearchLead = "//a[contains(.,'Search Lead')]";
        public const string SearchQuote = "//a[contains(.,'Search Quote')]";
        public const string CreateQuote = "//a[contains(.,'Create Quote')]";
        public const string CreateMultiQuote = "//a[contains(.,'Create Multi Quote')]";
        public const string AttendeeCrossCheck = "//a[contains(.,'Attendee Cross Check')]";
        public const string SearchAccount = "//a[contains(.,'Search Account')]";
        public const string CreateAccount = "//a[contains(.,'Create Account')]";
        public const string SearchContact = "//a[contains(.,'Search Contact')]";
        public const string CreateContact = "//a[contains(.,'Create Contact')]";
        public const string BulkEmailHistory = "//a[contains(.,'Bulk Email History')]";
        public const string SearchEvent = "//a[contains(.,'Search Events')]";
        public const string CreateEvent = "//a[contains(.,'Create Events')]";
        public const string ViewWebBooking = "//a[contains(.,'View Web Booking')]";
        public const string BulkUpload = "(//a[contains(.,'Bulk Upload')])[1]";
        public const string BulkUploadTemplate = "//a[contains(.,'Bulk Upload Templates')]";
        public const string ViewFileUpload = "//a[contains(.,'View File Upload')]";
        public const string GroupRoomCalenderReport = "//a[contains(.,'Group Room Calender')]";
        public const string FunctionDairyReport = "//a[contains(.,'Function Diary')]";
        public const string QuoteSummeryReport = "//a[contains(.,'Quote Summary')]";
        public const string QuoteDetail = "//a[contains(.,'Quote Detail')]";
        public const string PaceReport = "//a[contains(.,'Pace Report')]";
        public const string SalesTrackingReport = "//a[contains(.,'Sales Tracking Report')]";
        public const string FoodAndBeverageReport = "//a[contains(.,'Food and Beverage Report')]";
        public const string ImportData = "//a[contains(.,'Import Data')]";
        public const string ViewStausAndData = "//a[contains(.,'View Status and Data')]";
        public const string ViewTasks = "//a[contains(.,'View Tasks')]";
        public const string CreateTasks = "//a[contains(.,'Create Tasks')]";

        //Pages under setting
        public const string RoomType = "//a[contains(.,'Room Types')]";
        public const string LeadMapping = "//a[contains(.,'Lead Mapping')]";
        public const string LeadSource = "//a[contains(.,'Lead Source')]";
        public const string ConferenceRoomPricing = "//a[contains(.,'Conference Room Pricing')]";
        public const string Rules = "//a[contains(.,'Rules')]";
        public const string SpaceQuoteSettings = "//a[contains(.,'Space Quote Settings')]";
        public const string UploadRate = "//a[contains(.,'Upload Rate')]";
        public const string EmailServerSettings = "//a[contains(.,'Email Server Settings')]";
        public const string PMSIntegration = "//a[contains(.,'PMS Integration')]";
        public const string GroupReservation = "//a[contains(.,'Group Reservation')]";
        public const string SalesTracking = "(//a[contains(.,'Sales Tracking')])[2]";
        public const string FoodAndBeverage = "(//a[contains(.,'Food & Beverage')])[1]";
        public const string Localization = "//a[contains(.,'Localization')]";
        public const string Addons = "//a[contains(.,'Add-ons')]";
        public const string TaxAndServicesCharges = "//a[contains(.,'Taxes  & Service Charges')]";
        public const string MeetingPackages = "//a[contains(.,'Meeting Packages')]";
        public const string LeadScoreSettings = "//a[contains(.,'Lead Score Settings')]";
        public const string ConferenceRooms = "//a[contains(.,'Conference Rooms')]";
        public const string ConferenceGrouping = "//a[contains(.,'Conference Grouping')]";
        public const string RoomToSpaceRatio = "//a[contains(.,'Room to Space Ratio')]";
        public const string RoomQuoteSettings = "//a[contains(.,'Room Quote Settings')]";
        public const string ManageUsers = "//a[contains(.,'Manage Users')]";
        public const string Templates = "(//a[contains(.,'Templates')])[2]";
        public const string Templates_Marketplace = "//a[contains(.,'Templates')]";
        public const string OverrideRequest = "//a[contains(.,'Override Request')]";
        public const string AttendeeMobileSettings = "//a[contains(.,'Attendee Mobile Settings')]";
        public const string DataImportSettings = "//a[contains(.,'Data Import Settings')]";
        public const string FoodAndBeveragePackages = "(//a[contains(.,'Food & Beverage')])[2]";
        public const string AudioAndVisualInventory = "//a[contains(.,'A/V Inventory')]";
        public const string ManageRegions = "//a[contains(.,'Manage Regions')]";
        public const string BookingEngineSettings = "//a[contains(.,'Booking Engine Settings')]";
        public const string HotelMarketplaceSetting = "//a[contains(.,'Hotel Marketplace Settings')]";
        public const string MarketplaceWebConfiguration = "//a[contains(.,'Marketplace Web Configuration')]";
        public const string CompanyAndHotelSettings = "//a[contains(.,'Company and Hotel Settings')]";
        public const string TravelAgentPartnerSettings = "//a[contains(.,'Travel Agent Partner Settings')]";

        //logout locator
        public const string Logout = "//a[contains(.,'Log Out')]";
        public const string ArrowIcon = "//span[@class='icon-arrow-down']";

    }
}
