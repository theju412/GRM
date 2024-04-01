using GRMAutomation.DataReader;
using GRMAutomation.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMAutomation.Tests
{
    class TestDB : ScreenCapturer
    {
        [Test]
        public void DBTest()
        {
            
            dataSet = DBConnection.GetDBData("Select Name from Company");

            //dataSet = DBConnection.GetDBData("Select Name from Company where companyid=147");
            //string CompanyName= dataSet.Tables[0].Rows[0]["Name"].ToString();
            //Console.WriteLine(CompanyName.ToString());

            List<string> ListOfCompanyName = new List<string>();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                ListOfCompanyName.Add(dataSet.Tables[0].Rows[i]["Name"].ToString());
            }

            for (int j = 0; j < ListOfCompanyName.Count; j++)
            {
                Console.WriteLine(ListOfCompanyName[j].ToString());
            }


            //dataSet = DBConnection.GetDBData("select top 10 * from [User]");
            //List<string> listEmailAddress = new List<string>();
            //for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            //{
            //    listEmailAddress.Add(dataSet.Tables[0].Rows[i]["Email"].ToString());
            //}
            //for (int j = 0; j < listEmailAddress.Count; j++)
            //{
            //    Console.WriteLine(listEmailAddress[j].ToString());
            //}
        }
    }
}
