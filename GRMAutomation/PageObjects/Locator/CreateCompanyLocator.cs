
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMAutomation.PageObjects.Locator
{
    public class CreateCompanyLocator
    {
        #region All available locators for Create Company Page

        public const string CompanyNameInCreateCompany = "txtCompany";
        public const string City = "txtCompanyCity";
        public const string State = "txtCompanyState";
        public const string Country = "ddlCompanyCountry";
        public const string CountryList = "//select[@id='ddlCompanyCountry']/option";
        public const string ZipCode = "txtCompanyZip";
        public const string AddressLine1 = "txtCompanyAddress1";
        public const string AddressLine2 = "txtCompanyAddress2";
        public const string LicensedGuestRoom = "txtLicensedGuestRoom";
        public const string LicensedConferenceSpace = "txtLicensedConferenceSpace";
        public const string LicenseType = "ddlLicenseType";
        public const string LicenseTypeList = "//select[@id='ddlLicenseType']/option";

        public const string FeatureStandard = "//table[@id='CheckBoxList2']/tbody/tr[1]";
        public const string FeatureRoomType = "//table[@id='CheckBoxList2']/tbody/tr[2]";
        public const string FeatureConference = "//table[@id='CheckBoxList2']/tbody/tr[3]";
        public const string FeatureEmailTemplate = "//table[@id='CheckBoxList2']/tbody/tr[4]";
        public const string FeatureOperaIntegration = "//table[@id='CheckBoxList2']/tbody/tr[5]";
        public const string FeatureGroupManagement = "//table[@id='CheckBoxList2']/tbody/tr[6]";
        public const string FeatureLeadManagement = "//table[@id='CheckBoxList2']/tbody/tr[7]";
        public const string FeatureMobileAttendee = "//table[@id='CheckBoxList2']/tbody/tr[8]";
        public const string FeatureAutoGenWebsite = "//table[@id='CheckBoxList2']/tbody/tr[9]";
        public const string FeatureTourico = "//table[@id='CheckBoxList2']/tbody/tr[10]";
        public const string FeatureMultiHotel = "//table[@id='CheckBoxList2']/tbody/tr[11]";
        public const string FeatureBookingEngineSettings = "//table[@id='CheckBoxList2']/tbody/tr[12]";
        public const string FeatureMarketplace = "//table[@id='CheckBoxList2']/tbody/tr[13]";
        public const string FeatureTravelAgent = "//table[@id='CheckBoxList2']/tbody/tr[14]";
        public const string FeatureCommon = "//table[@id='CheckBoxList2']/tbody/tr[15]";

        public const string FeaturesList = "//table[@id='CheckBoxList2']/tbody/tr/td/label";
        public const string ListOfCheckBox = "//table[@id='CheckBoxList2']/tbody/tr/td/input";

        public const string SubmitButton = "btnAddCompany";
        public const string SuccessMessageWithProductKeyAndCompanyID = "lblProductKey";
        public const int RowNo = 17;

        #endregion
    }
}
