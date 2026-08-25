# 🎬 Tickflix

**Tickflix** is a movie management and ticket shopping web application built with **ASP.NET Core MVC**.
The project provides a modern movie browsing experience with movie details, actors, categories and a shopping cart system.

The main goal of the project is to build a full-stack movie platform while applying **clean backend architecture, Entity Framework Core, MVC patterns and relational database design**.

---

## 🚀 Features

* 🎥 Browse and explore movies
* 🔎 View detailed movie information
* 🎭 Movie & actor relationships
* 🗂️ Movie categories
* 🛒 Shopping cart system
* ➕ Increase movie quantity in cart
* ➖ Decrease movie quantity in cart
* ❌ Remove movies from cart
* 💾 Database-driven movie management
* ✏️ Create, update and delete movies
* 👥 Actor management
* 🔗 Many-to-many relationships between movies and actors
* 📱 Responsive user interface
* ⚡ AJAX-based operations for a smoother experience

---

## 🛠️ Technologies

### Backend

* **C#**
* **ASP.NET Core MVC**
* **Entity Framework Core**
* **LINQ**
* **SQL Server**

### Frontend

* **HTML5**
* **CSS3**
* **JavaScript**
* **jQuery**
* **Bootstrap**
* **DataTables**

### Architecture & Tools

* MVC Architecture
* Dependency Injection
* Repository / Service-based structure
* Entity Framework Core Migrations
* Visual Studio

---

## 🏗️ Project Structure

The project follows an MVC-based architecture with a clear separation between application responsibilities.

```text
Tickflix
│
├── Controllers
│   ├── MovieController
│   ├── ActorController
│   └── ...
│
├── Models
│   ├── Movie
│   ├── Actor
│   ├── Category
│   └── ...
│
├── Services
│   ├── MovieService
│   ├── ActorService
│   └── ...
│
├── Views
│   ├── Movie
│   ├── Actor
│   ├── Cart
│   └── ...
│
├── Data
│   └── ApplicationDbContext
│
└── wwwroot
    ├── css
    ├── js
    └── images
```

---

## 🎞️ Movie Management

The administration side of Tickflix allows movies to be managed through CRUD operations.

Administrators can:

* Add new movies
* Update existing movies
* Delete movies
* Assign actors to movies
* Assign categories
* Manage movie information

The project uses **Entity Framework Core** to handle database operations and relationships.

---

## 👥 Movie & Actor Relationship

Tickflix implements a **many-to-many relationship** between movies and actors.

A movie can have multiple actors, while an actor can appear in multiple movies.

```text
Movie
  │
  │
  ▼
MovieActor
  ▲
  │
  │
Actor
```

This relationship is managed through a dedicated join entity/table.

---

## 🛒 Shopping Cart

Tickflix includes a functional shopping cart system.

Users can:

```text
Add Movie
    ↓
Shopping Cart
    ↓
+ Increase Quantity
- Decrease Quantity
X Remove Movie
    ↓
Updated Cart
```

Cart operations are handled dynamically to provide a smoother user experience without unnecessary page reloads.

---

## 📸 Screenshots

> Screenshots will be added soon.

<!--
Add your project screenshots here:

![Home Page](screenshots/home.png)

![Movie Details](screenshots/movie-details.png)

![Shopping Cart](screenshots/cart.png)

![Admin Panel](screenshots/admin.png)
-->

---

## ⚙️ Installation

### 1. Clone the repository

```bash
git clone https://github.com/YOUR_USERNAME/tickflix.git
```

### 2. Open the project

Open the solution in **Visual Studio**.

### 3. Configure the database

Update the connection string in:

```text
appsettings.json
```

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "YOUR_CONNECTION_STRING"
}
```

### 4. Apply migrations

Run:

```bash
dotnet ef database update
```

Or use the Package Manager Console:

```powershell
Update-Database
```

### 5. Run the application

```bash
dotnet run
```

Then open the application in your browser.

---

## 🧠 What I Learned

While developing Tickflix, I focused on improving my understanding of:

* ASP.NET Core MVC
* Entity Framework Core
* Relational database design
* CRUD operations
* Many-to-many relationships
* Service-layer architecture
* Dependency Injection
* AJAX & jQuery
* Dynamic shopping cart operations
* MVC View development
* Database migrations
* Frontend & backend integration

---

## 🔮 Future Improvements

Planned improvements include:

* 🔐 Authentication & authorization
* 👤 User accounts
* 💳 Payment integration
* 🎟️ Real ticket reservation system
* ⭐ Movie rating & review system
* ❤️ Favorite movies
* 🔍 Advanced movie filtering
* 📧 Email notifications
* 🌐 RESTful API
* ⚛️ React-based frontend

---

## 👨‍💻 Developer

**Ömer KUTLAY**

Backend-focused developer working primarily with **C# and ASP.NET Core**.

This project was developed as a practical application of backend development, database management and MVC architecture.

---

## 📄 License

This project is developed for educational and portfolio purposes.
