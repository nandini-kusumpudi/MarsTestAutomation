Feature: SellerProfile_Education
As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

    @sellerprofiletest
    Scenario: Add Profile Education
        Given I logged into Trade Skills portal successfully
        And I click on Education and Add New button
        When I Enter seller Education details and click on Add button
        Then Education details should be Added and saved successfully