Feature: WexIncAutomatedTest
	Test for QA Engineer position
	With a WEX Test Automation case

@mytag2
Scenario: WEX Search validation
	Given I navigate on "www.wexinc.com".
	And I select the option "Health" in the dropdown next to the search text input.
	Then I search by "corporative plans".
	And I select any item of search result.
	When I get the item, I check if this item is contained at "AllWEX", searched by "plans".