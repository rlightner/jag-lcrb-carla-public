﻿Feature: Create_CRSApplication_society
    As a logged in business user
    I want to submit a CRS Application for a society
    To be used as test data

Scenario: Start Application
    Given I am logged in to the dashboard as a society
    And the account is deleted
    And I am logged in to the dashboard as a society
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a society
    And I review the organization structure for a society
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application for a society
    And I click on the Pay for Application button
    And I enter the payment information
    Then I confirm the payment receipt for a Cannabis Retail Store application