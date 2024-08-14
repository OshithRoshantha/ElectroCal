# ElectroCal

ElectroCal is a Windows application designed for calculating electricity bills. It features user authentication, billing calculations, and a date picker for usage entries.

## Prerequisites

- **Visual Studio**: Required to open and run the project.
- **SQL Server**: Ensure SQL Server is installed and configured (e.g., `OSHITH-PC\SQLEXPRESS`).
- **.NET Framework**: Ensure the required .NET Framework version is installed.

## Installation

1. **Clone the Repository**:
 ```bash
     git clone https://github.com/OshithRoshantha/ElectroCal.git
```


2. **Open the Project:**
- Launch Visual Studio.
- Navigate to `File > Open > Project/Solution`.
- Locate and open the `.sln` file from the cloned repository.


3. **Configure the Database:**
- Open SQL Server Management Studio.
- Create a database named `ElectroCal`.
- Execute the SQL script provided in `DatabaseSetup.sql` to set up the required tables and initial data.

  
4. **Run the Application:**
- In Visual Studio, select the startup project.
- Press `F5` or click the `Start` button to build and run the application.
