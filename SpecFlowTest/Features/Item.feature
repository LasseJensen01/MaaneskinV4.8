Feature: Item Creation
  As a developer
  I want to create items with specific properties
  So that I can verify their creation in my application

  Make the StepDefinition first as the text will be intellisensed in after each keyword
  Scenario: Create Item with valid parameters
	Given parameters ID 1, Name "Tuborg", Price 10.0, and ImgURL "Img.url"
	When I create Item
	Then the item should have ID 1, Name "Tuborg", Price 10.0, and ImgURL "Img.url"