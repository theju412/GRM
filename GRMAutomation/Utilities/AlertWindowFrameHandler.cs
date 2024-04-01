using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace GRMAutomation.Utilities
{
    public class AlertWindowFrameHandler
    {
        public static void SwitchOnAlert(IWebDriver driver)
        {            
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            //alert.Dismiss();
            driver.SwitchTo().DefaultContent();
        }

        public static void SwitchOnDefaultWindow(IWebDriver driver)
        {
            string mainWindowHandle = driver.CurrentWindowHandle;
            //driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Window(mainWindowHandle);
        }

        public static void SwitchOnFrame(IWebDriver driver, string frameName)
        {
            //IList<IWebElement> iframeElements = driver.FindElements(By.TagName("iframe"));
            //Console.WriteLine("The total number of iframes are " + iframeElements.Count);

            driver.SwitchTo().Frame(frameName);            
        }

        public static void SwitchOnWindow(IWebDriver driver)
        {
            string mainWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Current Window Handle -> " + mainWindowHandle);

            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            string newWindowHandle = "";
            foreach(string handle in windowHandles)
            {
                if(handle != mainWindowHandle)
                {
                    newWindowHandle = handle;
                    break;
                }
            }

            driver.SwitchTo().Window(newWindowHandle);
            Thread.Sleep(3000);            
            Console.WriteLine("Title of new Window Handle is -> " + driver.Title);
            string urlOfNewWindowOpened = driver.Url;
            Console.WriteLine(urlOfNewWindowOpened);


            
            //driver.Close();

            //driver.SwitchTo().Window(mainWindowHandle);
            Console.WriteLine("Title of old Window handle is -> " + driver.Title);
          
        }
    }
}
