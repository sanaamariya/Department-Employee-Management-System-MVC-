# Department–Employee Management System (MVC)

A **Department–Employee Management System** built using the **MVC (Model–View–Controller) architecture**.  
This project was developed as a **learning exercise** to understand how MVC applications are structured and how different components interact in a typical enterprise-style application.

The system allows users to manage departments and employees through a simple interface, demonstrating CRUD operations and relational data handling.

---

## Features

- Add, update, and delete departments
- Add, update, and delete employees
- Assign employees to departments
- View employees by department
- Structured application using MVC architecture
- Simple and clean interface for managing data

---

## Technologies Used

- **C#**
- **ASP.NET MVC**
- **HTML**
- **CSS**
- **JavaScript**
- **SQL / Database Integration**

---

## Project Structure

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
    └── Tables for Employee and Department
```

---

## MVC Architecture

### Model
Represents the data structure and database interaction.  
Includes classes for **Employee** and **Department**.

### View
Handles the **user interface** and displays information to the user.

### Controller
Processes user requests, interacts with the model, and returns the appropriate view.

---

## Database Design

### Department Table

| Column | Description |
|------|-------------|
| DepartmentId | Unique identifier for each department |
| DepartmentName | Name of the department |

### Employee Table

| Column | Description |
|------|-------------|
| EmployeeId | Unique identifier for each employee |
| EmployeeName | Name of the employee |
| DepartmentId | Foreign key referencing Department |

---

## Learning Objectives

This project was built to learn and practice:

- MVC architecture
- Separation of concerns
- CRUD operations
- Database connectivity
- Controller–View interaction
- Structuring web applications

---

## Language Distribution

- HTML — 40.0%
- C# — 37.0%
- CSS — 22.2%
- JavaScript — 0.8%

---

## Future Improvements

- User authentication and authorization
- Search and filtering functionality
- Pagination for large datasets
- Improved UI/UX
- API integration

---

## Disclaimer

This project was developed **for learning purposes** to understand MVC application development and database-driven web systems.
