using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMAutomation.PageObjects.Locator
{
    public class CreateHotelLocator
    {
        #region All available locators for Create Hotel Page

        public const string CompanyNameInCreateHotel = "ddlCompany";
        public const string CompanyListInCreateHotel = "//select[@id='ddlCompany']/option";
        public const string HotelName = "txtHotel";
        public const string City = "txtHotelCity";
        public const string State = "txtHotelState";
        public const string Country = "ddlHotelCountry";
        public const string CountryList = "//select[@id='ddlHotelCountry']/option";
        public const string ZipCode = "txtHotelZip";
        public const string AddressLine1 = "txtAddress1";
        public const string AddressLine2 = "txtAddress2";
        public const string Phone = "txtPhone";
        public const string Fax = "txtFax";
        public const string VenueType = "ddlVenueType";
        public const string VenueTypeList = "//select[@id='ddlVenueType']/option";
        public const string Star = "ddlStar";
        public const string StarList = "//select[@id='ddlStar']/option";
        public const string FeaturesList = "//table[@id='chkFeatures']/tbody/tr/td";
        public const string UrlList = "//table[@id='chkURLs']/tbody/tr/td";
        public const string StripeAccountForPayment = "//input[@id='chkstripeAcc']";
        public const string SubmitButton = "btnAddHotel";

        public const string HotelIdWithMessage = "LblHotelId";  
        public const string SuccessMessage = "lblErrormessage";

        #endregion
    }
}
