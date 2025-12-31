# E-commerce Backend API

A RESTful E-commerce Backend API built using ASP.NET Core (.NET 8), SQL Server, and Entity Framework Core, providing CRUD operations for product management and tested using Swagger.

## Tech Stack
- ASP.NET Core Web API (.NET 8 – LTS)
- C#
- SQL Server
- Entity Framework Core
- Swagger (OpenAPI)
- Visual Studio 2022

## Features
- RESTful API design
- Product CRUD operations
- SQL Server integration using Entity Framework Core
- Swagger UI for API testing
- Proper HTTP status codes
- Clean and modular project structure

## API Endpoints

### Products
| Method | Endpoint | Description |
|-------|----------|-------------|
| GET | /api/products | Get all products |
| GET | /api/products/{id} | Get product by ID |
| POST | /api/products | Create a product |
| PUT | /api/products/{id} | Update a product |
| DELETE | /api/products/{id} | Delete a product |

## Running the Project
1. Clone the repository
2. Open the solution in Visual Studio 2022
3. Update the SQL Server connection string in appsettings.json
4. Run database migrations:
   Add-Migration InitialCreate  
   Update-Database
5. Run the project

## API Testing
After running the application, open Swagger UI at:
https://localhost:{port}/swagger

## Author
BhagyaLaxmi Malge

## License
This project is created for learning and demonstration purposes.

