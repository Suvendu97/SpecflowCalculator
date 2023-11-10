


Feature: Peform Operation On Calculator


@closeAllInstances
    Scenario Outline: Check for result for operation
	Given  Calculator is Opened 
	And   : Select the Mode '<SpecificMode>'
	Then  : I Input 12
	And   : I Input 999
	And   : I perform add action
	And   : I perform Store in Memory action
	And   : I Input 19
	And   : I perform '<Operation>" Operation
	And   : The Result is '<Result>'
	

	Examples: 
				| SpecificMode | Operation | Result |
				| Standard     | Plus      | 1030   |
				| Scientific   | Square    | 361    |
	