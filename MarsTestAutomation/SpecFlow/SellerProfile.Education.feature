Feature: SellerProfile_Education
As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

    @sellerprofiletest
    Scenario: Add Profile Education with data
        Given I logged into Trade Skills portal successfully
        And I click on Education and Add New button
        When I Enter seller Education details and click on Add button
        Then Education details should be Added and saved successfully
        
    @sellerprofiletest
    Scenario: Add Profile Education without data
        Given I logged into Trade Skills portal successfully
        And I click on Education and Add New button
        When I click on Add button
        Then a popup should be shown with this message (Please entry all the fields)
        
    @sellerprofiletest
    Scenario: Add Profile Education with college/University Name field
        Given I logged into Trade Skills portal successfully
        And I click on Education and Add New button
        When I enter college/University Name field click on Add button
        Then a popup should be shown with this message (Please entry all the fields)
        
    @sellerprofiletest
    Scenario: Add Profile Education with country of college/University field
        Given I logged into Trade Skills portal successfully
        And I click on Education and Add New button
        When I enter country of college/University field click on Add button
        Then a popup should be shown with this message (Please entry all the fields)
        
    @sellerprofiletest
    Scenario: Add Profile Education with title field
        Given I logged into Trade Skills portal successfully
        And I click on Education and Add New button
        When I Selected title field click on Add button
        Then a popup should be shown with this message (Please entry all the fields)
        
    @sellerprofiletest
    Scenario: Add Profile Education with degree field
        Given I logged into Trade Skills portal successfully
        And I click on Education and Add New button
        When I enter degree field click on Add button
        Then a popup should be shown with this message (Please entry all the fields)
        
    @sellerprofiletest
    Scenario: Add Profile Education with year of Graduation field
        Given I logged into Trade Skills portal successfully
        And I click on Education and Add New button
        When I enter year of Graduation field click on Add button
        Then a popup should be shown with this message (Please entry all the fields)
        
    @sellerprofiletest
    Scenario: Add Profile Education with college/University Name field and country of college/University field
        Given I logged into Trade Skills portal successfully
        And I click on Education and Add New button
        When I enter college/University Name field and country of college/University field click on Add button
        Then a popup should be shown with this message (Please entry all the fields)
        
    