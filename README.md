
TastyTrails

TastyTrails is a dynamic food ordering and delivery platform designed to connect customers with local restaurants. This project showcases a robust, scalable, and efficient architecture, utilizing multiple technologies for both frontend and backend development.

Table of Contents
- [Project Overview](#project-overview)
- [Key Features](#key-features)
- [Technologies Used](#technologies-used)
- [Architecture](#architecture)
- [Installation and Setup](#installation-and-setup)
- [API Documentation](#api-documentation)
- [Frontend Overview](#frontend-overview)
- [Backend Overview](#backend-overview)
- [Database Schema](#database-schema)
- [Contributing](#contributing)
- [License](#license)

Project Overview

TastyTrails is designed to provide a seamless and intuitive experience for users to browse restaurants, view menus, place orders, and track their order status. It serves both restaurant owners and customers with features tailored to their needs. The project is powered by a dual backend architecture using .NET and Spring Boot, while the frontend is built with React.

Key Features

- User Authentication and Authorization: Secure login and signup for customers and admins, including role-based access control.
- Restaurant Management: Admins can add, update, delete, and manage restaurant details and menus.
- Menu Browsing: Customers can browse restaurant menus, search by city, and view detailed information about each restaurant.
- Order Management: Customers can place orders, view order history, and track order status.
- Responsive Design: The frontend is optimized for various devices, providing a consistent experience across desktop, tablet, and mobile devices.
- Dual Backend Support: The application supports two backends: one built with .NET and the other with Spring Boot, allowing for flexibility in deployment and scalability.

Technologies Used

Frontend:
- React: JavaScript library for building user interfaces, providing a seamless experience for users.
- React Bootstrap: For responsive design and pre-styled components.
- React Router: For managing navigation and routing in the application.
- Axios: For making HTTP requests to the backend.
- CSS3: For custom styling and layout.

Backend:
- .NET (ASP.NET Core): One of the backend implementations, providing RESTful API services, authentication, and business logic.
- Spring Boot: The alternative backend implementation, also providing RESTful API services, authentication, and business logic.
- Entity Framework Core: ORM for .NET, managing database interactions.
- Hibernate: ORM for Spring Boot, managing database interactions.
- MySQL: The relational database management system used to store application data.

Other Tools:
- Postman: For API testing and development.
- Git: Version control system for tracking changes and collaboration.
- Visual Studio Code & IntelliJ IDEA: IDEs used for frontend and backend development respectively.
- Docker: For containerizing the application and managing dependencies.

Architecture

TastyTrails is built on a microservices architecture, with the frontend and backend services decoupled to allow independent development and scaling. The frontend communicates with the backend via RESTful APIs.

Frontend Architecture:
- Components: Reusable UI elements such as navigation bars, cards, and forms.
- State Management: Managed locally within components and shared via props.
- Routing: Managed by React Router to ensure smooth navigation between pages.

Backend Architecture:
- Controllers: Handle incoming HTTP requests and route them to appropriate services.
- Services: Contain business logic and interact with the repositories.
- Repositories: Manage data persistence and retrieval from the database using ORM tools.
- Security: Implemented using JWT (JSON Web Tokens) for secure API access.

Installation and Setup

Frontend Setup:
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/tastytrails-frontend.git
   ```
2. Navigate to the project directory and install dependencies:
   ```bash
   cd tastytrails-frontend
   npm install
   ```
3. Start the development server:
   ```bash
   npm start
   ```

Backend Setup (.NET):
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/tastytrails-backend-dotnet.git
   ```
2. Navigate to the project directory and restore dependencies:
   ```bash
   cd tastytrails-backend-dotnet
   dotnet restore
   ```
3. Update the database connection string in `appsettings.json`.
4. Run database migrations:
   ```bash
   dotnet ef database update
   ```
5. Start the application:
   ```bash
   dotnet run
   ```

Backend Setup (Spring Boot):
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/tastytrails-backend-springboot.git
   ```
2. Navigate to the project directory:
   ```bash
   cd tastytrails-backend-springboot
   ```
3. Update the database connection details in `application.properties`.
4. Build and run the application:
   ```bash
   mvn spring-boot:run
   ```

Database Setup:
1. Install MySQL and create a new database:
   ```sql
   CREATE DATABASE tastytrails_db;
   ```
2. Update connection strings in the backend projects accordingly.

API Documentation

The backend exposes a set of RESTful APIs for various operations. Below is a brief overview of key endpoints:

- User Authentication:
  - `POST /api/auth/signup`: Register a new user.
  - `POST /api/auth/login`: Authenticate a user and return a JWT.
- Restaurant Management:
  - `GET /api/restaurants`: Get a list of all restaurants.
  - `POST /api/restaurants`: Add a new restaurant (admin only).
  - `PUT /api/restaurants/{id}`: Update restaurant details (admin only).
  - `DELETE /api/restaurants/{id}`: Delete a restaurant (admin only).
- Order Management:
  - `POST /api/orders`: Place a new order.
  - `GET /api/orders/history`: Get a user's order history.
  - `GET /api/orders/{id}/status`: Check the status of an order.

Frontend Overview

The frontend is designed to be user-friendly, providing a smooth and responsive experience. Key pages include:

- Home Page:Overview of the platform, featuring top restaurants and promotions.
- Restaurant Page: Detailed information about each restaurant, including menu items and reviews.
- Order Page: Interface for placing and tracking orders.
- Admin Dashboard: Manage restaurants, view orders, and handle user inquiries.

Backend Overview

The backend services handle all business logic, database interactions, and API management. The services are designed to be stateless and scalable, with a focus on security and performance.

Core Modules:
- Authentication Module: Manages user login, registration, and JWT token generation.
- Restaurant Module: Handles CRUD operations for restaurant data.
- Order Module: Manages order placement, tracking, and history.

Database Schema

The database consists of several tables to manage the data:

- Customers: Stores user details, roles, and authentication data.
- **Restaurants: Contains restaurant details including name, location, and menu.
- Orders: Tracks customer orders, including status and order history.
- Menus: Stores menu items associated with each restaurant.

Contributing

We welcome contributions from the community! If you'd like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes and commit them (`git commit -m 'Add new feature'`).
4. Push to the branch (`git push origin feature-branch`).
5. Open a pull request.

---

This README provides a detailed overview of the TastyTrails project, including setup instructions, technology stack, architecture details, and more. You can modify it as needed based on the specific details of your project.

Screenshot


![Home Page](ss1.png)
![Dashboard](ss2.jpg)