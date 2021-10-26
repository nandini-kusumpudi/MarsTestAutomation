Feature: SellerProfile
As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

    @sellerprofiletest
    Scenario: Edit Profile Name
        Given I logged into Trade Skills portal successfully
        And I click on Name Arrow button
        When I enter name and click on Save button
        Then Name should be edited and saved successfully

    @sellerprofiletest
    Scenario: Add Profile Availability
        Given I logged into Trade Skills portal successfully
        And I click on Availability pen icon
        When I select the dorpdown and click on
        Then Availability should be saved successfully

    @sellerprofiletest
    Scenario: Add Profile Hours
        Given I logged into Trade Skills portal successfully
        And I click on Hours pen icon
        When I select the dorpdown and click on
        Then Hours should be saved successfully

    @sellerprofiletest
    Scenario: Add Profile Earn Target
        Given I logged into Trade Skills portal successfully
        And I click on Earn Target pen icon
        When I select the dorpdown and click on
        Then Earn Target should be saved successfully