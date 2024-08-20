## Employee Management System

### Overview

This Employee Management System is a comprehensive application developed using C#, Windows Forms, and SQL Server. It is designed to handle various aspects of employee management, including:

- **Employee Details Management**: Add, update, view, and manage employee details.
- **Salary Management**: Record and manage salary details for employees.
- **Monitoring System**: Track and monitor employee activities and performance.
- **Attendance Management**: Manage and record employee attendance.
- **Reporting**: Generate detailed reports using RDLC (Report Definition Language Client-side).
- **User Authentication**: Provide secure login and ensure that users can only access their own data.

### Key Features

1. **Employee Details**:
   - Manage employee records including personal details, position, department, and date of joining.

2. **Salary Management**:
   - Record salary payments, manage salary details, and track payment dates.

3. **Monitoring System**:
   - Track various employee metrics and activities for performance evaluation.

4. **Attendance Management**:
   - Record daily attendance, manage attendance statuses, and generate attendance reports.

5. **RDLC Reports**:
   - Generate and view detailed reports on employee data, attendance, and salaries using RDLC reports.

6. **User Authentication**:
   - Secure login mechanism that ensures users can only access their personal data.

### Technologies Used

- **C#**: Primary programming language used for application development.
- **Windows Forms**: GUI framework used for designing the user interface.
- **SQL Server**: Database management system for storing employee data, salary records, attendance logs, and user credentials.
- **RDLC**: Reporting tool used to generate and view reports within the application.

### How to Use

1. **Set Up Database**:
   - Create a SQL Server database and configure tables for employees, salaries, attendance, and users.

2. **Configure Connection**:
   - Set up the connection string in the application to connect to the SQL Server database.

3. **Run Application**:
   - Launch the Windows Forms application to access different modules like Employee Details, Salary Management, Attendance Management, and Reports.

4. **Login**:
   - Use the login form to authenticate users. Each user will have access only to their specific data.

5. **Generate Reports**:
   - Use the RDLC report viewer to generate and view various reports based on employee data, attendance, and salaries.

### Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/employee-management-system.git
   ```

2. **Open Solution**:
   - Open the solution file in Visual Studio.

3. **Configure Database**:
   - Update the connection string in the application settings to point to your SQL Server instance.

4. **Build and Run**:
   - Build the project and run the application.

