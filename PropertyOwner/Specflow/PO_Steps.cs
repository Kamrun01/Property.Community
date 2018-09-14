using Keys_Onboarding.Config;
using Keys_Onboarding.Global;
using Keys_Onboarding.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using TechTalk.SpecFlow;
using static Keys_Onboarding.Global.CommonMethods;

namespace Keys_Onboarding
{
    [Binding]
    public class PropertyOwnerSteps : Global.Base
    {
        [Given(@"user have logged into the application")]
        public void GivenUserHaveLoggedIntoTheApplication()
        {
            switch (Browser)
            {

                case 1:
                    Driver.driver = new FirefoxDriver();
                    break;
                case 2:
                    Driver.driver = new ChromeDriver();
                    Driver.driver.Manage().Window.Maximize();
                    break;

            }
            if (Keys_Resource.IsLogin == "true")
            {
                Login loginobj = new Login();
                loginobj.LoginSuccessfull();
            }
            else
            {
                Register obj = new Register();
                obj.Navigateregister();
            }

            extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(Keys_Resource.ReportXMLPath);
        }
        
        [Then(@"User search results for property are successfull")]
        public void ThenUserSearchResultsForPropertyAreSuccessfull()
        {
            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest("Search for a Property");

            // Create an class and object to call the method
            PropertyOwner obj = new PropertyOwner();
            obj.SearchAProperty();

            //Close the broswer
            Global.Driver.driver.Close();
        }

        [When(@"All input fields have been populated")]
        public void WhenAllInputFieldsHaveBeenPopulated()
        {
            // Creates a toggle for the given test, adds all log events under it  
            test = extent.StartTest("Add a new Property");
            // Create an class and object to call the method
            PropertyPage newProperty = new PropertyPage();
            newProperty.AddingProperty();
        }

        [Then(@"New Property should be displayed")]
        public void ThenNewPropertyShouldBeDisplayed()
        {
            System.Threading.Thread.Sleep(5000);

            //Assert new property
            var expectedValue = "TestProperty1";
            var actualValue = Global.Driver.driver.FindElements(By.ClassName("segment"))[0].FindElement(By.TagName("h3")).Text;

            if (expectedValue == actualValue)
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed, New Property added successfully");
            }
            else
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, failed to add new property");
            }
            //take screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Image example: " + img);
            //End the test
            extent.EndTest(test);
            extent.Flush();
            test = null;
            //Close the browser
            Global.Driver.driver.Close();
        }
        
        [When(@"User edit  an existing property")]
        public void WhenUserEditAnExistingProperty()
        {
            // Creates a toggle for the given test, adds all log events under it  
            test = extent.StartTest("Editing an existing Property");
            System.Threading.Thread.Sleep(5000);
            // Create an class and object to call the method
            var editPropertyPage = new PropertyPage();
            editPropertyPage.editProperty();
        }

        [Then(@"Edited Property should be displayed")]
        public void ThenEditedPropertyShouldBeDisplayed()
        {
            System.Threading.Thread.Sleep(5000);
            //Assert edit property
            var expectedValue = "EditedTestProperty";
            var actualValue = Global.Driver.driver.FindElements(By.ClassName("segment"))[0].FindElement(By.TagName("h3")).Text;
            
            if (expectedValue == actualValue)
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed,Property edited successfully");
            }
            else
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, failed to edit property");
            }
            //take screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Image example: " + img);
            //End test
            extent.EndTest(test);
            extent.Flush();
            test = null;
            //Close the browser
            Global.Driver.driver.Close();
        }

        [When(@"User deletes an existing property")]
        public void WhenUserDeletesAnExistingProperty()
        {
            // Creates a toggle for the given test, adds all log events under it  
            test = extent.StartTest("Deleting an existing Property");
            System.Threading.Thread.Sleep(5000);
            // Create an class and object to call the method
            PropertyPage deletePropertyPage = new PropertyPage();
            deletePropertyPage.deleteProperty();
        }

        [Then(@"Deleted property should not appear in Property list")]
        public void ThenDeletedPropertyShouldNotAppearInPropertyList()
        {
            System.Threading.Thread.Sleep(5000);
            //Assert delete property
            var expectedValue = "EditedTestProperty";
            var actualValue = Global.Driver.driver.FindElements(By.ClassName("segment"))[0].FindElement(By.TagName("h3")).Text;

            if (expectedValue != actualValue)
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed,Property deleted successfully");
            }
            else
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, failed to delete property");
            }
            //take screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Image example: " + img);
            //end test
            extent.EndTest(test);
            extent.Flush();
            test = null;
            //close the browser
            Global.Driver.driver.Close();
        }

        [When(@"All input fields for repayment and expenses and liabilities have been populated")]
        public void WhenAllInputFieldsForRepaymentAndExpensesAndLiabilitiesHaveBeenPopulated()
        {
            // Creates a toggle for the given test, adds all log events under it  
            test = extent.StartTest("Testing repayment, expenses and liabilities options");
            System.Threading.Thread.Sleep(5000);
            // Create an class and object to call the method
            PropertyPage property = new PropertyPage();
            property.RepaymentExpensesLiabilities();
        }

        [Then(@"New property should be added")]
        public void ThenNewPropertyShouldBeAdded()
        {
            System.Threading.Thread.Sleep(5000);
            //Assert added property
            string expectedValue = "TestProperty1";
            var actualValue = Global.Driver.driver.FindElements(By.ClassName("segment"))[0].FindElement(By.TagName("h3")).Text;

            if (expectedValue == actualValue)
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed, New Property added successfully");
            }
            else
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, failed to add new property");
            }
            //take screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Image example: " + img);
            //end test
            extent.EndTest(test);
            extent.Flush();
            test = null;
            //close the browser
            Global.Driver.driver.Close();
        }

        [When(@"Input fields for rental property have been populated")]
        public void WhenInputFieldsForRentalPropertyHaveBeenPopulated()
        {
            // Creates a toggle for the given test, adds all log events under it  
            test = extent.StartTest("Add a new Rental Property");
            // Create an class and object to call the method
            PropertyPage newProperty = new PropertyPage();
            newProperty.ListARental();
        }

        [Then(@"New renatl property should be added")]
        public void ThenNewRenatlPropertyShouldBeAdded()
        {
            System.Threading.Thread.Sleep(5000);
            //assert added rental property
            string expectedValue = "http://new-keys.azurewebsites.net/PropertyOwners";
            var actualValue = Global.Driver.driver.Url;

            if (expectedValue == actualValue)
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed, New Rental Property added successfully");
            }
            else
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, failed to add new rental property");
            }
            //take screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Image example: " + img);
            //end test
            extent.EndTest(test);
            extent.Flush();
            test = null;
            //close the browser
            Global.Driver.driver.Close();
        }

        [When(@"Input fields for advertised jobs have been populated")]
        public void WhenInputFieldsForAdvertisedJobsHaveBeenPopulated()
        {
            // Creates a toggle for the given test, adds all log events under it  
            test = extent.StartTest("Add a new Advertised Job");
            // Create an class and object to call the method
            PropertyPage newProperty = new PropertyPage();
            newProperty.AddingAdvertisedJobs();
        }

        [Then(@"New advertised jobs should be added")]
        public void ThenNewAdvertisedJobsShouldBeAdded()
        {
            System.Threading.Thread.Sleep(5000);
            //Assert added property
            string expectedValue = "Toilet Problem";
            var actualValue = Global.Driver.driver.FindElement(By.XPath("//*[@id='main-content']/div/div[1]/div[3]/div/div[1]/div[2]/div[1]/div[1]/a")).Text;

            if (expectedValue == actualValue)
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed, New Advertised Job added successfully");
            }
            else
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, failed to add new job");
            }
            //take screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Image example: " + img);
            //end test
            extent.EndTest(test);
            extent.Flush();
            test = null;
            //close the browser
            Global.Driver.driver.Close();
        }

        [When(@"User edit an existing Advirtisement job")]
        public void WhenUserEditAnExistingAdvirtisementJob()
        {
            // Creates a toggle for the given test, adds all log events under it  
            test = extent.StartTest("Edit a new Advertised Job");
            // Create an class and object to call the method
            PropertyPage newProperty = new PropertyPage();
            newProperty.EditAdvertisedJobs();
        }

        [Then(@"Edited Job should appear in the list")]
        public void ThenEditedJobShouldAppearInTheList()
        {
            System.Threading.Thread.Sleep(5000);
            //Assert added property
            string expectedValue = "http://new-keys.azurewebsites.net/PropertyOwners/Manage/MyMarketJobs";
            var actualValue = Global.Driver.driver.Url;

            if (expectedValue == actualValue)
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed,Advertised Job edited successfully");
            }
            else
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, failed to edit job");
            }
            //take screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Image example: " + img);
            //end test
            extent.EndTest(test);
            extent.Flush();
            test = null;
            //close the browser
            Global.Driver.driver.Close();
        }



        [When(@"User deletes an existing Advirtisement job")]
        public void WhenUserDeletesAnExistingAdvirtisementJob()
        {
            // Creates a toggle for the given test, adds all log events under it  
            test = extent.StartTest("Delete a new Advertised Job");
            // Create an class and object to call the method
            PropertyPage newProperty = new PropertyPage();
            newProperty.DeleteAdvertisedJobs();
        }

        [Then(@"Deleted Job should not appear in the list")]
        public void ThenDeletedJobShouldNotAppearInTheList()
        {
            System.Threading.Thread.Sleep(5000);
            //Assert added property
            string expectedValue = "http://new-keys.azurewebsites.net/PropertyOwners/Manage/MyMarketJobs";
            var actualValue = Global.Driver.driver.Url;

            if (expectedValue == actualValue)
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed,Advertised Job deleted successfully");
            }
            else
            {
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, failed to delete job");
            }
            //take screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Image example: " + img);
            //end test
            extent.EndTest(test);
            extent.Flush();
            test = null;
            //close the browser
            Global.Driver.driver.Close();
        }


    }
}
