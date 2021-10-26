Feature: SellerProfile_Description
As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

    @sellerprofiletest
    Scenario: Add Profile Description
        Given I logged into Trade Skills portal successfully
        And I click on pen icon
        When I Add descricption and click Save button
        Then Description should be saved successfully