using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecflowCoveaTest.Hooks
{
    public class TestInitialize
    {
        /*start test implement
         
        [TestMethod]//Scenario:1

        public class SelectMrTitleFromDropdown()
        {
            IWebDriver driver = new FirefoxDriver();
        driver.Url = "user quote page link";
            Select drptitle = new(driver.FindElement(By.Name("enter locator")));
        drptitle.selectByVisibleText("Mr");

        }
        end test*/

        /*Start test implment

            [TestMethod]//Scenario:2
            public class Invalidemailaddressisentered()
             {
                IWebDriver driver = new FirefoxDriver();
                driver.Url = "user quote page link";
                driver.FindElement(By.Name("email address locator")).sendKeys("usha@gmail");
                Boolean result = Driver.FindElement(By.Name("error message locator").isDisplayed();
                if(result)
                 {
                   console.WriteLine("Error message is displayed");
                 }
                 else
                 {
                   Console.WriteLine("No error message is displayed");
                 }
             }
        End test*/

        /* Start test
                 [TestMethod]//Scenario:3
           public class Validemailaddressisentered()
             {
               IWebDriver driver = new FirefoxDriver();
               driver.Url = "user quote page link";
               driver.FindElement(By.Name("email address locator")).sendKeys("usha@gmail.com");
               Boolean resultvalid = Driver.FindElement(By.Name("error message locator").isDisplayed();
             }
        End test*/

        /* Start test
             [TestMethod]//Scenario:4
        public class Lookupforvalidpostcode()
         {
           IWebDriver driver = new FirefoxDriver();
           driver.Url = "user quote page link";
           driver.FindElement(By.Name("First Name")).sendKeys("Firstname");
           driver.FindElement(By.Name("SurName")).sendKeys("Surname");
           driver.FindElement(By.Name("ContactNum")).sendKeys("07404133984");
           driver.FindElement(By.Name("Postcode")).sendKeys("RG217UN");
           Actions actions = new Actions(driver)
           actions.Click(driver.FindElement(By.Name("Findaddress")).click());
           driver.FindElement(By.Name("Listofaddress")).isDisplayed();
           Thread.sleep(2000);
           driver.Quit();
        }
        End Test */

        /* Start test
     [TestMethod]//Scenario:5
     public class Quotefromcompleted()
      {
       IWebDriver driver = new FirefoxDriver();
       driver.Url = "user quote page link";
       driver.FindElement(By.Name("First Name")).sendKeys("Firstname");
       driver.FindElement(By.Name("SurName")).sendKeys("Surname");
       driver.FindElement(By.Name("ContactNum")).sendKeys("07404133984");
       driver.FindElement(By.Name("Postcode")).sendKeys("RG217UN");
       Actions actions = new Actions(driver)
       actions.Click(driver.FindElement(By.Name("continue")).click());
       driver.FindElement(By.Name("Summarypageelement")).isDisplayed();
       Thread.sleep(2000);
       driver.Quit();
     }
    End Test */



    }
}
