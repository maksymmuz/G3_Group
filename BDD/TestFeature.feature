Feature: SpecFlowFeature
	In order to check summ functionality
	As a user
	I want to get the sum of two numbers

@mytag
	Scenario: Add two numbers
	Given I have entered '50' in to the calculator
	And I have entered '70' in to the calculator
	When I press add
	Then the result should be '120' on the screen