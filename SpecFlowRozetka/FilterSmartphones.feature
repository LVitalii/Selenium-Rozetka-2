Feature: FilterSmartphones
	In order to buy the cheapest smartphone
	As a future buyer
	I want to see the cheapest smartphones first

	Background: 
	I have opened Smartphone main page

@imperativeStyle
Scenario: Sort smartphones by price
	Given I have opened Smartphone main page
	When I press sort by descending price
	Then The cheapest smartphones are shown first

@declerativeStyle
	Scenario: Sort smartphones by discount
	Given I have opened Smartphone main page
	When I click on Sort drop-down list 
	And Click on Discount item
	Then The smartphones with discounts are shown