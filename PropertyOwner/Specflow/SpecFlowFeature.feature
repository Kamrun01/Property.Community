Feature: PropertyOwner
	

@mytag
Scenario: Search for a property under Properties Page
	Given user have logged into the application
	Then  User search results for property are successfull

	Scenario: Add New Property under Properties Page
	Given user have logged into the application
	When All input fields have been populated
	Then New Property should be displayed

	
	Scenario: Edit existing Property under Properties Page
	Given user have logged into the application
	When User edit  an existing property
	Then Edited Property should be displayed 

	Scenario: Delete existing Property under Properties page
    Given user have logged into the application
	When User deletes an existing property
	Then Deleted property should not appear in Property list

	Scenario: Adding Repayments and Expenses and Liabilities
	Given user have logged into the application
	When All input fields for repayment and expenses and liabilities have been populated
	Then New property should be added

	Scenario: Add list Rental Property
	Given user have logged into the application
	When Input fields for rental property have been populated
	Then New renatl property should be added


	Scenario: Add Advertised Jobs
	Given user have logged into the application
	When Input fields for advertised jobs have been populated
	Then New advertised jobs should be added

	Scenario: Edit Advertised Jobs
	Given user have logged into the application
	When User edit an existing Advirtisement job
	Then Edited Job should appear in the list

	Scenario: Delete Advertised Jobs
	Given user have logged into the application
	When User deletes an existing Advirtisement job
	Then Deleted Job should not appear in the list