Feature: SellerProfile_Skills
As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

	@sellerprofiletest
	Scenario: Add Profile Skills
		Given I logged into Trade Skills portal successfully
		And I click on Skills and Add New button
		When I Enter Seller Skills and Skills level and click on Add button
		Then Skills should be Added and saved successfully