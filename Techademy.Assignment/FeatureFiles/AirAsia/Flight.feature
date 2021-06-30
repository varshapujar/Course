Feature: Flight Search
	

@flight
Scenario: Search for flights
	Given airasia website is launched successfully
	And verify the home page title
	And enter From as "Bangalore"
	And enter To as "Pune"
	And enter departure date as "2021-6-30"
	And enter return date as "2021-7-1"
	And select return as "One Way"
	When I click on Search button
	Then Verify flight search results page is displayed