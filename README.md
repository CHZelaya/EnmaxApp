# EnmaxApp

# CPRG 200 Lab Assignment 2

## Overview
This lab assignment focuses on creating an application that processes electricity bills for multiple customers. The application will store customer data, calculate electricity bills based on usage, and track various statistics related to the customers.

## Objectives
- Create a class to represent customer data.
- Collect multiple instances of the customer class.
- Write unit tests for the class methods.

## Problem Description
The application will calculate electricity bills based on the following criteria:
- An administrative charge of **$12**.
- A charge of **$0.07** for each kWh used.

### Customer Data
For each customer, the following data will be stored:
- **AccountNo**: An integer value.
- **FirstName**: A string value.
- **LastName**: A string value.
- **Number of kWh used**: A decimal number.
- **BillAmount**: A decimal number.

### Statistics to Track
The application will also keep track of:
- The **number of customers processed**.
- The **total number of kWh used**.
- The **average bill amount**.

## Technical Requirements
The solution will consist of three projects:

1. **Class Library (CustomerData)**:
   - Contains the `Customer` class with:
     - Public properties for customer data.
     - Constructors for initializing customer objects.
     - A method `CalculateCharge` to compute the bill amount.
     - A `ToString()` method for displaying customer information.

2. **Windows Forms Project**:
   - Defines a user interface (GUI) for:
     - Entering new customer data.
     - Displaying customer data and statistics.
   - Ensures that all entries are provided and that kWh is a non-negative number.
   - Allows for either generated or user-entered unique AccountNo.
   - Displays all customer data in a list box with controls for statistics.

3. **Unit Test Project**:
   - Contains tests for the `CalculateCharge` method in the `Customer` class.
   - Includes at least three tests that must all pass.

## General Requirements
- The form's design should be professional, organized, and user-friendly.
- Code comments should include:
  - Top block comments in each file explaining the module or class purpose, creation date, and author’s name.
  - Method comments explaining their purpose.
  - Variable comments explaining their meaning.
  - Comments for groups of statements performing a single task.

## Conclusion
This lab assignment provides an opportunity to practice object-oriented programming concepts, including class creation, object management, and unit testing. By completing this assignment, you will gain valuable experience in developing applications that manage and process data effectively.
