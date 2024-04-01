using GRMAutomation.DataReader;
using GRMAutomation.PageObjects.Locator;
using GRMAutomation.Utilities;
using log4net;
using log4net.Config;
using NUnit.Framework;
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
    class GRMLoginPage: ScreenCapturer
    {        
        #region Finding element of GRM login page

        [FindsBy(How = How.Id, Using = GRMLoginLocator.GrmLogo)]
        public IWebElement GrmLogo { get; set; }

        [FindsBy(How = How.Id, Using = GRMLoginLocator.UserName)]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = GRMLoginLocator.Password)]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = GRMLoginLocator.LoginButton)]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.Id, Using = GRMLoginLocator.ErrorMessage)]
        public IWebElement ErrorMessage { get; set; }

        //After login all menu locators

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Lead_Menu)]
        public IWebElement Lead_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Quote_Menu)]
        public IWebElement Quote_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Account_Menu)]
        public IWebElement Account_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Contact_Menu)]
        public IWebElement Contact_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Events_Menu)]
        public IWebElement Events_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.WebBooking_Menu)]
        public IWebElement WebBooking_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Setting_Menu)]
        public IWebElement Setting_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Report_Menu)]
        public IWebElement Report_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Data_Menu)]
        public IWebElement Data_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Schedule_Menu)]
        public IWebElement Schedule_Menu { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.GRMLogoAfterLogin)]
        public IWebElement GRMLogoAfterLogin { get; set; }

        //Sub menu locators

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.ViewWebleads)]
        public IWebElement ViewWebleads { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.ViewInternalLeads)]
        public IWebElement ViewInternalLeads { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.CreateLead)]
        public IWebElement CreateLead { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.SearchLead)]
        public IWebElement SearchLead { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.SearchQuote)]
        public IWebElement SearchQuote { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.CreateQuote)]
        public IWebElement CreateQuote { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.CreateMultiQuote)]
        public IWebElement CreateMultiQuote { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.AttendeeCrossCheck)]
        public IWebElement AttendeeCrossCheck { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.SearchAccount)]
        public IWebElement SearchAccount { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.CreateAccount)]
        public IWebElement CreateAccount { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.SearchContact)]
        public IWebElement SearchContact { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.CreateContact)]
        public IWebElement CreateContact { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.BulkEmailHistory)]
        public IWebElement BulkEmailHistory { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.SearchEvent)]
        public IWebElement SearchEvent { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.CreateEvent)]
        public IWebElement CreateEvent { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.ViewWebBooking)]
        public IWebElement ViewWebBooking { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.BulkUpload)]
        public IWebElement BulkUpload { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.BulkUploadTemplate)]
        public IWebElement BulkUploadTemplate { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.ViewFileUpload)]
        public IWebElement ViewFileUpload { get; set; }

        // Report locators

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.GroupRoomCalenderReport)]
        public IWebElement GroupRoomCalenderReport { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.FunctionDairyReport)]
        public IWebElement FunctionDairyReport { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.QuoteSummeryReport)]
        public IWebElement QuoteSummeryReport { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.QuoteDetail)]
        public IWebElement QuoteDetail { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.PaceReport)]
        public IWebElement PaceReport { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.SalesTrackingReport)]
        public IWebElement SalesTrackingReport { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.FoodAndBeverageReport)]
        public IWebElement FoodAndBeverageReport { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.ImportData)]
        public IWebElement ImportData { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.ViewStausAndData)]
        public IWebElement ViewStausAndData { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.ViewTasks)]
        public IWebElement ViewTasks { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.CreateTasks)]
        public IWebElement CreateTasks { get; set; }

        //Locators of submenu of setting menu

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.RoomType)]
        public IWebElement RoomType { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.LeadMapping)]
        public IWebElement LeadMapping { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.LeadSource)]
        public IWebElement LeadSource { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.ConferenceRoomPricing)]
        public IWebElement ConferenceRoomPricing { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Rules)]
        public IWebElement Rules { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.SpaceQuoteSettings)]
        public IWebElement SpaceQuoteSettings { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.UploadRate)]
        public IWebElement UploadRate { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.EmailServerSettings)]
        public IWebElement EmailServerSettings { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.PMSIntegration)]
        public IWebElement PMSIntegration { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.GroupReservation)]
        public IWebElement GroupReservation { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.SalesTracking)]
        public IWebElement SalesTracking { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.FoodAndBeverage)]
        public IWebElement FoodAndBeverage { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Localization)]
        public IWebElement Localization { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Addons)]
        public IWebElement Addons { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.TaxAndServicesCharges)]
        public IWebElement TaxAndServicesCharges { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.MeetingPackages)]
        public IWebElement MeetingPackages { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.LeadScoreSettings)]
        public IWebElement LeadScoreSettings { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.ConferenceRooms)]
        public IWebElement ConferenceRooms { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.ConferenceGrouping)]
        public IWebElement ConferenceGrouping { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.RoomToSpaceRatio)]
        public IWebElement RoomToSpaceRatio { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.RoomQuoteSettings)]
        public IWebElement RoomQuoteSettings { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.ManageUsers)]
        public IWebElement ManageUsers { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Templates)]
        public IWebElement Templates { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.OverrideRequest)]
        public IWebElement OverrideRequest { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.AttendeeMobileSettings)]
        public IWebElement AttendeeMobileSettings { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.DataImportSettings)]
        public IWebElement DataImportSettings { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.FoodAndBeveragePackages)]
        public IWebElement FoodAndBeveragePackages { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.AudioAndVisualInventory)]
        public IWebElement AudioAndVisualInventory { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.ManageRegions)]
        public IWebElement ManageRegions { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.BookingEngineSettings)]
        public IWebElement BookingEngineSettings { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.HotelMarketplaceSetting)]
        public IWebElement HotelMarketplaceSetting { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.MarketplaceWebConfiguration)]
        public IWebElement MarketplaceWebConfiguration { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.CompanyAndHotelSettings)]
        public IWebElement CompanyAndHotelSettings { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.TravelAgentPartnerSettings)]
        public IWebElement TravelAgentPartnerSettings { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Templates_Marketplace)]
        public IWebElement Templates_Marketplace { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.Logout)]
        public IWebElement Logout { get; set; }

        [FindsBy(How = How.XPath, Using = GRMLoginLocator.ArrowIcon)]
        public IWebElement ArrowIcon { get; set; }

        #endregion

        #region Initialization of web page element
        public GRMLoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        #endregion

        #region Verifying GRM logo in login page
        public void IsGRMLogoPresent(ILog log, ExtentTest test)
        {
            LoginButton.WaitTillElementToBeClickable(driver, 60);           
            Assert.IsTrue(GrmLogo.Displayed);
            log.Info("GRM Logo is displayed in Login Page");
            test.Log(LogStatus.Pass, "GRM Logo is displayed in Login Page");
        }
        #endregion

        #region Passing User Name
        public void SetUserName(string userName, ILog log, ExtentTest test)
        {
            
            LoginButton.WaitTillElementToBeClickable(driver, 60);
            Assert.IsTrue(UserName.Displayed);
            log.Info("User name field is displaying ");
            test.Log(LogStatus.Pass, "User name field is displaying");
            
            UserName.EnterValue(userName);
            log.Info("User name has been entred ");
            test.Log(LogStatus.Pass, "User name has been entred");
        }
        #endregion

        #region Passing password
        public void SetPassword(ILog log, ExtentTest test, string password)        {
            
            IJavaScriptExecutor javascriptExecutor = (IJavaScriptExecutor)driver;
            string jsString = "document.getElementById('" + GRMLoginLocator.Password + "').value='" + password + "'";
            javascriptExecutor.ExecuteScript(jsString);
            
            log.Info("Password entered successfully");
            test.Log(LogStatus.Info, "Password entered successfully");
        }
        #endregion

        #region Clicking on login button
        public void ClickLoginButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(LoginButton.Displayed);
            LoginButton.ClickOn(driver, 90);
            log.Info("clicked on login button");
            test.Log(LogStatus.Info, "clicked on login button");
        }
        #endregion

        #region Verify HomePage after login
        public void IsHomePageDisplayed()
        {            
            driver.WaitTillPresenceOfAllElements(GRMLoginLocator.GRMLogoAfterLogin, 60);
            if (GRMLogoAfterLogin.Displayed)
            {
                test.Log(LogStatus.Pass, "HomePage Logo Appeared");                
            }

            test.Log(LogStatus.Fail, "There is come issue in loading HomePage");
            Assert.Fail();            
        }

        #endregion

        #region Verify invalid username and password
        public void EnterInvalidUserNameAndPassword(ILog log, ExtentTest test)
        {
            int row_count = ExcelReaderHelper.GetTotalRows(fileLocation, "InvalidCredentials");
            for (int i = 2; i < row_count; i++)
            {
                string uName = ExcelReaderHelper.GetCellData(fileLocation, "InValidCredentials", i, 0).ToString();
                string password1 = ExcelReaderHelper.GetCellData(fileLocation, "InValidCredentials", i, 1).ToString();

                UserName.SendKeys(Keys.Control + "a"+Keys.Delete);                
                UserName.WaitTillElementToBeClickable(driver, 60);
                UserName.EnterValue(uName);

                IJavaScriptExecutor javascriptExecutor = (IJavaScriptExecutor)driver;
                string jsString = "document.getElementById('" + GRMLoginLocator.Password + "').value='" + password1 + "'";
                javascriptExecutor.ExecuteScript(jsString);
                
                LoginButton.ClickOn(driver, 60);

                LoginButton.WaitTillElementToBeClickable(driver, 60);
                Assert.IsTrue(ErrorMessage.Displayed);
                Assert.AreEqual("Incorrect Credentials.", ErrorMessage.Text);

                log.Info("Enterd UserName: " + uName + ", Password: " + password1);
                log.Info(ErrorMessage.Text);

                test.Log(LogStatus.Info, "Enterd UserName: " + uName + ", Password: " + password1);
                test.Log(LogStatus.Info, ErrorMessage.Text);                

            }
        }
        #endregion

        //#region
        //public void WaitTillLoading()
        //{
        //    try
        //    {
        //        wait = driver.WaitForSpecificElement();
        //        wait.Until(driver => !driver.FindElement(By.XPath(GRMLoginLocator.WaitTillLoadingWheelAppears)).Displayed);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        //#endregion

        #region Verify Pages Based on user role for GRM company
        public void PageVerificationBasedOnUserRole(ILog log, ExtentTest test)
        {
            int row_count = ExcelReaderHelper.GetTotalRows(fileLocation, "ValidCredentials");
            for (int i = 5; i < row_count; i++)
            {
                string uName = ExcelReaderHelper.GetCellData(fileLocation, "ValidCredentials", i, 0).ToString();
                string password1 = ExcelReaderHelper.GetCellData(fileLocation, "ValidCredentials", i, 1).ToString();

                UserName.SendKeys(Keys.Control + "a"+Keys.Delete);                
                UserName.WaitTillElementToBeClickable(driver, 60);
                UserName.EnterValue(uName);

                IJavaScriptExecutor javascriptExecutor = (IJavaScriptExecutor)driver;
                string jsString = "document.getElementById('" + GRMLoginLocator.Password + "').value='" + password1 + "'";
                javascriptExecutor.ExecuteScript(jsString);

                LoginButton.ClickOn(driver, 60);

                dataSet = DBConnection.GetDBData("select u.Email,u.IsAdmin,ur.RoleName from [user] u inner join  User_Role_Default ur  on u.IsAdmin = ur.Id");

                List<string> listEmailAddress = new List<string>();
                List<string> User_Role = new List<string>();

                for (int j = 0; j < dataSet.Tables[0].Rows.Count; j++)
                {
                    listEmailAddress.Add(dataSet.Tables[0].Rows[j]["Email"].ToString());
                    User_Role.Add(dataSet.Tables[0].Rows[j]["RoleName"].ToString());
                }

                for (int j = 0; j < listEmailAddress.Count; j++)
                {
                    Console.WriteLine(listEmailAddress[j].ToString());
                    Console.WriteLine(User_Role[j].ToString());

                    if (uName.Equals(listEmailAddress[j]) && User_Role[j].Equals("Super Admin"))
                    {
                        test.Log(LogStatus.Info, "Logged In User Email: "+listEmailAddress[j].ToString());
                        test.Log(LogStatus.Info,"Logged in User Role is "+ User_Role[j].ToString());

                        Assert.IsTrue(Lead_Menu.Displayed);
                        log.Info("Lead Menu is displaying");
                        test.Log(LogStatus.Info, "Lead Menu is displaying");

                        Assert.IsTrue(Quote_Menu.Displayed);
                        log.Info("Quote Menu is displaying");
                        test.Log(LogStatus.Info, "Quote Menu is displaying");

                        Assert.IsTrue(Account_Menu.Displayed);
                        log.Info("Account Menu is displaying");
                        test.Log(LogStatus.Info, "Account Menu is displaying");

                        Assert.IsTrue(Contact_Menu.Displayed);
                        log.Info("Contact Menu is displaying");
                        test.Log(LogStatus.Info, "Contact Menu is displaying");

                        Assert.IsTrue(Events_Menu.Displayed);
                        log.Info("Event Menu is displaying");
                        test.Log(LogStatus.Info, "Event Menu is displaying");

                        Assert.IsTrue(WebBooking_Menu.Displayed);
                        log.Info("Webooking Menu is displaying");
                        test.Log(LogStatus.Info, "Webooking Menu is displaying");

                        Assert.IsTrue(Setting_Menu.Displayed);
                        log.Info("Setting Menu is displaying");
                        test.Log(LogStatus.Info, "Setting Menu is displaying");

                        Assert.IsTrue(Report_Menu.Displayed);
                        log.Info("Report Menu is displaying");
                        test.Log(LogStatus.Info, "Report Menu is displaying");

                        Assert.IsTrue(Data_Menu.Displayed);
                        log.Info("Data Menu is displaying");
                        test.Log(LogStatus.Info, "Data Menu is displaying");

                        Assert.IsTrue(Schedule_Menu.Displayed);
                        log.Info("Schedule Menu is displaying");
                        test.Log(LogStatus.Info, "Schedule Menu is displaying");

                        Assert.IsTrue(GRMLogoAfterLogin.Displayed);
                        log.Info("GRM logo is displaying");
                        test.Log(LogStatus.Info, "GRM Logo is displaying");

                        Lead_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(ViewWebleads.Displayed);
                        log.Info("View web lead page is displaying");
                        test.Log(LogStatus.Info, "View web lead page is displaying");

                        Assert.IsTrue(ViewInternalLeads.Displayed);
                        log.Info("View internal lead page is displaying");
                        test.Log(LogStatus.Info, "View internal lead page is displaying");

                        Assert.IsTrue(CreateLead.Displayed);
                        log.Info("Create lead page is displaying");
                        test.Log(LogStatus.Info, "Create lead page is displaying");

                        Assert.IsTrue(SearchLead.Displayed);
                        log.Info("Search lead page is displaying");
                        test.Log(LogStatus.Info, "Search lead page is displaying");

                        Quote_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(SearchQuote.Displayed);
                        log.Info("Search quote page is displaying");
                        test.Log(LogStatus.Info, "Search quote page is displaying");

                        Assert.IsTrue(CreateQuote.Displayed);
                        log.Info("Create quote page is displaying");
                        test.Log(LogStatus.Info, "Create quote page is displaying");

                        Assert.IsTrue(CreateMultiQuote.Displayed);
                        log.Info("Create multi quote page is displaying");
                        test.Log(LogStatus.Info, "Create multi quote page is displaying");

                        Assert.IsTrue(AttendeeCrossCheck.Displayed);
                        log.Info("Attendee Cross Check page is displaying");
                        test.Log(LogStatus.Info, "Attendee Cross Check page is displaying");

                        Account_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(SearchAccount.Displayed);
                        log.Info("Search Account page is displaying");
                        test.Log(LogStatus.Info, "Search Account page is displaying");

                        Assert.IsTrue(CreateAccount.Displayed);
                        log.Info("Create Account page is displaying");
                        test.Log(LogStatus.Info, "Create Account page is displaying");

                        Contact_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(SearchContact.Displayed);
                        log.Info("Search contact page is displaying");
                        test.Log(LogStatus.Info, "Search Contact page is displaying");

                        Assert.IsTrue(CreateContact.Displayed);
                        log.Info("Create Contact page is displaying");
                        test.Log(LogStatus.Info, "Create Contact page is displaying");

                        Assert.IsTrue(BulkEmailHistory.Displayed);
                        log.Info("BulkEmailHistory page is displaying");
                        test.Log(LogStatus.Info, "BulkEmailHistory page is displaying");

                        Events_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(SearchEvent.Displayed);
                        log.Info("Search Event page is displaying");
                        test.Log(LogStatus.Info, "Search Event page is displaying");

                        Assert.IsTrue(CreateEvent.Displayed);
                        log.Info("Create Event page is displaying");
                        test.Log(LogStatus.Info, "Create Event page is displaying");

                        WebBooking_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(ViewWebBooking.Displayed);
                        log.Info("View Web Booking page is displaying");
                        test.Log(LogStatus.Info, "View Web Booking page is displaying");

                        Assert.IsTrue(BulkUpload.Displayed);
                        log.Info("BulkUpload page is displaying");
                        test.Log(LogStatus.Info, "BulkUpload page is displaying");

                        Assert.IsTrue(BulkUploadTemplate.Displayed);
                        log.Info("Bulk Upload Template page is displaying");
                        test.Log(LogStatus.Info, "Bulk Upload Template page is displaying");

                        Assert.IsTrue(ViewFileUpload.Displayed);
                        log.Info("View File Upload page is displaying");
                        test.Log(LogStatus.Info, "View File Upload page is displaying");

                        Report_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(GroupRoomCalenderReport.Displayed);
                        log.Info("Group Room CalenderReport page is displaying");
                        test.Log(LogStatus.Info, "Group Room CalenderReport page is displaying");

                        Assert.IsTrue(FunctionDairyReport.Displayed);
                        log.Info("Function Dairy Report page is displaying");
                        test.Log(LogStatus.Info, "Function Dairy Report page is displaying");

                        Assert.IsTrue(QuoteSummeryReport.Displayed);
                        log.Info("Quote Summery Report page is displaying");
                        test.Log(LogStatus.Info, "Quote Summery Report page is displaying");

                        Assert.IsTrue(QuoteDetail.Displayed);
                        log.Info("Quote Detail report page is displaying");
                        test.Log(LogStatus.Info, "Quote Detail report page is displaying");

                        Assert.IsTrue(PaceReport.Displayed);
                        log.Info("Pace Report page is displaying");
                        test.Log(LogStatus.Info, "Pace Report page is displaying");

                        Assert.IsTrue(SalesTrackingReport.Displayed);
                        log.Info("Sales Tracking Report page is displaying");
                        test.Log(LogStatus.Info, "Sales Tracking Report page is displaying");

                        Assert.IsTrue(FoodAndBeverageReport.Displayed);
                        log.Info("FoodAndBeverage Report page is displaying");
                        test.Log(LogStatus.Info, "FoodAndBeverage Report page is displaying");

                        Data_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(ImportData.Displayed);
                        log.Info("Import Data page is displaying");
                        test.Log(LogStatus.Info, "Import Data page is displaying");

                        Assert.IsTrue(ViewStausAndData.Displayed);
                        log.Info("View Staus And Data page is displaying");
                        test.Log(LogStatus.Info, "View Staus And Data page is displaying");

                        Schedule_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(ViewTasks.Displayed);
                        log.Info("View Tasks page is displaying");
                        test.Log(LogStatus.Info, "View Tasks page is displaying");

                        Assert.IsTrue(CreateTasks.Displayed);
                        log.Info("Create Tasks page is displaying");
                        test.Log(LogStatus.Info, "Create Tasks page is displaying");

                        Setting_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(RoomType.Displayed);
                        log.Info("RoomType page is displaying");
                        test.Log(LogStatus.Info, "RoomType page is displaying");

                        Assert.IsTrue(LeadMapping.Displayed);
                        log.Info("Leaad Mapping page is displaying");
                        test.Log(LogStatus.Info, "Leaad Mapping page is displaying");

                        Assert.IsTrue(LeadSource.Displayed);
                        log.Info("Lead Source page is displaying");
                        test.Log(LogStatus.Info, "Lead Source page is displaying");

                        Assert.IsTrue(ConferenceRoomPricing.Displayed);
                        log.Info("Conference Room Pricing page is displaying");
                        test.Log(LogStatus.Info, "Conference Room Pricing page is displaying");

                        Assert.IsTrue(Rules.Displayed);
                        log.Info("Rules page is displaying");
                        test.Log(LogStatus.Info, "Rules page is displaying");

                        Assert.IsTrue(SpaceQuoteSettings.Displayed);
                        log.Info("Space Quote Settings page is displaying");
                        test.Log(LogStatus.Info, "Space Quote Settings page is displaying");

                        Assert.IsTrue(UploadRate.Displayed);
                        log.Info("Upload Rate page is displaying");
                        test.Log(LogStatus.Info, "Upload Rate page is displaying");

                        Assert.IsTrue(EmailServerSettings.Displayed);
                        log.Info("Email ServerS settings page is displaying");
                        test.Log(LogStatus.Info, "Email Server Settings page is displaying");

                        Assert.IsTrue(PMSIntegration.Displayed);
                        log.Info("PMS Integration page is displaying");
                        test.Log(LogStatus.Info, "PMS Integration page is displaying");

                        Assert.IsTrue(GroupReservation.Displayed);
                        log.Info("GroupR reservation page is displaying");
                        test.Log(LogStatus.Info, "Group Reservation page is displaying");

                        Assert.IsTrue(SalesTracking.Displayed);
                        log.Info("Sales Tracking page is displaying");
                        test.Log(LogStatus.Info, "Sales Tracking page is displaying");

                        Assert.IsTrue(FoodAndBeverage.Displayed);
                        log.Info("Food And Beverage page is displaying");
                        test.Log(LogStatus.Info, "Food And Beverage page is displaying");

                        Assert.IsTrue(Localization.Displayed);
                        log.Info("Localization page is displaying");
                        test.Log(LogStatus.Info, "Localization page is displaying");

                        Assert.IsTrue(Addons.Displayed);
                        log.Info("Addons page is displaying");
                        test.Log(LogStatus.Info, "Addons page is displaying");

                        Assert.IsTrue(TaxAndServicesCharges.Displayed);
                        log.Info("Tax And Services Charges page is displaying");
                        test.Log(LogStatus.Info, "Tax And Services Charges page is displaying");

                        Assert.IsTrue(MeetingPackages.Displayed);
                        log.Info("MeetingPackages page is displaying");
                        test.Log(LogStatus.Info, "MeetingPackages page is displaying");

                        Assert.IsTrue(LeadScoreSettings.Displayed);
                        log.Info("Lead Score Settings page is displaying");
                        test.Log(LogStatus.Info, "Lead Score Settings page is displaying");

                        Assert.IsTrue(ConferenceRooms.Displayed);
                        log.Info("Conference Rooms page is displaying");
                        test.Log(LogStatus.Info, "Conference Rooms page is displaying");

                        Assert.IsTrue(ConferenceGrouping.Displayed);
                        log.Info("Conference Grouping page is displaying");
                        test.Log(LogStatus.Info, "Conference Grouping page is displaying");

                        Assert.IsTrue(RoomToSpaceRatio.Displayed);
                        log.Info("RoomToSpaceRatio is displaying");
                        test.Log(LogStatus.Info, "RoomToSpaceRatio is displaying");

                        Assert.IsTrue(RoomQuoteSettings.Displayed);
                        log.Info("Room Quote Settings page is displaying");
                        test.Log(LogStatus.Info, "Room Quote Settings page is displaying");

                        Assert.IsTrue(ManageUsers.Displayed);
                        log.Info("Manage Users page is displaying");
                        test.Log(LogStatus.Info, "Manage Users page is displaying");

                        Assert.IsTrue(Templates.Displayed);
                        log.Info("Templates page is displaying");
                        test.Log(LogStatus.Info, "Templates page is displaying");

                        Assert.IsTrue(OverrideRequest.Displayed);
                        log.Info("Override Request page is displaying");
                        test.Log(LogStatus.Info, "Override Request page is displaying");

                        Assert.IsTrue(AttendeeMobileSettings.Displayed);
                        log.Info("Attendee Mobile Settings page is displaying");
                        test.Log(LogStatus.Info, "Attendee Mobile Settings page is displaying");

                        Assert.IsTrue(DataImportSettings.Displayed);
                        log.Info("Data Import Settings page is displaying");
                        test.Log(LogStatus.Info, "Data Import Settings page is displaying");

                        Assert.IsTrue(FoodAndBeveragePackages.Displayed);
                        log.Info("Food And Beverage Packages page is displaying");
                        test.Log(LogStatus.Info, "Food And Beverage Packages page is displaying");

                        Assert.IsTrue(AudioAndVisualInventory.Displayed);
                        log.Info("Audio And Visual Inventory page is displaying");
                        test.Log(LogStatus.Info, "Audio And Visual Inventory page is displaying");

                        Assert.IsTrue(ManageRegions.Displayed);
                        log.Info("Manage Regions page is displaying");
                        test.Log(LogStatus.Info, "Manage Regions page is displaying");

                        Assert.IsTrue(BookingEngineSettings.Displayed);
                        log.Info("Booking Engine Settings page is displaying");
                        test.Log(LogStatus.Info, "Booking Engine Settings page is displaying");

                        Assert.IsTrue(CompanyAndHotelSettings.Displayed);
                        log.Info("Company And Hotel Settings  page is displaying");
                        test.Log(LogStatus.Info, "Company And Hotel Setting page is displaying");

                        

                        ClickOnLogOut(log, test);
                        break;
                    }

                    if (uName.Equals(listEmailAddress[j]) && User_Role[j].Equals("Revenue Manager"))
                    {
                        test.Log(LogStatus.Info, "Logged In User Email: " + listEmailAddress[j].ToString());
                        test.Log(LogStatus.Info, "Logged in User Role is " + User_Role[j].ToString());

                        Assert.IsTrue(Lead_Menu.Displayed);
                        log.Info("Lead Menu is displaying");
                        test.Log(LogStatus.Info, "Lead Menu is displaying");

                        Assert.IsTrue(Quote_Menu.Displayed);
                        log.Info("Quote Menu is displaying");
                        test.Log(LogStatus.Info, "Quote Menu is displaying");

                        Assert.IsTrue(Account_Menu.Displayed);
                        log.Info("Account Menu is displaying");
                        test.Log(LogStatus.Info, "Account Menu is displaying");

                        Assert.IsTrue(Contact_Menu.Displayed);
                        log.Info("Contact Menu is displaying");
                        test.Log(LogStatus.Info, "Contact Menu is displaying");

                        Assert.IsTrue(Events_Menu.Displayed);
                        log.Info("Event Menu is displaying");
                        test.Log(LogStatus.Info, "Event Menu is displaying");

                        Assert.IsTrue(WebBooking_Menu.Displayed);
                        log.Info("Webooking Menu is displaying");
                        test.Log(LogStatus.Info, "Webooking Menu is displaying");

                        Assert.IsTrue(Setting_Menu.Displayed);
                        log.Info("Setting Menu is displaying");
                        test.Log(LogStatus.Info, "Setting Menu is displaying");

                        Assert.IsTrue(Report_Menu.Displayed);
                        log.Info("Report Menu is displaying");
                        test.Log(LogStatus.Info, "Report Menu is displaying");

                        Assert.IsTrue(Data_Menu.Displayed);
                        log.Info("Data Menu is displaying");
                        test.Log(LogStatus.Info, "Data Menu is displaying");

                        Assert.IsTrue(Schedule_Menu.Displayed);
                        log.Info("Schedule Menu is displaying");
                        test.Log(LogStatus.Info, "Schedule Menu is displaying");

                        Assert.IsTrue(GRMLogoAfterLogin.Displayed);
                        log.Info("GRM logo is displaying");
                        test.Log(LogStatus.Info, "GRM Logo is displaying");

                        Lead_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(CreateLead.Displayed);
                        log.Info("Create lead page is displaying");
                        test.Log(LogStatus.Info, "Create lead page is displaying");

                        Quote_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(SearchQuote.Displayed);
                        log.Info("Search quote page is displaying");
                        test.Log(LogStatus.Info, "Search quote page is displaying");

                        Assert.IsTrue(CreateQuote.Displayed);
                        log.Info("Create quote page is displaying");
                        test.Log(LogStatus.Info, "Create quote page is displaying");

                        Assert.IsTrue(CreateMultiQuote.Displayed);
                        log.Info("Create multi quote page is displaying");
                        test.Log(LogStatus.Info, "Create multi quote page is displaying");

                        Assert.IsTrue(AttendeeCrossCheck.Displayed);
                        log.Info("Attendee Cross Check page is displaying");
                        test.Log(LogStatus.Info, "Attendee Cross Check page is displaying");

                        WebBooking_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(ViewWebBooking.Displayed);
                        log.Info("View Web Booking page is displaying");
                        test.Log(LogStatus.Info, "View Web Booking page is displaying");

                        Assert.IsTrue(BulkUpload.Displayed);
                        log.Info("BulkUpload page is displaying");
                        test.Log(LogStatus.Info, "BulkUpload page is displaying");

                        Assert.IsTrue(BulkUploadTemplate.Displayed);
                        log.Info("Bulk Upload Template page is displaying");
                        test.Log(LogStatus.Info, "Bulk Upload Template page is displaying");

                        Assert.IsTrue(ViewFileUpload.Displayed);
                        log.Info("View File Upload page is displaying");
                        test.Log(LogStatus.Info, "View File Upload page is displaying");

                        Report_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(GroupRoomCalenderReport.Displayed);
                        log.Info("Group Room CalenderReport page is displaying");
                        test.Log(LogStatus.Info, "Group Room CalenderReport page is displaying");

                        Assert.IsTrue(FunctionDairyReport.Displayed);
                        log.Info("Function Dairy Report page is displaying");
                        test.Log(LogStatus.Info, "Function Dairy Report page is displaying");

                        Assert.IsTrue(QuoteSummeryReport.Displayed);
                        log.Info("Quote Summery Report page is displaying");
                        test.Log(LogStatus.Info, "Quote Summery Report page is displaying");

                        Assert.IsTrue(QuoteDetail.Displayed);
                        log.Info("Quote Detail report page is displaying");
                        test.Log(LogStatus.Info, "Quote Detail report page is displaying");

                        Assert.IsTrue(PaceReport.Displayed);
                        log.Info("Pace Report page is displaying");
                        test.Log(LogStatus.Info, "Pace Report page is displaying");

                        Assert.IsTrue(FoodAndBeverageReport.Displayed);
                        log.Info("FoodAndBeverage Report page is displaying");
                        test.Log(LogStatus.Info, "FoodAndBeverage Report page is displaying");

                        Data_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(ImportData.Displayed);
                        log.Info("Import Data page is displaying");
                        test.Log(LogStatus.Info, "Import Data page is displaying");

                        Assert.IsTrue(ViewStausAndData.Displayed);
                        log.Info("View Staus And Data page is displaying");
                        test.Log(LogStatus.Info, "View Staus And Data page is displaying");

                        Setting_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(RoomType.Displayed);
                        log.Info("RoomType page is displaying");
                        test.Log(LogStatus.Info, "RoomType page is displaying");

                        Assert.IsTrue(LeadMapping.Displayed);
                        log.Info("Leaad Mapping page is displaying");
                        test.Log(LogStatus.Info, "Leaad Mapping page is displaying");

                        Assert.IsTrue(LeadSource.Displayed);
                        log.Info("Lead Source page is displaying");
                        test.Log(LogStatus.Info, "Lead Source page is displaying");

                        Assert.IsTrue(ConferenceRoomPricing.Displayed);
                        log.Info("Conference Room Pricing page is displaying");
                        test.Log(LogStatus.Info, "Conference Room Pricing page is displaying");

                        Assert.IsTrue(Rules.Displayed);
                        log.Info("Rules page is displaying");
                        test.Log(LogStatus.Info, "Rules page is displaying");

                        Assert.IsTrue(SpaceQuoteSettings.Displayed);
                        log.Info("Space Quote Settings page is displaying");
                        test.Log(LogStatus.Info, "Space Quote Settings page is displaying");

                        Assert.IsTrue(UploadRate.Displayed);
                        log.Info("Upload Rate page is displaying");
                        test.Log(LogStatus.Info, "Upload Rate page is displaying");

                        Assert.IsTrue(GroupReservation.Displayed);
                        log.Info("GroupR reservation page is displaying");
                        test.Log(LogStatus.Info, "Group Reservation page is displaying");

                        Assert.IsTrue(Localization.Displayed);
                        log.Info("Localization page is displaying");
                        test.Log(LogStatus.Info, "Localization page is displaying");

                        Assert.IsTrue(Addons.Displayed);
                        log.Info("Addons page is displaying");
                        test.Log(LogStatus.Info, "Addons page is displaying");

                        Assert.IsTrue(TaxAndServicesCharges.Displayed);
                        log.Info("Tax And Services Charges page is displaying");
                        test.Log(LogStatus.Info, "Tax And Services Charges page is displaying");

                        Assert.IsTrue(LeadScoreSettings.Displayed);
                        log.Info("Lead Score Settings page is displaying");
                        test.Log(LogStatus.Info, "Lead Score Settings page is displaying");

                        Assert.IsTrue(ConferenceRooms.Displayed);
                        log.Info("Conference Rooms page is displaying");
                        test.Log(LogStatus.Info, "Conference Rooms page is displaying");

                        Assert.IsTrue(ConferenceGrouping.Displayed);
                        log.Info("Conference Grouping page is displaying");
                        test.Log(LogStatus.Info, "Conference Grouping page is displaying");

                        Assert.IsTrue(RoomToSpaceRatio.Displayed);
                        log.Info("RoomToSpaceRatio is displaying");
                        test.Log(LogStatus.Info, "RoomToSpaceRatio is displaying");

                        Assert.IsTrue(RoomQuoteSettings.Displayed);
                        log.Info("Room Quote Settings page is displaying");
                        test.Log(LogStatus.Info, "Room Quote Settings page is displaying");

                        Assert.IsTrue(OverrideRequest.Displayed);
                        log.Info("Override Request page is displaying");
                        test.Log(LogStatus.Info, "Override Request page is displaying");

                        Assert.IsTrue(AttendeeMobileSettings.Displayed);
                        log.Info("Attendee Mobile Settings page is displaying");
                        test.Log(LogStatus.Info, "Attendee Mobile Settings page is displaying");

                        Assert.IsTrue(DataImportSettings.Displayed);
                        log.Info("Data Import Settings page is displaying");
                        test.Log(LogStatus.Info, "Data Import Settings page is displaying");

                        Assert.IsTrue(AudioAndVisualInventory.Displayed);
                        log.Info("Audio And Visual Inventory page is displaying");
                        test.Log(LogStatus.Info, "Audio And Visual Inventory page is displaying");

                        ClickOnLogOut(log, test);
                        break;
                    }

                    if (uName.Equals(listEmailAddress[j]) && User_Role[j].Equals("Catering Manager"))
                    {
                        test.Log(LogStatus.Info, "Logged In User Email: " + listEmailAddress[j].ToString());
                        test.Log(LogStatus.Info, "Logged in User Role is " + User_Role[j].ToString());

                        Assert.IsTrue(Lead_Menu.Displayed);
                        log.Info("Lead Menu is displaying");
                        test.Log(LogStatus.Info, "Lead Menu is displaying");

                        Assert.IsTrue(Quote_Menu.Displayed);
                        log.Info("Quote Menu is displaying");
                        test.Log(LogStatus.Info, "Quote Menu is displaying");

                        Assert.IsTrue(Account_Menu.Displayed);
                        log.Info("Account Menu is displaying");
                        test.Log(LogStatus.Info, "Account Menu is displaying");

                        Assert.IsTrue(Contact_Menu.Displayed);
                        log.Info("Contact Menu is displaying");
                        test.Log(LogStatus.Info, "Contact Menu is displaying");

                        Assert.IsTrue(Events_Menu.Displayed);
                        log.Info("Event Menu is displaying");
                        test.Log(LogStatus.Info, "Event Menu is displaying");

                        Assert.IsTrue(WebBooking_Menu.Displayed);
                        log.Info("Webooking Menu is displaying");
                        test.Log(LogStatus.Info, "Webooking Menu is displaying");

                        Assert.IsTrue(Setting_Menu.Displayed);
                        log.Info("Setting Menu is displaying");
                        test.Log(LogStatus.Info, "Setting Menu is displaying");

                        Assert.IsTrue(Report_Menu.Displayed);
                        log.Info("Report Menu is displaying");
                        test.Log(LogStatus.Info, "Report Menu is displaying");

                        Assert.IsTrue(Data_Menu.Displayed);
                        log.Info("Data Menu is displaying");
                        test.Log(LogStatus.Info, "Data Menu is displaying");

                        Assert.IsTrue(Schedule_Menu.Displayed);
                        log.Info("Schedule Menu is displaying");
                        test.Log(LogStatus.Info, "Schedule Menu is displaying");

                        Assert.IsTrue(GRMLogoAfterLogin.Displayed);
                        log.Info("GRM logo is displaying");
                        test.Log(LogStatus.Info, "GRM Logo is displaying");

                        Quote_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(SearchQuote.Displayed);
                        log.Info("Search quote page is displaying");
                        test.Log(LogStatus.Info, "Search quote page is displaying");

                        Events_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(SearchEvent.Displayed);
                        log.Info("Search Event page is displaying");
                        test.Log(LogStatus.Info, "Search Event page is displaying");

                        Assert.IsTrue(CreateEvent.Displayed);
                        log.Info("Create Event page is displaying");
                        test.Log(LogStatus.Info, "Create Event page is displaying");

                        WebBooking_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(BulkUpload.Displayed);
                        log.Info("BulkUpload page is displaying");
                        test.Log(LogStatus.Info, "BulkUpload page is displaying");

                        Assert.IsTrue(BulkUploadTemplate.Displayed);
                        log.Info("Bulk Upload Template page is displaying");
                        test.Log(LogStatus.Info, "Bulk Upload Template page is displaying");

                        Report_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(GroupRoomCalenderReport.Displayed);
                        log.Info("Group Room CalenderReport page is displaying");
                        test.Log(LogStatus.Info, "Group Room CalenderReport page is displaying");

                        Assert.IsTrue(FunctionDairyReport.Displayed);
                        log.Info("Function Dairy Report page is displaying");
                        test.Log(LogStatus.Info, "Function Dairy Report page is displaying");

                        Data_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(ImportData.Displayed);
                        log.Info("Import Data page is displaying");
                        test.Log(LogStatus.Info, "Import Data page is displaying");

                        Setting_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(ConferenceRoomPricing.Displayed);
                        log.Info("Conference Room Pricing page is displaying");
                        test.Log(LogStatus.Info, "Conference Room Pricing page is displaying");

                        Assert.IsTrue(SpaceQuoteSettings.Displayed);
                        log.Info("Space Quote Settings page is displaying");
                        test.Log(LogStatus.Info, "Space Quote Settings page is displaying");

                        Assert.IsTrue(UploadRate.Displayed);
                        log.Info("Upload Rate page is displaying");
                        test.Log(LogStatus.Info, "Upload Rate page is displaying");

                        Assert.IsTrue(ConferenceRooms.Displayed);
                        log.Info("Conference Rooms page is displaying");
                        test.Log(LogStatus.Info, "Conference Rooms page is displaying");

                        Assert.IsTrue(ConferenceGrouping.Displayed);
                        log.Info("Conference Grouping page is displaying");
                        test.Log(LogStatus.Info, "Conference Grouping page is displaying");

                        Assert.IsTrue(RoomToSpaceRatio.Displayed);
                        log.Info("RoomToSpaceRatio is displaying");
                        test.Log(LogStatus.Info, "RoomToSpaceRatio is displaying");
                        
                        ClickOnLogOut(log, test);
                        break;
                    }

                    if (uName.Equals(listEmailAddress[j]) && User_Role[j].Equals("Sales manager"))
                    {
                        test.Log(LogStatus.Info, "Logged In User Email: " + listEmailAddress[j].ToString());
                        test.Log(LogStatus.Info, "Logged in User Role is " + User_Role[j].ToString());

                        Assert.IsTrue(Lead_Menu.Displayed);
                        log.Info("Lead Menu is displaying");
                        test.Log(LogStatus.Info, "Lead Menu is displaying");

                        Assert.IsTrue(Quote_Menu.Displayed);
                        log.Info("Quote Menu is displaying");
                        test.Log(LogStatus.Info, "Quote Menu is displaying");

                        Assert.IsTrue(Account_Menu.Displayed);
                        log.Info("Account Menu is displaying");
                        test.Log(LogStatus.Info, "Account Menu is displaying");

                        Assert.IsTrue(Contact_Menu.Displayed);
                        log.Info("Contact Menu is displaying");
                        test.Log(LogStatus.Info, "Contact Menu is displaying");

                        Assert.IsTrue(Events_Menu.Displayed);
                        log.Info("Event Menu is displaying");
                        test.Log(LogStatus.Info, "Event Menu is displaying");

                        Assert.IsTrue(WebBooking_Menu.Displayed);
                        log.Info("Webooking Menu is displaying");
                        test.Log(LogStatus.Info, "Webooking Menu is displaying");

                        Assert.IsTrue(Setting_Menu.Displayed);
                        log.Info("Setting Menu is displaying");
                        test.Log(LogStatus.Info, "Setting Menu is displaying");

                        Assert.IsTrue(Report_Menu.Displayed);
                        log.Info("Report Menu is displaying");
                        test.Log(LogStatus.Info, "Report Menu is displaying");

                        Assert.IsTrue(Schedule_Menu.Displayed);
                        log.Info("Schedule Menu is displaying");
                        test.Log(LogStatus.Info, "Schedule Menu is displaying");

                        Assert.IsTrue(GRMLogoAfterLogin.Displayed);
                        log.Info("GRM logo is displaying");
                        test.Log(LogStatus.Info, "GRM Logo is displaying");

                        Lead_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(ViewWebleads.Displayed);
                        log.Info("View web lead page is displaying");
                        test.Log(LogStatus.Info, "View web lead page is displaying");

                        Assert.IsTrue(ViewInternalLeads.Displayed);
                        log.Info("View internal lead page is displaying");
                        test.Log(LogStatus.Info, "View internal lead page is displaying");

                        Assert.IsTrue(CreateLead.Displayed);
                        log.Info("Create lead page is displaying");
                        test.Log(LogStatus.Info, "Create lead page is displaying");

                        Assert.IsTrue(SearchLead.Displayed);
                        log.Info("Search lead page is displaying");
                        test.Log(LogStatus.Info, "Search lead page is displaying");

                        Quote_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(SearchQuote.Displayed);
                        log.Info("Search quote page is displaying");
                        test.Log(LogStatus.Info, "Search quote page is displaying");

                        Assert.IsTrue(CreateQuote.Displayed);
                        log.Info("Create quote page is displaying");
                        test.Log(LogStatus.Info, "Create quote page is displaying");

                        Assert.IsTrue(CreateMultiQuote.Displayed);
                        log.Info("Create multi quote page is displaying");
                        test.Log(LogStatus.Info, "Create multi quote page is displaying");

                        Account_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(CreateAccount.Displayed);
                        log.Info("Create Account page is displaying");
                        test.Log(LogStatus.Info, "Create Account page is displaying");

                        Contact_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(CreateContact.Displayed);
                        log.Info("Create Contact page is displaying");
                        test.Log(LogStatus.Info, "Create Contact page is displaying");

                        Assert.IsTrue(BulkEmailHistory.Displayed);
                        log.Info("BulkEmailHistory page is displaying");
                        test.Log(LogStatus.Info, "BulkEmailHistory page is displaying");

                        Events_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(SearchEvent.Displayed);
                        log.Info("Search Event page is displaying");
                        test.Log(LogStatus.Info, "Search Event page is displaying");

                        Assert.IsTrue(CreateEvent.Displayed);
                        log.Info("Create Event page is displaying");
                        test.Log(LogStatus.Info, "Create Event page is displaying");

                        WebBooking_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(BulkUpload.Displayed);
                        log.Info("BulkUpload page is displaying");
                        test.Log(LogStatus.Info, "BulkUpload page is displaying");

                        Report_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(GroupRoomCalenderReport.Displayed);
                        log.Info("Group Room CalenderReport page is displaying");
                        test.Log(LogStatus.Info, "Group Room CalenderReport page is displaying");

                        Assert.IsTrue(FunctionDairyReport.Displayed);
                        log.Info("Function Dairy Report page is displaying");
                        test.Log(LogStatus.Info, "Function Dairy Report page is displaying");

                        Assert.IsTrue(QuoteSummeryReport.Displayed);
                        log.Info("Quote Summery Report page is displaying");
                        test.Log(LogStatus.Info, "Quote Summery Report page is displaying");

                        Assert.IsTrue(QuoteDetail.Displayed);
                        log.Info("Quote Detail report page is displaying");
                        test.Log(LogStatus.Info, "Quote Detail report page is displaying");

                        Assert.IsTrue(PaceReport.Displayed);
                        log.Info("Pace Report page is displaying");
                        test.Log(LogStatus.Info, "Pace Report page is displaying");

                        Assert.IsTrue(SalesTrackingReport.Displayed);
                        log.Info("Sales Tracking Report page is displaying");
                        test.Log(LogStatus.Info, "Sales Tracking Report page is displaying");

                        Assert.IsTrue(FoodAndBeverageReport.Displayed);
                        log.Info("FoodAndBeverage Report page is displaying");
                        test.Log(LogStatus.Info, "FoodAndBeverage Report page is displaying");

                        Setting_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(GroupReservation.Displayed);
                        log.Info("GroupR reservation page is displaying");
                        test.Log(LogStatus.Info, "Group Reservation page is displaying");

                        ClickOnLogOut(log, test);
                        break;
                    }

                    if (uName.Equals(listEmailAddress[j]) && User_Role[j].Equals("Sales Director"))
                    {
                        test.Log(LogStatus.Info, "Logged In User Email: " + listEmailAddress[j].ToString());
                        test.Log(LogStatus.Info, "Logged in User Role is " + User_Role[j].ToString());

                        Assert.IsTrue(Lead_Menu.Displayed);
                        log.Info("Lead Menu is displaying");
                        test.Log(LogStatus.Info, "Lead Menu is displaying");

                        Assert.IsTrue(Quote_Menu.Displayed);
                        log.Info("Quote Menu is displaying");
                        test.Log(LogStatus.Info, "Quote Menu is displaying");

                        Assert.IsTrue(Account_Menu.Displayed);
                        log.Info("Account Menu is displaying");
                        test.Log(LogStatus.Info, "Account Menu is displaying");

                        Assert.IsTrue(Contact_Menu.Displayed);
                        log.Info("Contact Menu is displaying");
                        test.Log(LogStatus.Info, "Contact Menu is displaying");

                        Assert.IsTrue(Events_Menu.Displayed);
                        log.Info("Event Menu is displaying");
                        test.Log(LogStatus.Info, "Event Menu is displaying");

                        Assert.IsTrue(WebBooking_Menu.Displayed);
                        log.Info("Webooking Menu is displaying");
                        test.Log(LogStatus.Info, "Webooking Menu is displaying");

                        Assert.IsTrue(Setting_Menu.Displayed);
                        log.Info("Setting Menu is displaying");
                        test.Log(LogStatus.Info, "Setting Menu is displaying");

                        Assert.IsTrue(Report_Menu.Displayed);
                        log.Info("Report Menu is displaying");
                        test.Log(LogStatus.Info, "Report Menu is displaying");

                        Assert.IsTrue(Data_Menu.Displayed);
                        log.Info("Data Menu is displaying");
                        test.Log(LogStatus.Info, "Data Menu is displaying");

                        Assert.IsTrue(Schedule_Menu.Displayed);
                        log.Info("Schedule Menu is displaying");
                        test.Log(LogStatus.Info, "Schedule Menu is displaying");

                        Assert.IsTrue(GRMLogoAfterLogin.Displayed);
                        log.Info("GRM logo is displaying");
                        test.Log(LogStatus.Info, "GRM Logo is displaying");

                        Lead_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(ViewWebleads.Displayed);
                        log.Info("View web lead page is displaying");
                        test.Log(LogStatus.Info, "View web lead page is displaying");

                        Assert.IsTrue(ViewInternalLeads.Displayed);
                        log.Info("View internal lead page is displaying");
                        test.Log(LogStatus.Info, "View internal lead page is displaying");

                        Assert.IsTrue(CreateLead.Displayed);
                        log.Info("Create lead page is displaying");
                        test.Log(LogStatus.Info, "Create lead page is displaying");

                        Assert.IsTrue(SearchLead.Displayed);
                        log.Info("Search lead page is displaying");
                        test.Log(LogStatus.Info, "Search lead page is displaying");

                        Quote_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(SearchQuote.Displayed);
                        log.Info("Search quote page is displaying");
                        test.Log(LogStatus.Info, "Search quote page is displaying");

                        Assert.IsTrue(CreateQuote.Displayed);
                        log.Info("Create quote page is displaying");
                        test.Log(LogStatus.Info, "Create quote page is displaying");

                        Assert.IsTrue(CreateMultiQuote.Displayed);
                        log.Info("Create multi quote page is displaying");
                        test.Log(LogStatus.Info, "Create multi quote page is displaying");

                        Assert.IsTrue(AttendeeCrossCheck.Displayed);
                        log.Info("Attendee Cross Check page is displaying");
                        test.Log(LogStatus.Info, "Attendee Cross Check page is displaying");

                        Account_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(SearchAccount.Displayed);
                        log.Info("Search Account page is displaying");
                        test.Log(LogStatus.Info, "Search Account page is displaying");

                        Assert.IsTrue(CreateAccount.Displayed);
                        log.Info("Create Account page is displaying");
                        test.Log(LogStatus.Info, "Create Account page is displaying");

                        Contact_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(SearchContact.Displayed);
                        log.Info("Search contact page is displaying");
                        test.Log(LogStatus.Info, "Search Contact page is displaying");

                        Assert.IsTrue(CreateContact.Displayed);
                        log.Info("Create Contact page is displaying");
                        test.Log(LogStatus.Info, "Create Contact page is displaying");

                        Assert.IsTrue(BulkEmailHistory.Displayed);
                        log.Info("BulkEmailHistory page is displaying");
                        test.Log(LogStatus.Info, "BulkEmailHistory page is displaying");

                        Events_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(SearchEvent.Displayed);
                        log.Info("Search Event page is displaying");
                        test.Log(LogStatus.Info, "Search Event page is displaying");

                        Assert.IsTrue(CreateEvent.Displayed);
                        log.Info("Create Event page is displaying");
                        test.Log(LogStatus.Info, "Create Event page is displaying");

                        WebBooking_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(ViewWebBooking.Displayed);
                        log.Info("View Web Booking page is displaying");
                        test.Log(LogStatus.Info, "View Web Booking page is displaying");

                        Assert.IsTrue(BulkUpload.Displayed);
                        log.Info("BulkUpload page is displaying");
                        test.Log(LogStatus.Info, "BulkUpload page is displaying");

                        Assert.IsTrue(BulkUploadTemplate.Displayed);
                        log.Info("Bulk Upload Template page is displaying");
                        test.Log(LogStatus.Info, "Bulk Upload Template page is displaying");

                        Assert.IsTrue(ViewFileUpload.Displayed);
                        log.Info("View File Upload page is displaying");
                        test.Log(LogStatus.Info, "View File Upload page is displaying");

                        Report_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(GroupRoomCalenderReport.Displayed);
                        log.Info("Group Room CalenderReport page is displaying");
                        test.Log(LogStatus.Info, "Group Room CalenderReport page is displaying");

                        Assert.IsTrue(FunctionDairyReport.Displayed);
                        log.Info("Function Dairy Report page is displaying");
                        test.Log(LogStatus.Info, "Function Dairy Report page is displaying");

                        Assert.IsTrue(QuoteSummeryReport.Displayed);
                        log.Info("Quote Summery Report page is displaying");
                        test.Log(LogStatus.Info, "Quote Summery Report page is displaying");

                        Assert.IsTrue(QuoteDetail.Displayed);
                        log.Info("Quote Detail report page is displaying");
                        test.Log(LogStatus.Info, "Quote Detail report page is displaying");

                        Assert.IsTrue(PaceReport.Displayed);
                        log.Info("Pace Report page is displaying");
                        test.Log(LogStatus.Info, "Pace Report page is displaying");

                        Assert.IsTrue(SalesTrackingReport.Displayed);
                        log.Info("Sales Tracking Report page is displaying");
                        test.Log(LogStatus.Info, "Sales Tracking Report page is displaying");

                        Assert.IsTrue(FoodAndBeverageReport.Displayed);
                        log.Info("FoodAndBeverage Report page is displaying");
                        test.Log(LogStatus.Info, "FoodAndBeverage Report page is displaying");

                        Data_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(ImportData.Displayed);
                        log.Info("Import Data page is displaying");
                        test.Log(LogStatus.Info, "Import Data page is displaying");

                        Schedule_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(ViewTasks.Displayed);
                        log.Info("View Tasks page is displaying");
                        test.Log(LogStatus.Info, "View Tasks page is displaying");

                        Assert.IsTrue(CreateTasks.Displayed);
                        log.Info("Create Tasks page is displaying");
                        test.Log(LogStatus.Info, "Create Tasks page is displaying");

                        Setting_Menu.ClickOn(driver, 60);
                        Assert.IsTrue(LeadMapping.Displayed);
                        log.Info("Leaad Mapping page is displaying");
                        test.Log(LogStatus.Info, "Leaad Mapping page is displaying");

                        Assert.IsTrue(LeadSource.Displayed);
                        log.Info("Lead Source page is displaying");
                        test.Log(LogStatus.Info, "Lead Source page is displaying");

                        Assert.IsTrue(ConferenceRoomPricing.Displayed);
                        log.Info("Conference Room Pricing page is displaying");
                        test.Log(LogStatus.Info, "Conference Room Pricing page is displaying");

                        Assert.IsTrue(Rules.Displayed);
                        log.Info("Rules page is displaying");
                        test.Log(LogStatus.Info, "Rules page is displaying");

                        Assert.IsTrue(UploadRate.Displayed);
                        log.Info("Upload Rate page is displaying");
                        test.Log(LogStatus.Info, "Upload Rate page is displaying");

                        Assert.IsTrue(EmailServerSettings.Displayed);
                        log.Info("Email ServerS settings page is displaying");
                        test.Log(LogStatus.Info, "Email Server Settings page is displaying");

                        Assert.IsTrue(GroupReservation.Displayed);
                        log.Info("GroupR reservation page is displaying");
                        test.Log(LogStatus.Info, "Group Reservation page is displaying");

                        Assert.IsTrue(SalesTracking.Displayed);
                        log.Info("Sales Tracking page is displaying");
                        test.Log(LogStatus.Info, "Sales Tracking page is displaying");

                        Assert.IsTrue(FoodAndBeverage.Displayed);
                        log.Info("Food And Beverage page is displaying");
                        test.Log(LogStatus.Info, "Food And Beverage page is displaying");

                        Assert.IsTrue(FoodAndBeveragePackages.Displayed);
                        log.Info("Food And Beverage Packages page is displaying");
                        test.Log(LogStatus.Info, "Food And Beverage Packages page is displaying");

                        Assert.IsTrue(TaxAndServicesCharges.Displayed);
                        log.Info("Tax And Services Charges page is displaying");
                        test.Log(LogStatus.Info, "Tax And Services Charges page is displaying");

                        Assert.IsTrue(MeetingPackages.Displayed);
                        log.Info("MeetingPackages page is displaying");
                        test.Log(LogStatus.Info, "MeetingPackages page is displaying");

                        Assert.IsTrue(LeadScoreSettings.Displayed);
                        log.Info("Lead Score Settings page is displaying");
                        test.Log(LogStatus.Info, "Lead Score Settings page is displaying");

                        Assert.IsTrue(ConferenceRooms.Displayed);
                        log.Info("Conference Rooms page is displaying");
                        test.Log(LogStatus.Info, "Conference Rooms page is displaying");

                        Assert.IsTrue(ConferenceGrouping.Displayed);
                        log.Info("Conference Grouping page is displaying");
                        test.Log(LogStatus.Info, "Conference Grouping page is displaying");

                        Assert.IsTrue(RoomQuoteSettings.Displayed);
                        log.Info("Room Quote Settings page is displaying");
                        test.Log(LogStatus.Info, "Room Quote Settings page is displaying");

                        Assert.IsTrue(Templates.Displayed);
                        log.Info("Templates page is displaying");
                        test.Log(LogStatus.Info, "Templates page is displaying");

                        Assert.IsTrue(OverrideRequest.Displayed);
                        log.Info("Override Request page is displaying");
                        test.Log(LogStatus.Info, "Override Request page is displaying");

                        Assert.IsTrue(AttendeeMobileSettings.Displayed);
                        log.Info("Attendee Mobile Settings page is displaying");
                        test.Log(LogStatus.Info, "Attendee Mobile Settings page is displaying");

                        Assert.IsTrue(ManageRegions.Displayed);
                        log.Info("Manage Regions page is displaying");
                        test.Log(LogStatus.Info, "Manage Regions page is displaying");

                        Assert.IsTrue(BookingEngineSettings.Displayed);
                        log.Info("Booking Engine Settings page is displaying");
                        test.Log(LogStatus.Info, "Booking Engine Settings page is displaying");
                        
                        ClickOnLogOut(log, test);
                        break;
                    }
                }
            }
        }
        #endregion

        #region Verify Pages Based on user role for Marketplace company
        public void MarketplaceCompanyPageVerification(ILog log, ExtentTest test)
        {
            int RowCount = ExcelReaderHelper.GetTotalRows(fileLocation, "CreatedUserEmails");
            int RowCount_value = RowCount - 1;

            string uName = ExcelReaderHelper.GetCellData(fileLocation, "CreatedUserEmails", RowCount_value, 0).ToString();
            string password1 = ExcelReaderHelper.GetCellData(fileLocation, "CreateUserData", RowCount_value, 1).ToString();

            UserName.SendKeys(Keys.Control + "a"+Keys.Delete);            
            UserName.WaitTillElementToBeClickable(driver, 60);
            UserName.EnterValue(uName);

            IJavaScriptExecutor javascriptExecutor = (IJavaScriptExecutor)driver;
            string jsString = "document.getElementById('" + GRMLoginLocator.Password + "').value='" + password1 + "'";
            javascriptExecutor.ExecuteScript(jsString);            

            LoginButton.ClickOn(driver, 60);

            dataSet = DBConnection.GetDBData("select u.Email,u.IsAdmin,ur.RoleName from [user] u inner join  User_Role_Default ur  on u.IsAdmin = ur.Id");

            List<string> listEmailAddress = new List<string>();
            List<string> User_Role = new List<string>();

            for (int j = 0; j < dataSet.Tables[0].Rows.Count; j++)
            {
                listEmailAddress.Add(dataSet.Tables[0].Rows[j]["Email"].ToString());
                User_Role.Add(dataSet.Tables[0].Rows[j]["RoleName"].ToString());
            }

            for (int j = 0; j < listEmailAddress.Count; j++)
            {
                Console.WriteLine(listEmailAddress[j].ToString());
                Console.WriteLine(User_Role[j].ToString());

                if (uName.Equals(listEmailAddress[j]) && User_Role[j].Equals("Super Admin"))
                {
                    test.Log(LogStatus.Info, "Logged In User Email: " + listEmailAddress[j].ToString());
                    test.Log(LogStatus.Info, "Logged in User Role is " + User_Role[j].ToString());

                    Assert.IsTrue(Lead_Menu.Displayed);
                    log.Info("Lead Menu is displaying");
                    test.Log(LogStatus.Info, "Lead Menu is displaying");

                    Assert.IsTrue(Quote_Menu.Displayed);
                    log.Info("Quote Menu is displaying");
                    test.Log(LogStatus.Info, "Quote Menu is displaying");

                    Assert.IsTrue(Events_Menu.Displayed);
                    log.Info("Event Menu is displaying");
                    test.Log(LogStatus.Info, "Event Menu is displaying");

                    Assert.IsTrue(Setting_Menu.Displayed);
                    log.Info("Setting Menu is displaying");
                    test.Log(LogStatus.Info, "Setting Menu is displaying");

                    Assert.IsTrue(Data_Menu.Displayed);
                    log.Info("Data Menu is displaying");
                    test.Log(LogStatus.Info, "Data Menu is displaying");

                    Assert.IsTrue(GRMLogoAfterLogin.Displayed);
                    log.Info("GRM logo is displaying");
                    test.Log(LogStatus.Info, "GRM Logo is displaying");

                    Lead_Menu.ClickOn(driver, 60);
                    Assert.IsTrue(ViewWebleads.Displayed);
                    log.Info("View web lead page is displaying");
                    test.Log(LogStatus.Info, "View web lead page is displaying");

                    Assert.IsTrue(SearchLead.Displayed);
                    log.Info("Search lead page is displaying");
                    test.Log(LogStatus.Info, "Search lead page is displaying");

                    Quote_Menu.ClickOn(driver, 60);
                    Assert.IsTrue(SearchQuote.Displayed);
                    log.Info("Search quote page is displaying");
                    test.Log(LogStatus.Info, "Search quote page is displaying");

                    Events_Menu.ClickOn(driver, 60);
                    Assert.IsTrue(SearchEvent.Displayed);
                    log.Info("Search Event page is displaying");
                    test.Log(LogStatus.Info, "Search Event page is displaying");

                    Data_Menu.ClickOn(driver, 60);
                    Assert.IsTrue(ImportData.Displayed);
                    log.Info("Import Data page is displaying");
                    test.Log(LogStatus.Info, "Import Data page is displaying");

                    Assert.IsTrue(ViewStausAndData.Displayed);
                    log.Info("View Staus And Data page is displaying");
                    test.Log(LogStatus.Info, "View Staus And Data page is displaying");

                    Setting_Menu.ClickOn(driver, 60);
                    Assert.IsTrue(RoomType.Displayed);
                    log.Info("RoomType page is displaying");
                    test.Log(LogStatus.Info, "RoomType page is displaying");

                    Assert.IsTrue(LeadMapping.Displayed);
                    log.Info("Leaad Mapping page is displaying");
                    test.Log(LogStatus.Info, "Leaad Mapping page is displaying");

                    Assert.IsTrue(LeadSource.Displayed);
                    log.Info("Lead Source page is displaying");
                    test.Log(LogStatus.Info, "Lead Source page is displaying");

                    Assert.IsTrue(ConferenceRoomPricing.Displayed);
                    log.Info("Conference Room Pricing page is displaying");
                    test.Log(LogStatus.Info, "Conference Room Pricing page is displaying");

                    Assert.IsTrue(UploadRate.Displayed);
                    log.Info("Upload Rate page is displaying");
                    test.Log(LogStatus.Info, "Upload Rate page is displaying");

                    Assert.IsTrue(FoodAndBeverage.Displayed);
                    log.Info("Food And Beverage page is displaying");
                    test.Log(LogStatus.Info, "Food And Beverage page is displaying");

                    Assert.IsTrue(Localization.Displayed);
                    log.Info("Localization page is displaying");
                    test.Log(LogStatus.Info, "Localization page is displaying");

                    Assert.IsTrue(Addons.Displayed);
                    log.Info("Addons page is displaying");
                    test.Log(LogStatus.Info, "Addons page is displaying");

                    Assert.IsTrue(TaxAndServicesCharges.Displayed);
                    log.Info("Tax And Services Charges page is displaying");
                    test.Log(LogStatus.Info, "Tax And Services Charges page is displaying");

                    Assert.IsTrue(MeetingPackages.Displayed);
                    log.Info("MeetingPackages page is displaying");
                    test.Log(LogStatus.Info, "MeetingPackages page is displaying");

                    Assert.IsTrue(LeadScoreSettings.Displayed);
                    log.Info("Lead Score Settings page is displaying");
                    test.Log(LogStatus.Info, "Lead Score Settings page is displaying");

                    Assert.IsTrue(ConferenceRooms.Displayed);
                    log.Info("Conference Rooms page is displaying");
                    test.Log(LogStatus.Info, "Conference Rooms page is displaying");

                    Assert.IsTrue(ConferenceGrouping.Displayed);
                    log.Info("Conference Grouping page is displaying");
                    test.Log(LogStatus.Info, "Conference Grouping page is displaying");

                    Assert.IsTrue(ManageUsers.Displayed);
                    log.Info("Manage Users page is displaying");
                    test.Log(LogStatus.Info, "Manage Users page is displaying");

                    Assert.IsTrue(Templates_Marketplace.Displayed);
                    log.Info("Templates page is displaying");
                    test.Log(LogStatus.Info, "Templates page is displaying");

                    Assert.IsTrue(DataImportSettings.Displayed);
                    log.Info("Data Import Settings page is displaying");
                    test.Log(LogStatus.Info, "Data Import Settings page is displaying");

                    Assert.IsTrue(FoodAndBeveragePackages.Displayed);
                    log.Info("Food And Beverage Packages page is displaying");
                    test.Log(LogStatus.Info, "Food And Beverage Packages page is displaying");

                    Assert.IsTrue(AudioAndVisualInventory.Displayed);
                    log.Info("Audio And Visual Inventory page is displaying");
                    test.Log(LogStatus.Info, "Audio And Visual Inventory page is displaying");

                    Assert.IsTrue(HotelMarketplaceSetting.Displayed);
                    log.Info("Hotel Marketplace Setting page is displaying");
                    test.Log(LogStatus.Info, "Hotel Marketplace Setting page is displaying");

                    //Assert.IsTrue(MarketplaceWebConfiguration.Displayed);
                    //log.Info("Marketplace Web Configuration Setting page is displaying");
                    //test.Log(LogStatus.Info, "Marketplace Web Configuration Setting page is displaying");

                    //Assert.IsTrue(CompanyAndHotelSettings.Displayed);
                    //log.Info("Company And Hotel Settings  page is displaying");
                    //test.Log(LogStatus.Info, "Company And Hotel Setting page is displaying");

                    //Assert.IsTrue(TravelAgentPartnerSettings.Displayed);
                    //log.Info("Travel Agent Partner Settings page is displaying");
                    //test.Log(LogStatus.Info, "Travel Agent Partner Settings page is displaying");
                }
            }
        }
        #endregion

        #region
        public void ClickOnLogOut(ILog log, ExtentTest test)
        {
            ArrowIcon.ClickOn(driver, 60);
            Logout.ClickOn(driver, 60);
            LoginButton.WaitTillElementToBeClickable(driver, 60);
            Assert.IsTrue(LoginButton.Displayed);
            log.Info("Logout happened successfully");
            test.Log(LogStatus.Info, "Logout happened successfully");

        }
        #endregion
    }
}
