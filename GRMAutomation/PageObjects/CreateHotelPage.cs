using GRMAutomation.DataReader;
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

namespace GRMAutomation.PageObjects.SettingsPage
{
   public class CreateHotelPage : ScreenCapturer
    {
        #region CreateHotelPage Elements

        [FindsBy(How = How.Id, Using = CreateHotelLocator.CompanyNameInCreateHotel)]
        public IWebElement CompanyNameInCreateHotel { get; set; }

        [FindsBy(How = How.XPath, Using = CreateHotelLocator.CompanyListInCreateHotel)]
        public IList<IWebElement> CompanyListInCreateHotel { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.HotelName)]
        public IWebElement HotelName { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.City)]
        public IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.State)]
        public IWebElement State { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.Country)]
        public IWebElement Country { get; set; }

        [FindsBy(How = How.XPath, Using = CreateHotelLocator.CountryList)]
        public IList<IWebElement> CountryList { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.ZipCode)]
        public IWebElement ZipCode { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.AddressLine1)]
        public IWebElement AddressLine1 { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.AddressLine2)]
        public IWebElement AddressLine2 { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.Phone)]
        public IWebElement Phone { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.Fax)]
        public IWebElement Fax { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.VenueType)]
        public IWebElement VenueType { get; set; }

        [FindsBy(How = How.XPath, Using = CreateHotelLocator.VenueTypeList)]
        public IList<IWebElement> VenueTypeList { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.Star)]
        public IWebElement Star { get; set; }

        [FindsBy(How = How.XPath, Using = CreateHotelLocator.StarList)]
        public IList<IWebElement> StarList { get; set; }

        [FindsBy(How = How.XPath, Using = CreateHotelLocator.FeaturesList)]
        public IList<IWebElement> FeaturesList { get; set; }

        [FindsBy(How = How.XPath, Using = CreateHotelLocator.UrlList)]
        public IList<IWebElement> UrlList { get; set; }

        [FindsBy(How = How.XPath, Using = CreateHotelLocator.StripeAccountForPayment)]
        public IWebElement StripeAccountForPayment { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.SubmitButton)]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.HotelIdWithMessage)]
        public IWebElement HotelIdWithMessage { get; set; }

        [FindsBy(How = How.Id, Using = CreateHotelLocator.SuccessMessage)]
        public IWebElement SuccessMessage { get; set; }

        #endregion

        #region Constuctor for Create Hotel Page
        public CreateHotelPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        #region Select A Company Name
        public void SelectCompanyName(ILog log, ExtentTest test, string companyName)
        {
            Assert.IsTrue(CompanyNameInCreateHotel.Displayed);
            CompanyNameInCreateHotel.Click();

            driver.SelectADropDownValue(CompanyListInCreateHotel, companyName);                        
            
            log.Info("Selected Company Name is: " + companyName);
            test.Log(LogStatus.Info, "Selected Company Name is: " + companyName);
        }
        #endregion

        #region Enter A Hotel Name
        public void EnterHotelName(ILog log, ExtentTest test,string hotelName)
        {
            Assert.IsTrue(HotelName.Displayed);                       
            HotelName.EnterValue(hotelName);
            log.Info("Entered Hotel Name is: " + hotelName);
            test.Log(LogStatus.Info, "Entered Hotel Name is: " + hotelName);
        }

        #endregion

        #region Enter A City Name
        public void EnterCityName(ILog log, ExtentTest test, string city)
        {
            Assert.IsTrue(City.Displayed);                       
            City.EnterValue(city);
            log.Info("Entered City Name is: " + city);
            test.Log(LogStatus.Info, "Entered City Name is: " + city);
        }

        #endregion

        #region Enter A State Name 
        public void EnterStateName(ILog log, ExtentTest test, string state)
        {
            Assert.IsTrue(State.Displayed);                    
            State.EnterValue(state);
            log.Info("Entered State Name is: " + state);
            test.Log(LogStatus.Info, "Entered State Name is: " + state);
        }

        #endregion

        #region Select A Country
        public void SelectCountry(ILog log, ExtentTest test, string CountryName)
        {
            Assert.IsTrue(Country.Displayed);
            Country.Click();

            driver.SelectADropDownValue(CountryList, CountryName);

            log.Info("Selected Country Name is: " + CountryName);
            test.Log(LogStatus.Info, "Selected Country Name is: " + CountryName);
        }

        #endregion

        #region Enter A Zip Code
        public void EnterZipCode(ILog log, ExtentTest test, string Zip)
        {
            Assert.IsTrue(ZipCode.Displayed);                       
            ZipCode.EnterValue(Zip);
            log.Info("Entered ZipCode is: " + Zip);
            test.Log(LogStatus.Info, "Entered ZipCode is: " + Zip);
        }

        #endregion

        #region Enter Address Line1 Details
        public void EnterAddress1(ILog log, ExtentTest test, string address1)
        {
            Assert.IsTrue(AddressLine1.Displayed);                        
            AddressLine1.EnterValue(address1);
            log.Info("Entered AddressLine1 is: " + address1);
            test.Log(LogStatus.Info, "Entered AddressLine1 is: " + address1);
        }

        #endregion

        #region Enter Address Line2 Details
        public void EnterAddress2(ILog log, ExtentTest test, string address2)
        {
            Assert.IsTrue(AddressLine2.Displayed);
            AddressLine2.EnterValue(address2);
            log.Info("Entered AddressLine2 is: " + address2);
            test.Log(LogStatus.Info, "Entered AddressLine2 is: " + address2);
        }

        #endregion

        #region Enter Phone No.
        public void EnterPhoneNo(ILog log, ExtentTest test, string phone)
        {
            Assert.IsTrue(Phone.Displayed);
            Phone.EnterValue(phone);
            log.Info("Entered Phone No is: " + phone);
            test.Log(LogStatus.Info, "Entered Phone No is: " + phone);
        }

        #endregion

        #region Enter Fax No.
        public void EnterFaxNo(ILog log, ExtentTest test, string FaxNo)
        {
            Assert.IsTrue(Fax.Displayed);
            Fax.EnterValue(FaxNo);
            log.Info("Entered Fax No is: " + FaxNo);
            test.Log(LogStatus.Info, "Entered Fax No is: " + FaxNo);
        }

        #endregion

        #region Select A Vanue Type
        public void SelectVenueType(ILog log, ExtentTest test, string Venuetype)
        {
            Assert.IsTrue(VenueType.Displayed);
            VenueType.Click();

            driver.SelectADropDownValue(VenueTypeList, Venuetype);
            
            log.Info("Selected Venue Type is: " + Venuetype);
            test.Log(LogStatus.Info, "Selected Venue Type is: " + Venuetype);
        }

        #endregion

        #region Select A Star Rating for Hotel
        public void SelectStarRating(ILog log, ExtentTest test, string starRating)
        {
            Assert.IsTrue(Star.Displayed);
            Star.Click();

            driver.SelectADropDownValue(StarList, starRating);

            log.Info("Selected Star Rating is: " + starRating);
            test.Log(LogStatus.Info, "Selected Star Rating is: " + starRating);
        }

        #endregion

        #region Select A Feature
        public void SelectFeatures(ILog log, ExtentTest test, string features)
        {
            for (int i = 0; i < FeaturesList.Count; i++)
            {
                Assert.IsTrue(FeaturesList[i].Displayed);
            }

            driver.SelectADropDownValue(FeaturesList, features);

            log.Info("Selected Feature is: " + features);
            test.Log(LogStatus.Info, "Selected Feature is: " + features);
        }

        #endregion

        #region Select A URL
        public void SelectURL(ILog log, ExtentTest test, string Url)
        {
            for(int i=0; i< UrlList.Count;  i++)
            {
                Assert.IsTrue(UrlList[i].Displayed);
            }

            driver.SelectADropDownValue(UrlList, Url);

            log.Info("Selected URL is: " + Url);
            test.Log(LogStatus.Info, "Selected URL is: " + Url);
        }

        #endregion

        #region Select Checkbox for Stripe Managed Account for Payments
        public void SelectStripeAccountForPayment(ILog log, ExtentTest test)
        {
            Assert.IsTrue(StripeAccountForPayment.Displayed);
            StripeAccountForPayment.Click();
            log.Info("CheckBox for Create a Stripe Managed Account for Payments is selected");
            test.Log(LogStatus.Info, "CheckBox for Create a Stripe Managed Account for Payments is selected");
        }

        #endregion

        #region Click On Submit Button
        public void ClickOnSubmitButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(SubmitButton.Displayed);
            SubmitButton.ClickOn(driver, 60);

            log.Info("Submit Button Clicked");
            test.Log(LogStatus.Info, "Submit Button Clicked");
        }

        #endregion

        #region Verify For Success Message With HotelID for newly created Hotel
        public bool VerifyForSuccessMessageWithHotelIDfornewlycreatedHotel(ILog log, ExtentTest test)
        { 
            Assert.IsTrue(HotelIdWithMessage.Displayed);
            Assert.IsTrue(SuccessMessage.Displayed);

             string MessageWithHotelID = HotelIdWithMessage.Text;
             string HotelID = MessageWithHotelID.Split(' ')[3];            
                            
                test.Log(LogStatus.Info, "Hotel ID is ->" + HotelID);

                if (HotelID.Length >= 3)
                {
                    test.Log(LogStatus.Pass, "Hotel id size is displaying correctly");
                    return true;
                }
                else
                {
                    test.Log(LogStatus.Fail, "Hotel id size is not displaying correctly");
                    return false;
                }           
         }

        #endregion
    }
}
