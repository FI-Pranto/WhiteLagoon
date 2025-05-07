
# 🏝️ WhiteLagoon - Tour Management System

**WhiteLagoon** is a simple yet feature-rich **Tour Management System** built using **ASP.NET Core MVC** following the principles of **Clean Architecture**. This project is purely for educational purposes, helping developers understand how to structure real-world web applications using modular, maintainable design patterns.

---

## ✨ Features

✅ User Registration and Login
✅ Browse Available Tours
✅ Book and Manage Tours
✅ Admin Dashboard for Tour Management
✅ Role-Based Authorization (User & Admin)
✅ Responsive UI using Bootstrap
✅ Clean Architecture Implementation
✅ Secure Password Handling with ASP.NET Identity
✅ CRUD Operations for Tours, Bookings, and Categories
✅ Booking Confirmation & History
✅ Entity Framework Core for Database Access

---

## 📁 Project Structure (Clean Architecture)

```
WhiteLagoon
│
├── WhiteLagoon.Domain        # Entities and Interfaces
├── WhiteLagoon.Application   # Services, DTOs, Interfaces
├── WhiteLagoon.Infrastructure # EF Core DbContext, Repository Implementations
├── WhiteLagoon.Web           # MVC Controllers, Views, and Static Files
└── WhiteLagoon.Test          # Unit and Integration Tests
```

---

## 🛠️ Tech Stack

* **Frontend:** HTML, CSS, Bootstrap, JavaScript
* **Backend:** ASP.NET Core MVC
* **Authentication:** ASP.NET Core Identity
* **Database:** SQL Server (EF Core)
* **Architecture:** Clean Architecture
* **Testing:** xUnit, Moq

---

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/FI-Pranto/WhiteLagoon.git
cd WhiteLagoon
```

### 2. Set Up the Database

* Configure the connection string in `appsettings.json` under `WhiteLagoon.Web`.
* Run the following commands to apply migrations:

```bash
cd WhiteLagoon.Web
dotnet ef database update
```

### 3. Run the Application

```bash
dotnet run --project WhiteLagoon.Web
```

Visit `https://localhost:5001` in your browser.

---

## 📸 Screenshots (Optional)

*Add demo screenshots or a short video link here for better understanding.*

---

## 📚 Learning Objectives

* Understand the separation of concerns via Clean Architecture
* Learn how to use ASP.NET Core MVC for web development
* Practice user management and secure authentication
* Implement role-based authorization and booking systems
* Gain confidence in using EF Core and writing clean service/repository logic

---

## 🤝 Contributing

This project is open for learning and collaboration. Feel free to fork it or raise issues for improvements or bugs.

---

## 📜 License

This project is licensed for educational use only. You are free to learn and build upon it.


