Feature: SellerProfile_Languages
As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

	@sellerprofiletest
	Scenario: Add Profile Languages
		Given I logged into Trade Skills portal successfully
		And I click on Add New button
		When I Enter Language and language level and click on Add button
		Then Laguages should be Added and saved successfully