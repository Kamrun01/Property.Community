using Keys_Onboarding.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using static Keys_Onboarding.Global.CommonMethods;
using System.Diagnostics;
using OpenQA.Selenium.Interactions;
using System.Windows.Forms;

namespace Keys_Onboarding.Pages
{
    class PropertyPage
    {
        public PropertyPage()
        {
            PageFactory.InitElements(Global.Driver.driver, this);
        }

        #region Initialize WebElements
        //Finding Skip button
        [FindsBy(How = How.ClassName, Using = "introjs-skipbutton")]
        private IWebElement SkipButton { get; set; }
        //Finding the owner
        [FindsBy(How = How.CssSelector, Using = "body > div.ui.fixed.top.text.menu > div > div.right.menu > div:nth-child(2)")]
        private IWebElement OwnersSelect { set; get; }

        //Finding property option
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[1]")]
        private IWebElement PropertiesSelect { set; get; }

        //Clicking add new property
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[1]/div/div[2]/div/div[2]/a[2]")]
        private IWebElement ClickingAddNewProperty { set; get; }

        //IWebElements for property details
        //Finding property name field 
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[2]/div[1]/div[1]/input")]
        private IWebElement PropertyName { set; get; }

        //Finding SearchAddress field 
        [FindsBy(How = How.XPath, Using = "//*[@id='autocomplete']")]
        private IWebElement SearchAddress { set; get; }

        //Finding TargetRent field
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[4]/div/div[1]/div[1]/input")]
        private IWebElement TargetRent { set; get; }

        //Finding LandArea field
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[5]/div[1]/div/input")]
        private IWebElement LandArea { set; get; }

        //Finding BedRooms field      
        [FindsBy(How = How.CssSelector, Using = "#property-details > div:nth-child(7) > div:nth-child(1) > div.ui.input.full.width > input[type='text']")]
        private IWebElement BedRooms { set; get; }

        //Finding CarParks field
        [FindsBy(How = How.CssSelector, Using = "#property-details > div:nth-child(8) > div:nth-child(1) > div.ui.input.full.width > input[type='text']")]
        private IWebElement CarParks { set; get; }

        //Finding FindingPropertyField field
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[2]/div[2]/div")]
        private IWebElement PropertyTypeField { set; get; }
      

        //Finding Description field
        [FindsBy(How = How.XPath, Using = " //*[@id='property-details']/div[3]/div[2]/div[1]/textarea")]
        private IWebElement Description { set; get; }

        //Finding RentType field
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[4]/div/div[2]/div")]
        private IWebElement RentTypeField { set; get; }
      
        //Finding FloorArea field
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[5]/div[2]/div/input")]
        private IWebElement FloorArea { set; get; }

        //Finding BathRooms field
        [FindsBy(How = How.CssSelector, Using = "#property-details > div:nth-child(7) > div:nth-child(2) > div.ui.input.full.width > input[type='text']")]
        private IWebElement BathRooms { set; get; }

        //Finding YearBuilt field
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[7]/div[2]/div[1]/input")]
        private IWebElement YearBuilt { set; get; }

        //Finding image box
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[7]/div[2]/div[1]/input")]
        private IWebElement imagebox { set; get; }

        //Finding Next button
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[10]/div/button[1]")]
        private IWebElement NextButton { set; get; }

        //IWebElements for Financial details
        //Finding PurchasePrice field
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[1]/div[1]/div[1]/input")]
        private IWebElement PurchasePrice { set; get; }

        //Finding HomeValue field
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[1]/div[3]/div[1]/input")]
        private IWebElement HomeValue { set; get; }

        //Finding Mortgage field
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[1]/div[2]/div[1]/input")]
        private IWebElement Mortgage { set; get; }

        //Finding AddRepayment field
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[4]/div/a/i")]
        private IWebElement AddRepayment { set; get; }

        //Finding RepaymentAmount field
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[3]/div/div[1]/div[1]/input")]
        private IWebElement RepaymentAmount { set; get; }

        //Finding RepaymentStartDate field
        [FindsBy(How = How.XPath, Using = "//*[@id='payment-start-date']")]
        private IWebElement RepaymentStartDate { set; get; }

        //Finding RepaymentEndDate field
        [FindsBy(How = How.XPath, Using = "//*[@id='payment-end-date']")]
        private IWebElement RepaymentEndDate { set; get; }

        //Finding AddExpense field
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[7]/div/a/i")]
        private IWebElement AddExpense { set; get; }

        //Finding ExpenseAmount field
        [FindsBy(How = How.XPath, Using = "//*[@id='Text1']")]
        private IWebElement ExpenseAmount { set; get; }

        //Finding ExpenseDate field
        [FindsBy(How = How.XPath, Using = "//*[@id='expense-date']")]
        private IWebElement ExpenseDate { set; get; }

        //Finding NextButton2 field
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[8]/button[3]")]
        private IWebElement NextButton2 { set; get; }

        //IWebElements for Tenant details
        //Finding TenantEmail field
        [FindsBy(How = How.XPath, Using = "//*[@id='email']")]
        private IWebElement TenantEmail { set; get; }

        //Finding IsMainTenant field
        [FindsBy(How = How.XPath, Using = "//*[@id='tenantSection']/div[1]/div[2]/div/select")]
        private IWebElement IsMainTenant { set; get; }

        //Finding FirstName field
        [FindsBy(How = How.XPath, Using = "//*[@id='fname']")]
        private IWebElement FirstName { set; get; }

        //Finding LastName field
        [FindsBy(How = How.XPath, Using = "//*[@id='lname']")]
        private IWebElement LastName { set; get; }

        //Finding StartDate field
        [FindsBy(How = How.XPath, Using = "//*[@id='sdate']")]
        private IWebElement StartDate { set; get; }

        //Finding EndDate field
        [FindsBy(How = How.XPath, Using = "//*[@id='edate']")]
        private IWebElement EndDate { set; get; }

        //Finding RentAmount field
        [FindsBy(How = How.XPath, Using = "//*[@id='ramount']")]
        private IWebElement RentAmount { set; get; }

        //Finding PaymentFrequency field
        [FindsBy(How = How.XPath, Using = "//*[@id='pfrequency']")]
        private IWebElement PaymentFrequency { set; get; }

        //Finding PaymentStartDate field
        [FindsBy(How = How.XPath, Using = "//*[@id='psdate']")]
        private IWebElement PaymentStartDate { set; get; }

        //Finding PaymentDueDay field
        [FindsBy(How = How.XPath, Using = "//*[@id='pddate']")]
        private IWebElement PaymentDueDay { set; get; }

        //Finding NewLiability field
        [FindsBy(How = How.XPath, Using = "//*[@id='tenantSection']/div[4]/a/i")]
        private IWebElement NewLiability { set; get; }

        //Finding Amount field
        [FindsBy(How = How.XPath, Using = "//*[@id='LiabilityDetail']/div/div[1]/div[2]/div[1]/input")]
        private IWebElement Amount { set; get; }

        //Finding Save field
        [FindsBy(How = How.XPath, Using = "//*[@id='saveProperty']")]
        private IWebElement Save { set; get; }

        //Finding EditProperty field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[1]/div/div[3]/div/div[1]/div/div/div[2]/div[1]/div[3]/div/div/div[4]")]
        private IWebElement EditProperty { set; get; }

        //Finding EditedPropertyName field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[3]/div[2]/form/div[1]/div[1]/div/input")]
        private IWebElement EditedPropertyName { set; get; }

        //Finding SaveEditedValue field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[3]/div[2]/form/div[8]/button[1]")]
        private IWebElement SaveEditedValue { set; get; }

        //Finding property name field for delete a property
        //Finding DeleteProperty field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[1]/div/div[3]/div/div[1]/div/div/div[2]/div[1]/div[3]/div/div/div[5]")]
        private IWebElement DeleteProperty { set; get; }

        //Finding DeleteConfirm field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[4]/div/div[2]/div[7]/button[1]")]
        private IWebElement DeleteConfirm { set; get; }


        //IWebElements for List A Rental
        //Finding ListRental field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[1]/div/div[2]/div/div[2]/a[1]")]
        private IWebElement ListRental { set; get; }

        //Finding SelectProperty field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[2]/select")]
        private IWebElement SelectProperty { set; get; }

        //Finding Title field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[3]/div[1]/input[1]")]
        private IWebElement Title { set; get; }

        //Finding MovingCost field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[3]/div[1]/input[2]")]
        private IWebElement MovingCost { set; get; }

        //Finding RentalDescription field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[3]/div[2]/textarea")]
        private IWebElement RentalDescription { set; get; }

        //Finding RentalTargetRent field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[4]/div[1]/input")]
        private IWebElement RentalTargetRent { set; get; }

        //Finding Furnishing field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[4]/div[2]/input")]
        private IWebElement Furnishing { set; get; }

        //Finding AvailableDate field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[5]/div[1]/input")]
        private IWebElement AvailableDate { set; get; }

        //Finding IdealTenant field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[5]/div[2]/input")]
        private IWebElement IdealTenant { set; get; }

        //Finding Occupants field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[6]/div[1]/input")]
        private IWebElement Occupants { set; get; }

        //Finding SaveRental field
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[8]/div/button[1]")]
        private IWebElement SaveRental { set; get; }

        //Finding Elements for Advertised Job
        //Finding Advertised Jobs & Quotes
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[4]")]
        private IWebElement AdvertisedJob { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[1]/div[2]/div/div[2]/a")]
        private IWebElement NewJobButton { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-job']/div/div[1]/div[1]/div[1]/div/i")]
        private IWebElement SelectPropertyForJob { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-job']/div/div[1]/div[1]/div[1]/div/div[2]/div[3]")]
        private IWebElement PropertyNameDropdown { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-job']/div/div[1]/div[1]/div[2]/div[1]/input")]
        private IWebElement TitleForJob { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-job']/div/div[1]/div[1]/div[3]/div[1]/input")]
        private IWebElement MaximumBudget { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-job']/div/div[1]/div[2]/div[1]/textarea")]
        private IWebElement JobDescription { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-job']/div/div[3]/div/div/button")]
        private IWebElement SubmitForJob { set; get; }

        //Finding elements of Edit option for advertised jobs

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[1]/div[3]/div/div[1]/div[2]/div[2]/div[1]")]
        private IWebElement EditForJob { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[2]/div/div[2]/form/div[3]/div/div/div/input")]
        private IWebElement EditedMaximumBudget { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[2]/div/div[2]/form/div[5]/button[1]")]
        private IWebElement SaveEdit { set; get; }

        //Finding elements of Delete option for advertised jobs
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[1]/div[3]/div/div[1]/div[2]/div[2]/div[3]")]
        private IWebElement DeleteForJob { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='jobDeleteModal']/div/div/div/div/div[1]/div/div/div[2]/div/label")]
        private IWebElement DeleteOpt2 { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='jobDeleteModal']/div/div/div/div/div[3]/div/button[1]")]
        private IWebElement ConfirmDelete { set; get; }
        #endregion

        #region Functions

        //Add new property
        internal void AddingProperty()
        {
            //To skip the highlighted option
            SkipButton?.Click();
            System.Threading.Thread.Sleep(5000);
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "AddNewProperty");
            System.Threading.Thread.Sleep(5000);
            OwnersSelect.Click();
            System.Threading.Thread.Sleep(5000);
            PropertiesSelect.Click();
            ClickingAddNewProperty.Click();
            //Value set for property details page
            PropertyName.SendKeys(ExcelLib.ReadData(2, "Value"));
            SearchAddress.SendKeys(ExcelLib.ReadData(33, "Value"));
            System.Threading.Thread.Sleep(5000);
            //Value set using google api
            var address = Global.Driver.driver.FindElements(By.ClassName("pac-item"))[0];
            address.Click();
            TargetRent.SendKeys(ExcelLib.ReadData(14, "Value"));
            LandArea.SendKeys(ExcelLib.ReadData(10, "Value"));
            BedRooms.SendKeys(ExcelLib.ReadData(11, "Value"));
            CarParks.SendKeys(ExcelLib.ReadData(12, "Value"));
            Description.SendKeys(ExcelLib.ReadData(13, "Value"));
            FloorArea.SendKeys(ExcelLib.ReadData(15, "Value"));
            BathRooms.SendKeys(ExcelLib.ReadData(16, "Value"));
            YearBuilt.SendKeys(ExcelLib.ReadData(9, "Value"));
            imagebox.Click();
            //Image upload
            Global.Driver.driver.FindElement(By.Id("file-upload")).Click();
            System.Threading.Thread.Sleep(10000);
            SendKeys.SendWait("E:\\Document\\house.jpg");
            System.Threading.Thread.Sleep(10000);
            SendKeys.SendWait(@"{Enter}");
            System.Threading.Thread.Sleep(5000);
            NextButton.Click();
            System.Threading.Thread.Sleep(5000);
            //Value set for financial details page
            PurchasePrice.SendKeys(ExcelLib.ReadData(17, "Value"));
            HomeValue.SendKeys(ExcelLib.ReadData(18, "Value"));
            Mortgage.SendKeys(ExcelLib.ReadData(19, "Value"));
            NextButton2.Click();
            //Value set for Tenant details page
            TenantEmail.SendKeys(ExcelLib.ReadData(20, "Value"));
            FirstName.SendKeys(ExcelLib.ReadData(21, "Value"));
            LastName.SendKeys(ExcelLib.ReadData(22, "Value"));
            StartDate.SendKeys(ExcelLib.ReadData(23, "Value"));
            EndDate.SendKeys(ExcelLib.ReadData(24, "Value"));
            RentAmount.SendKeys(ExcelLib.ReadData(25, "Value"));
            PaymentStartDate.SendKeys(ExcelLib.ReadData(26, "Value"));
            Save.Click();

        }

        //Edit existing Property
        internal void editProperty()
        {
            //To skip the highlighted option
            SkipButton?.Click();
            System.Threading.Thread.Sleep(5000);
            // Populating the data from Excel
            //ExcelLib.PopulateInCollection(Base.ExcelPath, "AddNewProperty");
            System.Threading.Thread.Sleep(5000);
            OwnersSelect.Click();
            System.Threading.Thread.Sleep(5000);
            PropertiesSelect.Click();
            //Choosing edit option
            var editOption = Global.Driver.driver.FindElements(By.ClassName("segment"))[0].FindElement(By.ClassName("top-right-corner")).FindElement(By.TagName("i"));
            editOption.Click();
            System.Threading.Thread.Sleep(5000);
            EditProperty.Click();
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "AddNewProperty");
            EditedPropertyName.Clear();
            //Editing existing property
            EditedPropertyName.SendKeys(ExcelLib.ReadData(2, "Edited Value"));
            SaveEditedValue.Click();

        }

        //Delete existing Property
        internal void deleteProperty()
        {
           //First edit an existing property
            editProperty();
            System.Threading.Thread.Sleep(10000);
            Actions actions = new Actions(Global.Driver.driver);
            actions.MoveToElement(ClickingAddNewProperty);
            actions.Perform();
            //choosing delete option
            var editOption = Global.Driver.driver.FindElements(By.ClassName("segment"))[0].FindElement(By.ClassName("top-right-corner")).FindElement(By.TagName("i"));
            editOption.Click();
            System.Threading.Thread.Sleep(5000);
            //Deleting property
            DeleteProperty.Click();
            System.Threading.Thread.Sleep(5000);
            DeleteConfirm.Click();

        }

        //Adding Repayment,Expenses and Liabilities
        internal void RepaymentExpensesLiabilities()
        {
            //To skip the highlighted option
            SkipButton?.Click();
            System.Threading.Thread.Sleep(5000);
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "AddNewProperty");
            OwnersSelect.Click();
            System.Threading.Thread.Sleep(5000);
            PropertiesSelect.Click();
            ClickingAddNewProperty.Click();
            //Value set for property page details
            PropertyName.SendKeys(ExcelLib.ReadData(2, "Value"));
            SearchAddress.SendKeys(ExcelLib.ReadData(33, "Value"));
            System.Threading.Thread.Sleep(5000);
            //Value set using google api
            var address = Global.Driver.driver.FindElements(By.ClassName("pac-item"))[0];
            address.Click();
            TargetRent.SendKeys(ExcelLib.ReadData(14, "Value"));
            LandArea.SendKeys(ExcelLib.ReadData(10, "Value"));
            BedRooms.SendKeys(ExcelLib.ReadData(11, "Value"));
            CarParks.SendKeys(ExcelLib.ReadData(12, "Value"));
            Description.SendKeys(ExcelLib.ReadData(13, "Value"));
            FloorArea.SendKeys(ExcelLib.ReadData(15, "Value"));
            BathRooms.SendKeys(ExcelLib.ReadData(16, "Value"));
            YearBuilt.SendKeys(ExcelLib.ReadData(9, "Value"));
            NextButton.Click();
            //Value set for financial details page
            System.Threading.Thread.Sleep(2000);
            PurchasePrice.SendKeys(ExcelLib.ReadData(17, "Value"));
            HomeValue.SendKeys(ExcelLib.ReadData(18, "Value"));
            Mortgage.SendKeys(ExcelLib.ReadData(19, "Value"));
            //Adding repayment option
            AddRepayment.Click();
            RepaymentAmount.SendKeys(ExcelLib.ReadData(2, "AddRepaymentfieldValue"));
            RepaymentStartDate.SendKeys(ExcelLib.ReadData(3, "AddRepaymentfieldValue"));
            //Adding expenses option
            AddExpense.Click();
            ExpenseAmount.SendKeys(ExcelLib.ReadData(2, "AddExpensefieldValue"));
            var ExpenseDescription = Global.Driver.driver.FindElement(By.ClassName("seven")).FindElement(By.ClassName("width")).FindElement(By.Id("Text1"));
            ExpenseDescription.SendKeys(ExcelLib.ReadData(3, "AddExpensefieldValue"));
            ExpenseDate.SendKeys(ExcelLib.ReadData(4, "AddExpensefieldValue"));
            NextButton2.Click();
            //Value set for financial details page
            TenantEmail.SendKeys(ExcelLib.ReadData(20, "Value"));
            FirstName.SendKeys(ExcelLib.ReadData(21, "Value"));
            LastName.SendKeys(ExcelLib.ReadData(22, "Value"));
            StartDate.SendKeys(ExcelLib.ReadData(23, "Value"));
            EndDate.SendKeys(ExcelLib.ReadData(24, "Value"));
            RentAmount.SendKeys(ExcelLib.ReadData(25, "Value"));
            PaymentStartDate.SendKeys(ExcelLib.ReadData(26, "Value"));
            //Adding liability option
            NewLiability.Click();
            Amount.SendKeys(ExcelLib.ReadData(2, "NewLiabilityFieldValue"));
            Save.Click();
        }

        //Add a renatal property
        internal void ListARental()
        {
            //To skip the highlighted option
            SkipButton?.Click();
            System.Threading.Thread.Sleep(5000);
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "AddNewProperty");
            OwnersSelect.Click();
            System.Threading.Thread.Sleep(5000);
            PropertiesSelect.Click();
            ListRental.Click();
            //Value set for adding rental property
            SelectProperty.SendKeys(ExcelLib.ReadData(10, "RentalPropertyValue"));
            Title.SendKeys(ExcelLib.ReadData(2, "RentalPropertyValue"));
            MovingCost.SendKeys(ExcelLib.ReadData(3, "RentalPropertyValue"));
            RentalDescription.SendKeys(ExcelLib.ReadData(7, "RentalPropertyValue"));
            RentalTargetRent.SendKeys(ExcelLib.ReadData(4, "RentalPropertyValue"));
            Furnishing.SendKeys(ExcelLib.ReadData(8, "RentalPropertyValue"));
            AvailableDate.SendKeys(ExcelLib.ReadData(5, "RentalPropertyValue"));
            IdealTenant.SendKeys(ExcelLib.ReadData(9, "RentalPropertyValue"));
            Occupants.SendKeys(ExcelLib.ReadData(6, "RentalPropertyValue"));
            SaveRental.Click();

            IAlert alert = Global.Driver.driver.SwitchTo().Alert();
            alert.Accept();
        }

        //Add new Advertised Jobs
        internal void AddingAdvertisedJobs()
        {
            //To skip the highlighted option
            SkipButton?.Click();
            System.Threading.Thread.Sleep(5000);
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "AdvisedJobs");
            System.Threading.Thread.Sleep(3000);
            OwnersSelect.Click();
            System.Threading.Thread.Sleep(3000);
            AdvertisedJob.Click();
            System.Threading.Thread.Sleep(3000);
            NewJobButton.Click();
            SelectPropertyForJob.Click();
            PropertyNameDropdown.Click();
            TitleForJob.SendKeys(ExcelLib.ReadData(2, "Value"));
            MaximumBudget.SendKeys(ExcelLib.ReadData(3, "Value"));
            JobDescription.SendKeys(ExcelLib.ReadData(4, "Value"));
            // Image upload
            Global.Driver.driver.FindElement(By.Id("file-upload")).Click();
            System.Threading.Thread.Sleep(10000);
            SendKeys.SendWait(@"E:\MVP Studio\Task-2\images.jpg");
            System.Threading.Thread.Sleep(10000);
            SendKeys.SendWait(@"{Enter}");
            System.Threading.Thread.Sleep(5000);
            SubmitForJob.Click();
        }

        //Edit an existing Advertised Jobs
        internal void EditAdvertisedJobs()
        {
            //To skip the highlighted option
            SkipButton?.Click();
            System.Threading.Thread.Sleep(5000);
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "AdvisedJobs");
            System.Threading.Thread.Sleep(3000);
            OwnersSelect.Click();
            System.Threading.Thread.Sleep(3000);
            AdvertisedJob.Click();
            System.Threading.Thread.Sleep(3000);

            EditForJob.Click();
            EditedMaximumBudget.Clear();
            EditedMaximumBudget.SendKeys(ExcelLib.ReadData(3, "EditedValue"));
            SaveEdit.Click();
        }

        //Delete an existing Advertised Jobs
        internal void DeleteAdvertisedJobs()
        {
            //To skip the highlighted option
            SkipButton?.Click();
            System.Threading.Thread.Sleep(5000);
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "AdvisedJobs");
            System.Threading.Thread.Sleep(3000);
            OwnersSelect.Click();
            System.Threading.Thread.Sleep(3000);
            AdvertisedJob.Click();
            System.Threading.Thread.Sleep(3000);

            DeleteForJob.Click();
            DeleteOpt2.Click();
            ConfirmDelete.Click();
        }
        #endregion
    }
}
