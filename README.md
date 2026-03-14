# Department–Employee Management System (MVC)

A **Department–Employee Management System** built using the **ASP.NET MVC architecture**.  
This project was developed as a **learning project** to practice building database-driven web applications using **C#, .NET, and SQL Server**.

The system demonstrates how departments and employees can be managed using structured data models, controllers, and views while performing CRUD operations through database connectivity.

---

## Features

- Create, update, and delete departments
- Create, update, and delete employees
- Assign employees to departments
- Retrieve and display employee information
- Structured implementation using **MVC architecture**
- Demonstrates **database connectivity using ADO.NET**

---

# Technologies Used

## Programming Languages

- **C#** – Used to implement object-oriented programming concepts and build application logic using the .NET platform.
- **HTML** – Used to structure and present content on web pages.
- **JavaScript** – Used to add interactivity and manipulate the Document Object Model (DOM).
- **SQL** – Used to create, manage, and retrieve data from relational databases.

---

## Database Management Tools

- **Azure Data Studio (macOS)**  
  Used to manage SQL Server databases running inside Docker containers. Provided an interface to write, execute SQL queries, and explore database structures.

- **Docker (macOS)**  
  Used to containerize **Microsoft SQL Server** for compatibility with macOS, allowing database operations to run in an isolated environment.

- **SQL Server Management Studio (SSMS) (Windows)**  
  Demonstrated by peers for advanced database management tasks such as backup/restore operations, database diagrams, and SQL Server Agent.

---

## Development Environments

- **Visual Studio Code (VS Code) (macOS)**  
  Used as the primary development environment with extensions and terminal-based tools.

- **Visual Studio IDE (Windows)**  
  Used in enterprise environments for full .NET development support including debugging, project management, and GUI-based design.

---

# Project Structure

```
DepartmentEmployeeManagement
│
├── Models
│   ├── Employee.cs
│   └── Department.cs
│
├── Views
│   ├── Employee
│   └── Department
│
├── Controllers
│   ├── EmployeeController.cs
│   └── DepartmentController.cs
│
└── Database
    └── SQL scripts for Department and Employee tables
```

---

# MVC Architecture

### Model
Represents the application's data structure and handles interaction with the database.

### View
Handles the presentation layer and displays information to the user through web pages.

### Controller
Acts as an intermediary between models and views by processing requests, performing logic, and returning responses.

---

# Database Design

## Department Table

| Column | Description |
|------|-------------|
| DepartmentId | Unique identifier for each department |
| DepartmentName | Name of the department |

## Employee Table

| Column | Description |
|------|-------------|
| EmployeeId | Unique identifier for each employee |
| EmployeeName | Name of the employee |
| DepartmentId | Foreign key referencing Department |

---

# Learning Outcomes

## Technical Skills

- Gained hands-on experience in **C# programming and Object-Oriented Programming (OOP)**.
- Learned how **ASP.NET Core MVC applications are structured and executed**.
- Implemented **database connectivity using ADO.NET**.
- Practiced writing SQL queries for **table creation, joins, and data manipulation**.
- Learned how to run **SQL Server in Docker containers on macOS**.
- Used **Azure Data Studio** for managing SQL Server databases.
- Became familiar with **VS Code as a lightweight development environment**.

---

## Industry Exposure

- Understood common workflows followed in software companies.
- Observed how projects are structured in professional environments.
- Gained awareness of enterprise tools such as **Visual Studio, SSMS, and Git**.

---

## Problem Solving and Adaptability

- Adapted Windows-centric tools to a macOS environment using **Docker and Azure Data Studio**.
- Developed the ability to troubleshoot **installation, configuration, and compatibility issues**.

---

# Disclaimer

This project was developed **for learning purposes** to understand MVC architecture, database integration, and real-world development workflows.
