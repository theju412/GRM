using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMAutomation.PageObjects.Locator
{
    class CreateUserLocator
    {
        public const string ProductKeyField = "//input[@id='txtProductKey']";
        public const string TitleField = "//input[@id='txtTitle']";
        public const string FirstNameField = "//input[@id='txtFirstName']";
        public const string LastNameField = "//input[@id='txtLastName']";
        public const string EmailIdField = "//input[@id='txtEmailAddress']";
        public const string PasswordField = "//input[@id='txtNewPassword']";
        public const string ConfirmPasswordField = "//input[@id='txtConfirmPassword']";
        public const string UserRoleDropdown = "//select[@id='ddlRole']";

        public const string ListOfUserRoles = "//select[@id='ddlRole']//option";

        public const string SubmitButton = "//input[@id='btnCreateUser']";
        public const string InvalidProductKeyMessage = "//span[text()='The product key entered is not valid']";
        public const string AlreadyExistMessage = "//span[text()='A user already exists with the email address provided']";
        public const string UserCreatedMessage = "//span[text()='User is created']";
    }
}
