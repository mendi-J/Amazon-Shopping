Feature: Amazon Shopping

As an unregistered user
I want to search for a specific item and add it to the cart

@AmazonTestSearch
Scenario: Add item to cart
	Given I open browser
    Given I navigate to Amazon website
    Given  I bypass captcha
    When I search for "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)"
    And I add the corresponding item to the cart
    Then I navigate to the cart
    And I validate the correct item and amount is displayed