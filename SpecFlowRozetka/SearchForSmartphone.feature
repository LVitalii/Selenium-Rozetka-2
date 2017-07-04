Feature: SearchForSmartphone
	In order to simplify searching for appliance
	As a future buyer
	I want to search by appliance name in all catalog

@scenarioOutline
Scenario Outline: Search for smartphone
	Given I have opened Rozetka page
	When Type <smartphone> name to searchbox
	And Click on Search
	Then all the searches contain <smartphone> name
Examples: 
| smartphone |
| samsung galaxy j5 |
| samsung s7 |
| iphone 7   |
| iphone 6s  |
