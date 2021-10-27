Feature: SellerProfile_Description
As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

    @sellerprofiletest
    Scenario: Add Profile Description with data 
        Given I logged into Trade Skills portal successfully
        And I click on pen icon
        When I Add descricption and click Save button
        Then Description should be saved successfully
        
    @sellerprofiletest
    Scenario: Add Profile Description without data
        Given I logged into Trade Skills portal successfully
        And I click on pen icon
        When I click Save button without data
        Then A popup should be shown with this message (Please a Description is required)
        
    @sellerprofiletest
    Scenario: Edit Profile Description
        Given I logged into Trade Skills portal successfully
        And I click on pen icon
        When I Edit descricption and click Save button
        Then Description should be Edited successfully