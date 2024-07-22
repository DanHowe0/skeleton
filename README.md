# Skeleton Project

## Overview

The Skeleton Project is a comprehensive ASP.NET web application with an administrative system for managing various entities such as customers, staff, and products. The project includes features for data entry, viewing, listing, and deleting records. It also contains test projects for each entity.

## Features

- **Administrative System**: Interfaces for managing different entities like customers, staff, and products.
- **Data Entry Forms**: Pages for adding and editing records.
- **Data Viewing**: Pages for viewing detailed information of records.
- **Listing Pages**: Pages for listing all records with options to edit or delete.
- **Confirmation Pages**: Pages to confirm deletion of records.
- **Testing**: Comprehensive test projects for validating the functionality of the system.

## Project Structure

The project is divided into several main components:

### AdminSystem

Contains the administrative interface for managing different entities.

- **Common Pages**:
  - `4ConfirmDelete.aspx` and related files: For confirming deletion of records.
  - `4DataEntry.aspx` and related files: For data entry of records.
  - `4List.aspx` and related files: For listing records.
  - `4Viewer.aspx` and related files: For viewing detailed records.
  - Similar sets of files are available for other entities (Customer, Staff, etc.).

- **Entity-Specific Pages**:
  - **Customer**:
    - `CustomerConfirmDelete.aspx` and related files
    - `CustomerDataEntry.aspx` and related files
    - `CustomerList.aspx` and related files
    - `CustomerViewer.aspx` and related files
  - **Staff**:
    - `StaffConfirmDelete.aspx` and related files
    - `StaffDataEntry.aspx` and related files
    - `StaffList.aspx` and related files
    - `StaffViewer.aspx` and related files
  - **Products**:
    - Similar structure for products

### ClassLibrary

Contains the business logic and data models.

- **Business Logic Classes**:
  - `clsCustomer.cs`: Data model for customers.
  - `clsCustomerCollection.cs`: Collection class for customers.
  - `clsDataConnection.cs`: Data connection class.
  - `clsSecurity.cs`: Security class for handling authentication.
  - Similar classes for other entities (Laptops, Staff, etc.).

### Testing Projects

Projects for testing different components of the system.

- **Testing1**: Tests for laptops.
  - `tstLaptopCollection.cs`
  - `tstLaptops.cs`
  - `tstLaptopsUser.cs`
- **Testing2**: Tests for staff.
  - `tstStaff.cs`
  - `tstStaffCollection.cs`
  - `tstStaffUser.cs`
- **Testing3**: Tests for customers.
  - `tstCustomer.cs`
  - `tstCustomerCollection.cs`
  - `tstCustomerUser.cs`
- **Testing4**: Additional tests.
- **Testing5**: Additional tests.
- **Testing6**: Additional tests.

## Getting Started

### Prerequisites

- Visual Studio 2019 or higher
- .NET Framework 4.7.2 or higher

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/your-username/skeleton-project.git
    cd skeleton-project
    ```

2. Open the solution file `Skeleton.sln` in Visual Studio.

3. Restore NuGet packages:

    ```bash
    nuget restore
    ```

4. Build the solution:

    ```bash
    msbuild
    ```

5. Run the application from Visual Studio.

## Usage

### Running the Application

To run the application, open the solution in Visual Studio and start debugging. This will launch the web application, and you can navigate through the administrative system.

### Navigating the Admin System

1. **Data Entry**: Use the data entry forms to add new records.
2. **View Records**: Use the viewer pages to see detailed information of records.
3. **List Records**: Use the list pages to see all records with options to edit or delete.
4. **Confirm Deletion**: Use the confirmation pages to confirm the deletion of records.

### Testing

Each entity has a corresponding test project. To run the tests:

1. Open the Test Explorer in Visual Studio.
2. Run all tests to validate the functionality of the system.

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bugfix.
3. Make your changes.
4. Submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For questions or suggestions, please contact [your-email@example.com](mailto:your-email@example.com).
