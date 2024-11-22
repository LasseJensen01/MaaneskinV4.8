Feature: Se en oversigt over over gemte ordre linjer i databasen

	@OrderTest
	Scenario: TC10.1 Order can be created given data
	Given Parameters, ID 1, Date 2001-9-11 8:46:00.000
	When I create Order
	Then I have parameters as ID 1, Date 2001-9-11 8:46:00.000



	Scenario: TC10.2 An Orders correctly calculates its total price
	Given following orders exist:
	| ID | Date                  |
	| 1  | 2001-9-11 8:47:00.000 |
	| 2  | 2001-9-12 8:48:00.000 |
	| 3  | 2001-9-13 8:49:00.000 |
	Then I have a order with value of 62


	Scenario: TC10.3 Order maintains price regardless if item changes value
	Given Parameters, ID 1, Date 2001-9-11 8:46:00.000
	When I create Order
	Then When price changes of item value still is 62