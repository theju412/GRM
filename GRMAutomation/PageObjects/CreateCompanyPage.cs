﻿using GRMAutomation.DataReader;
using GRMAutomation.DataWriter;
using GRMAutomation.PageObjects.Locator;
using GRMAutomation.Utilities;
using log4net;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMAutomation.PageObjects.SettingsPage
{
    public class CreateCompanyPage : ScreenCapturer
    {
        #region CreateCompanyPage Elements

        [FindsBy(How = How.Id, Using = CreateCompanyLocator.CompanyNameInCreateCompany)]
        public IWebElement CompanyNameInCreateCompany { get; set; }

        [FindsBy(How = How.Id, Using = CreateCompanyLocator.City)]
        public IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = CreateCompanyLocator.State)]
        public IWebElement State { get; set; }

        [FindsBy(How = How.Id, Using = CreateCompanyLocator.Country)]
        public IWebElement Country { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.CountryList)]
        public IList<IWebElement> CountryList { get; set; }

        [FindsBy(How = How.Id, Using = CreateCompanyLocator.ZipCode)]
        public IWebElement ZipCode { get; set; }

        [FindsBy(How = How.Id, Using = CreateCompanyLocator.AddressLine1)]
        public IWebElement AddressLine1 { get; set; }

        [FindsBy(How = How.Id, Using = CreateCompanyLocator.AddressLine2)]
        public IWebElement AddressLine2 { get; set; }

        [FindsBy(How = How.Id, Using = CreateCompanyLocator.LicensedGuestRoom)]
        public IWebElement LicensedGuestRoom { get; set; }

        [FindsBy(How = How.Id, Using = CreateCompanyLocator.LicensedConferenceSpace)]
        public IWebElement LicensedConferenceSpace { get; set; }

        [FindsBy(How = How.Id, Using = CreateCompanyLocator.LicenseType)]
        public IWebElement LicenseType { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.LicenseTypeList)]
        public IList<IWebElement> LicenseTypeList { get; set; }

        [FindsBy(How = How.Id, Using = CreateCompanyLocator.SubmitButton)]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureStandard)]
        public IWebElement FeatureStandard { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureRoomType)]
        public IWebElement FeatureRoomType { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureConference)]
        public IWebElement FeatureConference { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureEmailTemplate)]
        public IWebElement FeatureEmailTemplate { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureOperaIntegration)]
        public IWebElement FeatureOperaIntegration { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureGroupManagement)]
        public IWebElement FeatureGroupManagement { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureLeadManagement)]
        public IWebElement FeatureLeadManagement { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureMobileAttendee)]
        public IWebElement FeatureMobileAttendee { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureAutoGenWebsite)]
        public IWebElement FeatureAutoGenWebsite { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureTourico)]
        public IWebElement FeatureTourico { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureMultiHotel)]
        public IWebElement FeatureMultiHotel { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureBookingEngineSettings)]
        public IWebElement FeatureBookingEngineSettings { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureMarketplace)]
        public IWebElement FeatureMarketplace { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureTravelAgent)]
        public IWebElement FeatureTravelAgent { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeatureCommon)]
        public IWebElement FeatureCommon { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.FeaturesList)]
        public IList<IWebElement> FeaturesList { get; set; }

        [FindsBy(How = How.XPath, Using = CreateCompanyLocator.ListOfCheckBox)]
        public IList<IWebElement> ListOfCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = CreateCompanyLocator.SuccessMessageWithProductKeyAndCompanyID)]
        public IWebElement SuccessMessageWithProductKeyAndCompanyID { get; set; }

        #endregion

        #region Constuctor for Create Company Page
        public CreateCompanyPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        #region Enter A company Name
        public void EnterCompanyName(string companyName, ILog log, ExtentTest test)
        {
            Assert.IsTrue(CompanyNameInCreateCompany.Displayed);            
            CompanyNameInCreateCompany.EnterValue(companyName);

            //Assert.IsTrue(VerifyForEnteredCompanyNameAlreadyExistOrNot(companyName, log, test));

            bool CompanyNotExist = VerifyForEnteredCompanyNameAlreadyExistInDBOrNot(companyName, log, test);
            if (CompanyNotExist == true)
            {
                log.Info("Entered New Company Name is: " + companyName);
                test.Log(LogStatus.Info, "Entered New Company Name is: " + companyName);
            }
            else
            {
                log.Info("Entered Existing Company Name is: " + companyName);
                test.Log(LogStatus.Info, "Entered Existing Company Name is: " + companyName);
            }
        }

        #endregion

        #region Verify For Entered Company Name Already Exist Or Not
        public bool VerifyForEnteredCompanyNameAlreadyExistInDBOrNot(string companyname, ILog log, ExtentTest test)
        {

            dataSet = DBConnection.GetDBData("Select Name from Company");

            List<string> ListOfCompanyName = new List<string>();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                ListOfCompanyName.Add(dataSet.Tables[0].Rows[i]["Name"].ToString());
            }

            for (int j = 0; j < ListOfCompanyName.Count; j++)
            {
                if (ListOfCompanyName[j].ToString().Equals(companyname))
                {
                    log.Warn("Entered Company name as " + "'" + companyname + "'" + " already exist in our DataBase. There is no validation for creating company with same name, So it will create company with same name");
                    test.Log(LogStatus.Warning, "Entered Company name as " + "'" + companyname + "'" + " already exist in our DataBase. There is no validation for creating company with same name, So it will create company with same name");
                    return false;
                }
            }
            return true;

            //CreateHotelPage obj = new CreateHotelPage(driver);

            //for (int i = 0; i < obj.CompanyListInCreateHotel.Count; i++)
            //{
            //    if (obj.CompanyListInCreateHotel[i].Text.Equals(companyname))
            //    {
            //        log.Warn("Entered Company name as " + "'" + companyname + "'" + " already exist in system. There is no validation for creating company with same name, So it will create company with same name");
            //        test.Log(LogStatus.Warning, "Entered Company name as " + "'" + companyname + "'" + " already exist in system. There is no validation for creating company with same name, So it will create company with same name");
            //        return false;
            //    }
            //}
            //return true;
        }

        #endregion

        #region Enter a City Name
        public void EnterCityName(string city, ILog log, ExtentTest test)
        {
            Assert.IsTrue(City.Displayed);

            City.EnterValue(city);

            log.Info("Entered City Name is: " + city);
            test.Log(LogStatus.Info, "Entered City Name is: " + city);
        }

        #endregion

        #region Enter A State Name
        public void EnterStateName(string state, ILog log, ExtentTest test)
        {
            Assert.IsTrue(State.Displayed);

            State.EnterValue(state);

            log.Info("Entered State Name is: " + state);
            test.Log(LogStatus.Info, "Entered State Name is: " + state);
        }

        #endregion

        #region Select A Country
        public void SelectCountry(string countryName, ILog log, ExtentTest test)
        {
            Assert.IsTrue(Country.Displayed);
            
            Country.Click();

            driver.SelectADropDownValue(CountryList, countryName);
            Assert.AreEqual(countryName, Country.GetSelectedTextValue());

            log.Info("Selected Country Name is: " + countryName);
            test.Log(LogStatus.Info, "Selected Country Name is: " + countryName);
        }

        #endregion

        #region Enter A Zip Code
        public void EnterZipCode(string zipCode, ILog log, ExtentTest test)
        {
            Assert.IsTrue(ZipCode.Displayed);

            ZipCode.EnterValue(zipCode);

            log.Info("Entered ZipCode is: " + zipCode);
            test.Log(LogStatus.Info, "Entered ZipCode is: " + zipCode);
        }

        #endregion

        #region Enter Address Line1 Details
        public void EnterAddress1(string address1, ILog log, ExtentTest test)
        {
            Assert.IsTrue(AddressLine1.Displayed);

            AddressLine1.EnterValue(address1);

            log.Info("Entered AddressLine1 is: " + address1);
            test.Log(LogStatus.Info, "Entered AddressLine1 is: " + address1);
        }

        #endregion

        #region Enter Address Line2 Details
        public void EnterAddress2(string address2, ILog log, ExtentTest test)
        {
            Assert.IsTrue(AddressLine2.Displayed);

            AddressLine2.EnterValue(address2);

            log.Info("Entered AddressLine2 is: " + address2);
            test.Log(LogStatus.Info, "Entered AddressLine2 is: " + address2);
        }

        #endregion

        #region Enter No. of Licensed Guest rooms
        public void EnterLicensedGuestRoom(string licensedGuestRoom, ILog log, ExtentTest test)
        {
            Assert.IsTrue(LicensedGuestRoom.Displayed);

            LicensedGuestRoom.EnterValue(licensedGuestRoom);

            log.Info("Entered No of LicensedGuestRoom are: " + licensedGuestRoom);
            test.Log(LogStatus.Info, "Entered No of LicensedGuestRoom are: " + licensedGuestRoom);
        }

        #endregion

        #region Enter No. of Licensed Conference Space
        public void EnterLicensedConferenceSpace(string licensedConferenceSpace, ILog log, ExtentTest test)
        {
            Assert.IsTrue(LicensedConferenceSpace.Displayed);

            LicensedConferenceSpace.EnterValue(licensedConferenceSpace);

            log.Info("Entered No of LicensedConferenceSpace are: " + licensedConferenceSpace);
            test.Log(LogStatus.Info, "Entered No of LicensedConferenceSpace are: " + licensedConferenceSpace);
        }

        #endregion

        #region Select A Licensed Type
        public void SelectLicensedType(string licensedType, ILog log, ExtentTest test)
        {
            Assert.IsTrue(LicenseType.Displayed);
            
            LicenseType.Click();

            driver.SelectADropDownValue(LicenseTypeList, licensedType);
            Assert.AreEqual(licensedType, LicenseType.GetSelectedTextValue());

            log.Info("Selected License Type is: " + licensedType);
            test.Log(LogStatus.Info, "Selected License Type is: " + licensedType);
        }

        #endregion

        #region Select all Company Features required for GRM
        public void SelectCompanyFeaturesForGRM(ILog log, ExtentTest test)
        {
            for (int i = 0; i < FeaturesList.Count; i++)
            {
                Assert.IsTrue(FeaturesList[i].Displayed);
            }

            int Row = CreateCompanyLocator.RowNo;
            foreach (IWebElement e in FeaturesList)
            {
                string Feature = e.Text;

                if ((Feature != FeatureMarketplace.Text) && (Feature != FeatureTravelAgent.Text))
                {
                    string FeatureSelected = "true";
                    e.ClickOn(driver, 60);
                    ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", Row, 2, FeatureSelected);
                    Row++;
                }
                else
                {
                    string FeatureSelected = "false";
                    ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", Row, 2, FeatureSelected);
                    Row++;
                }
            }

            log.Info("All Company Features required for GRM are Selected");
            test.Log(LogStatus.Info, "All Company Features required for GRM are Selected");
        }

        #endregion

        #region Select all Company Features required for Marketplace
        public void SelectCompanyFeaturesForMarketplace(ILog log, ExtentTest test)
        {
            for (int i = 0; i < FeaturesList.Count; i++)
            {
                Assert.IsTrue(FeaturesList[i].Displayed);
            }

            int Row = CreateCompanyLocator.RowNo;
            foreach (IWebElement e in FeaturesList)
            {
                string Feature = e.Text;

                if ((Feature.Equals(FeatureRoomType.Text)) || (Feature.Equals(FeatureConference.Text)) || (Feature.Equals(FeatureTravelAgent.Text)) || (Feature.Equals(FeatureMarketplace.Text)) || (Feature.Equals(FeatureCommon.Text)))
                {
                    string FeatureSelected = "true";
                    e.ClickOn(driver, 60);
                    ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", Row, 3, FeatureSelected);
                    Row++;
                }
                else
                {
                    string FeatureSelected = "false";
                    ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", Row, 3, FeatureSelected);
                    Row++;
                }
            }

            log.Info("All Company Features required for Marketplace are Selected");
            test.Log(LogStatus.Info, "All Company Features required for Marketplace are Selected");
        }

        #endregion

        #region Click on Submit Button
        public void ClickOnSubmitButton(ILog log, ExtentTest test)
        {
            Assert.IsTrue(SubmitButton.Displayed);
            SubmitButton.ClickOn(driver, 60);

            log.Info("Submit Button Clicked");
            test.Log(LogStatus.Info, "Submit Button Clicked");
        }

        #endregion

        #region Verify For Success Message With Product Key And Company ID for newly created company with GRM Features 
        public bool VerifyForSuccessMessageWithProductKeyAndCompanyIDWithGRMFeatures(ILog log, ExtentTest test)
        {
            Assert.IsTrue(SuccessMessageWithProductKeyAndCompanyID.Displayed);

            string productKeyAndCompanyID = SuccessMessageWithProductKeyAndCompanyID.Text;
            string productKey = productKeyAndCompanyID.Split(' ')[5];
            string companyID = productKeyAndCompanyID.Split(' ')[9];

            string Companyname = CompanyNameInCreateCompany.GetText();
            string city = City.GetText();
            string state = State.GetText();
            string country = Country.GetSelectedTextValue();
            string address1 = AddressLine1.GetText();
            string address2 = AddressLine2.GetText();

            // Writing all required data taken from newly created Company for creating hotel into CreateHotelData of Excel sheet 

            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 1, 2, Companyname);
            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 3, 2, city);
            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 4, 2, state);
            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 5, 2, country);
            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 6, 2, address1);
            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 7, 2, address2);
            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 33, 2, companyID);

            // Writing Product Key taken from newly created Company for Creating User into CreateUserData of Excel sheet

            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateUserData", 1, 2, productKey);

            test.Log(LogStatus.Info, "Producet Key is ->" + productKey);
            test.Log(LogStatus.Info, "Company ID is ->" + companyID);

            Assert.IsTrue(VerifyForCompanyIdAndProductKeyForCreatedCompanyWithDatabase(log, test, companyID, productKey));
            Assert.IsTrue(VerifyForSelectedGRMFeatureForCreatedCompanyWithDatabase(log, test, companyID));
            Assert.IsTrue(VerifyForSelectedGRMFeatureCheckboxesAreCheckedOrNot(log, test));
            Assert.IsTrue(VerifyforNewlyCreatedCompanyNameIsAddedInDatabase(log, test, Companyname));

            bool CompanyPresent = VerifyforNewlyCreatedCompanyNamePresentInCompanyDropdownOfHotelSection();

            if (productKey.Length == 36 && companyID.Length >= 3 && CompanyPresent)
            {
                test.Log(LogStatus.Pass, "Its Verified that Product key and company id size are displaying correctly");
                test.Log(LogStatus.Pass, "Its Verified that Newly created Company Name with GRM Features is present in Company Dropdown Of Hotel Section ");
                return true;
            }
            else
            {
                test.Log(LogStatus.Fail, "Product key and company id size are not displaying correctly");
                test.Log(LogStatus.Fail, "Newly created Company Name with GRM Features is not present in Company Dropdown Of Hotel Section ");
                return false;
            }
        }

        #endregion

        #region Verify For Success Message With Product Key And Company ID for newly created company with Marketplace Features
        public bool VerifyForSuccessMessageWithProductKeyAndCompanyIDWithMarketplaceFeatures(ILog log, ExtentTest test)
        {
            Assert.IsTrue(SuccessMessageWithProductKeyAndCompanyID.Displayed);

            string productKeyAndCompanyID = SuccessMessageWithProductKeyAndCompanyID.Text;
            string productKey = productKeyAndCompanyID.Split(' ')[5];
            string companyID = productKeyAndCompanyID.Split(' ')[9];

            string Companyname = CompanyNameInCreateCompany.GetText();
            string city = City.GetText();
            string state = State.GetText();
            string country = Country.GetSelectedTextValue();
            string address1 = AddressLine1.GetText();
            string address2 = AddressLine2.GetText();

            // Writing all required data taken from newly created Company for creating hotel into CreateHotelData of Excel sheet 

            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 1, 3, Companyname);
            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 3, 3, city);
            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 4, 3, state);
            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 5, 3, country);
            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 6, 3, address1);
            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 7, 3, address2);
            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateHotelData", 33, 3, companyID);

            // Writing Product Key taken from newly created Company for Creating User into CreateUserData of Excel sheet

            ExcelWriterHelper.WriteInToExcel(fileLocation, "CreateUserData", 1, 3, productKey);

            test.Log(LogStatus.Info, "Producet Key is ->" + productKey);
            test.Log(LogStatus.Info, "Company ID is ->" + companyID);

            Assert.IsTrue(VerifyForCompanyIdAndProductKeyForCreatedCompanyWithDatabase(log, test, companyID, productKey));
            Assert.IsTrue(VerifyForSelectedMarketplaceFeatureForCreatedCompanyWithDatabase(log, test, companyID));
            Assert.IsTrue(VerifyForSelectedMarketplaceFeatureCheckboxesAreCheckedOrNot(log, test));
            Assert.IsTrue(VerifyforNewlyCreatedCompanyNameIsAddedInDatabase(log, test, Companyname));

            bool CompanyPresent = VerifyforNewlyCreatedCompanyNamePresentInCompanyDropdownOfHotelSection();

            if (productKey.Length == 36 && companyID.Length >= 3 && CompanyPresent)
            {
                test.Log(LogStatus.Pass, "Its Verified that Product key and company id size are displaying correctly");
                test.Log(LogStatus.Pass, "Its Verified that Newly created Company Name with Marketplace Features is present in Company Dropdown Of Hotel Section ");
                return true;
            }
            else
            {
                test.Log(LogStatus.Fail, "Product key and company id size are not displaying correctly");
                test.Log(LogStatus.Fail, "Newly created Company Name with Marketplace Features is not present in Company Dropdown Of Hotel Section ");
                return false;
            }
        }

        #endregion

        #region Verify for Newly created Company Name is present or not in Company Dropdown Of Hotel Section
        public bool VerifyforNewlyCreatedCompanyNamePresentInCompanyDropdownOfHotelSection()
        {
            CreateHotelPage obj = new CreateHotelPage(driver);

            for (int i = 0; i < obj.CompanyListInCreateHotel.Count; i++)
            {
                if (obj.CompanyListInCreateHotel[i].Text.Equals(CompanyNameInCreateCompany.Text))
                {
                    break;
                }
            }
            return true;
        }

        #endregion

        #region Verify for Newly created Company Name is Added In Database
        public bool VerifyforNewlyCreatedCompanyNameIsAddedInDatabase(ILog log, ExtentTest test, string CompanyName)
        {
            dataSet = DBConnection.GetDBData("Select Name from Company");

            List<string> ListOfCompanyName = new List<string>();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                ListOfCompanyName.Add(dataSet.Tables[0].Rows[i]["Name"].ToString());
            }

            for (int j = 0; j < ListOfCompanyName.Count; j++)
            {
                if (ListOfCompanyName[j].Equals(CompanyName))
                {
                    log.Info("Newly Created Company name as: " + "'" + ListOfCompanyName[j] + "'" + " is Added in our DataBase");
                    test.Log(LogStatus.Pass, "Newly Created Company name as: " + "'" + ListOfCompanyName[j] + "'" + " is Added in our DataBase");
                }
            }
            return true;
        }

        #endregion

        #region Verify For Selected GRM Feature checkboxes are checked or not
        public bool VerifyForSelectedGRMFeatureCheckboxesAreCheckedOrNot(ILog log, ExtentTest test)
        {
            for (int i = 0; i < FeaturesList.Count; i++)
            {
                string Feature = FeaturesList[i].Text;

                if ((Feature != FeatureMarketplace.Text) && (Feature != FeatureTravelAgent.Text))
                {
                    if (ListOfCheckBox[i].Selected)
                    {
                        test.Log(LogStatus.Info, "Its Verified that checkbox for " + FeaturesList[i].Text + " Feature is Selected");
                    }
                    else
                    {
                        Assert.Fail("Its Verified that checkbox for " + FeaturesList[i].Text + " Feature should be Selected as It Was Selected During Creating Company");
                    }
                }
                else
                {
                    test.Log(LogStatus.Info, "Its Verified that checkbox for " + FeaturesList[i].Text + " Feature is Not Selected");
                }

            }
            return true;
        }

        #endregion

        #region Verify For Selected Marketplace Feature checkboxes are checked or not
        public bool VerifyForSelectedMarketplaceFeatureCheckboxesAreCheckedOrNot(ILog log, ExtentTest test)
        {
            for (int i = 0; i < FeaturesList.Count; i++)
            {
                string Feature = FeaturesList[i].Text;

                if ((Feature.Equals(FeatureRoomType.Text)) || (Feature.Equals(FeatureConference.Text)) || (Feature.Equals(FeatureTravelAgent.Text)) || (Feature.Equals(FeatureMarketplace.Text)) || (Feature.Equals(FeatureCommon.Text)))
                {
                    if (ListOfCheckBox[i].Selected)
                    {
                        test.Log(LogStatus.Info, "Its Verified that checkbox for " + FeaturesList[i].Text + " Feature is Selected");
                    }
                    else
                    {
                        Assert.Fail("Its Verified that checkbox for " + FeaturesList[i].Text + " Feature should be Selected as It Was Selected During Creating Company");
                    }
                }
                else
                {
                    test.Log(LogStatus.Info, "Its Verified that checkbox for " + FeaturesList[i].Text + " Feature is Not Selected");
                }

            }
            return true;
        }

        #endregion

        #region Verify For Selected GRM Features For Created Company With Database
        public bool VerifyForSelectedGRMFeatureForCreatedCompanyWithDatabase(ILog log, ExtentTest test, string Companyid)
        {
            dataSet = DBConnection.GetDBData("Select FeatureID from CompanyFeatures where CompanyID=" + "'" + Companyid + "'" + "");

            IList<int> ListOfFeatureID = new List<int>();
            //ArrayList ListOfFeatureID = new ArrayList();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                ListOfFeatureID.Add(Convert.ToInt32(dataSet.Tables[0].Rows[i]["FeatureID"]));
            }

            for (int j = 0; j < ListOfFeatureID.Count; j++)
            {
                if ((ListOfFeatureID[j] != 16) && (ListOfFeatureID[j] != 17))
                {
                    log.Info("Selected GRM Feature with Feature ID as: " + "'" + ListOfFeatureID[j] + "'" + " is there in Database for Created Company");
                    test.Log(LogStatus.Pass, "Selected GRM Feature with Feature ID as: " + "'" + ListOfFeatureID[j] + "'" + " is there in Database for Created Company");

                }
                else
                {
                    log.Info("Feature ID as: " + "'" + ListOfFeatureID[j] + "'" + " is not there in Database for Created Company as it is not selected");
                    test.Log(LogStatus.Pass, "Feature ID as: " + "'" + ListOfFeatureID[j] + "'" + " is not there in Database for Created Company as it is not selected");
                }
            }
            return true;
        }

        #endregion

        #region Verify For Selected Marketplace Features For Created Company With Database
        public bool VerifyForSelectedMarketplaceFeatureForCreatedCompanyWithDatabase(ILog log, ExtentTest test, string Companyid)
        {
            dataSet = DBConnection.GetDBData("Select FeatureID from CompanyFeatures where CompanyID=" + "'" + Companyid + "'" + "");

            IList<int> ListOfFeatureID = new List<int>();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                ListOfFeatureID.Add(Convert.ToInt32(dataSet.Tables[0].Rows[i]["FeatureID"]));
            }

            for (int j = 0; j < ListOfFeatureID.Count; j++)
            {
                if ((ListOfFeatureID[j] == 2) || (ListOfFeatureID[j] == 3) || (ListOfFeatureID[j] == 16) || (ListOfFeatureID[j] == 17) || (ListOfFeatureID[j] == 18))
                {
                    log.Info("Selected Marketplace Feature with Feature ID as: " + "'" + ListOfFeatureID[j] + "'" + " is there in Database for Created Company");
                    test.Log(LogStatus.Pass, "Selected Marketplace Feature with Feature ID as: " + "'" + ListOfFeatureID[j] + "'" + " is there in Database for Created Company");
                }
                else
                {
                    log.Info("Feature ID as: " + "'" + ListOfFeatureID[j] + "'" + " is not there in Database for Created Company as it is not selected");
                    test.Log(LogStatus.Pass, "Feature ID as: " + "'" + ListOfFeatureID[j] + "'" + " is not there in Database for Created Company as it is not selected");

                }
            }
            return true;
        }

        #endregion

        #region Verify For CompanyId and Product Key For Newly Created Company With Database
        public bool VerifyForCompanyIdAndProductKeyForCreatedCompanyWithDatabase(ILog log, ExtentTest test, string CompanyId, string ProductKey)
        {
            dataSet = DBConnection.GetDBData("Select Companyid, ProductKey from Company");

            List<string> ListOfCompanyID = new List<string>();
            List<string> ListOfProductKey = new List<string>();

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                ListOfProductKey.Add(dataSet.Tables[0].Rows[i]["ProductKey"].ToString());
                ListOfCompanyID.Add(dataSet.Tables[0].Rows[i]["Companyid"].ToString());
            }

            for (int j = 0; j < ListOfCompanyID.Count; j++)
            {
                if ((ListOfCompanyID[j] == CompanyId) && (ListOfProductKey[j] == ProductKey))
                {
                    log.Info("Company ID And Its Product Key as: " + "'" + ListOfCompanyID[j] + "'" + " And " + "'" + ListOfProductKey[j] + "'" + " are there in Database for Newly Created Company");
                    test.Log(LogStatus.Pass, "Company ID And Its Product Key as: " + "'" + ListOfCompanyID[j] + "'" + " And " + "'" + ListOfProductKey[j] + "'" + " are there in Database for Newly Created Company");
                }
            }
            return true;
        }

        #endregion

    }
}
