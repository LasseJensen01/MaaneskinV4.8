Feature: Item Creation
  As a developer
  I want to create items with specific properties
  So that I can verify their creation in my application
  @ItemTest
  Scenario: Create Item with valid parameters
    Given parameters ID 1, Name "Tuborg", Price 10.0, and ImgURL "Img.url", Quantity 100
    When I create Item
    Then the item should have ID 1, Name "Tuborg", Price 10.0, and ImgURL "Img.url", Quantity 100