using Keys_Onboarding.Global;
using NUnit.Framework;
using Keys_Onboarding.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys_Onboarding.Test
{
    class Sprint 
    {
      [TestFixture]
      [Category("Sprint1")]
       class Tenant : Base
       {
        
            [Test]
            public void PO_AddNewProperty()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Add new Property");

                // Create an class and object to call the method
                PropertyPage obj = new PropertyPage();
                obj.AddingProperty();

            }


            [Test]
            public void PO_EditProperty()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Edit existing Property");

                // Create an class and object to call the method
                PropertyPage obj = new PropertyPage();
                obj.editProperty();

            }


            [Test]
            public void PO_DeleteProperty()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Delete existing property Property");

                // Create an class and object to call the method
                PropertyPage obj = new PropertyPage();
                obj.deleteProperty();

            }


            [Test]
            public void PO_AddRepaymentsExpensesLiabilities()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Add Repayment,Expense and Liabilities option");

                // Create an class and object to call the method
                PropertyPage obj = new PropertyPage();
                obj.RepaymentExpensesLiabilities();

            }

            [Test]
            public void PO_ListARentalProperty()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Add a Rental Property");

                // Create an class and object to call the method
                PropertyPage obj = new PropertyPage();
                obj.ListARental();

            }

        }
    }
}
