Feature: Adding an Item from GUI to DB
  As a developer
  I want to create items with specific properties
  So that I can verify their creation in my application

  @ItemTest

    Scenario: TC8.1 Valid, price is 0
    Given parameters ID 1, Name "Pilsner Ny", Price 0.0, and ImgURL "CarlsbergPilsner.jpg", Quantity 50
    When I create Item
    Then the item should have ID 1, Name "Pilsner Ny", Price 0.0, and ImgURL "CarlsbergPilsner.jpg", Quantity 50

    Scenario: TC8.2 Invalid, price is negative
    Given parameters ID 1, Name "Pilsner Ny", Price -1.0, and ImgURL "CarlsbergPilsner.jpg", Quantity 50
    When I create Item
    Then the item should throw an ArgumentException

    Scenario: TC8.3 Valid, price is a decimal number
    Given parameters ID 1, Name "Pilsner Ny", Price 10.75, and ImgURL "CarlsbergPilsner.jpg", Quantity 50
    When I create Item
    Then the item should have ID 1, Name "Pilsner Ny", Price 10.75, and ImgURL "CarlsbergPilsner.jpg", Quantity 50
    And the property Price is of type double

    Scenario: TC8.4 Invalid, imgURL is not found in image folder
    Given parameters ID 1, Name "Pilsner Ny", Price 10.0, and ImgURL "JohnnyMadsen.jpg", Quantity 50
    When I create Item
    Then the item should throw an ArgumentException

    Scenario: TC8.5 Invalid, quantity is negative
    Given parameters ID 1, Name "Pilsner Ny", Price 10.75, and ImgURL "CarlsbergPilsner.jpg", Quantity -1
    When I create Item
    Then the item should throw an ArgumentException


