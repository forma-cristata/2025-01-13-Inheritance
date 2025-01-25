# InheritanceLab

## Overview

InheritanceLab is a .NET 8 project designed to demonstrate the principles of object-oriented programming, specifically focusing on inheritance and polymorphism. The project includes a categorizer that creates and manages different types of inventory items based on their product type.

## Project Structure

- InheritanceLab.csproj: Defines the .NET target framework and other project settings.
- Program.cs: Reads input data, creates inventory items, and performs various checks on the created items.
- Categorizer.cs: Contains the Categorizer class, which is responsible for creating inventory items based on the provided product type and storing them in a list.

## Usage

1. Setup: .NET 8 SDK installed.
2. Build: Build the solution.
3. Run: Execute the program. It will read from inputs.txt, create inventory items, and perform various checks.

### Input File

The inputs.txt file should contain the inventory items to be created. Each line in the file should represent an item with the following format:

```
ProductType, Brand, Title, QuantityOnHand, Price, MiscAttribute1, MiscAttribute2, ...
```

## Product Types

The project supports the following product types:

- Laptop
- Smartphone
- RoboticVacuum
- Camera
- AirFryer

## Classes

### Program

The Program class is the main entry point of the application. It reads input data, creates inventory items using the Categorizer class, and performs various checks on the created items.

### Categorizer

The Categorizer class is responsible for creating inventory items based on the provided product type and storing them in a list. It uses a switch statement to call the correct constructor for each product type.

## Extending the Project

To add a new product type:

1. Define the new product type in the ProductTypes enum.
2. Create a new class for the product type that inherits from InventoryItem.
3. Update the Categorizer class to handle the new product type in the Creator method.

## Author

•	Name: Kaci Craycraft
