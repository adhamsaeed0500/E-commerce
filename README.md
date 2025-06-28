# 🛒 E-Commerce Web App (ASP.NET MVC)

This is a full-featured E-Commerce web application built using **ASP.NET MVC 8**, designed to simulate a real-world online store. It includes product browsing, shopping cart, user authentication, and order management.

---

## 🚀 Features

- User registration and login (with roles: Admin, Customer)
- Product catalog with categories and search
- Shopping cart with quantity management
- Integrated Payment Gateway
- Added External logins 
- Order checkout and order history
- Admin dashboard to manage products and orders
- Responsive UI using Bootstrap

---

## 🛠️ Tech Stack

- ASP.NET MVC 8
- Entity Framework 8 (Code First)
- SQL Server LocalDB
- Bootstrap 5
- Identity for authentication

---

## 📦 Project Structure
- Views Layer
- DataAccess Layer
- Models Layer
- Utilty Layer

---

## 🧰 Requirements

- Visual Studio 2022 or later
- .NET Framework 4.7.2 or higher
- SQL Server Express / LocalDB

---

## 🧪 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/adhamsaeed0500/E-commerce
   ```
- Open the solution in Visual Studio.
- Build the project to restore NuGet packages.
- Update the connection string in Web.config if needed.
- Run the application (F5) — it will create the database automatically using EF Code First.
---

🔐 Admin Access
To access the admin dashboard, register a new user and manually update its role in the database to Admin.
---

🤝 Contributing
Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.
