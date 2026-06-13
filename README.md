# SecureCatalog

SecureCatalog is a full-stack product catalog application built with ASP.NET Core and Blazor.

## Live Demo

### Application

https://securecatalog-ui-ronrex-d7dmbea3dsfvgxhd.canadacentral-01.azurewebsites.net

### API

https://securecatalog-api-ronrex-add0hccxgeh8d2fs.centralus-01.azurewebsites.net/

### Test Account

You can register a new account or use a test account if one has been provided.

## Deployment

The application is deployed to Microsoft Azure App Service.

### Components

* SecureCatalog UI (Blazor)
* ECommerce.Api (ASP.NET Core Web API)

### Database

* SQLite
* ASP.NET Core Identity
* Entity Framework Core Migrations

### Hosting

* Azure App Service (UI)
* Azure App Service (API)


## Features

- ASP.NET Core Identity authentication
- User registration and login
- ASP.NET Core Minimal API
- Protected pages with authorization
- Entity Framework Core for Identity data
- SQLite database
- Product CRUD operations
- Product validation
- Soft delete support
- CQRS architecture using MediatR
- Dapper data access for product operations
- Blazor frontend
- Serilog structured logging
- Client-side form validation
- API validation using FluentValidation

 
## Validation

SecureCatalog uses two layers of validation:

- Blazor DataAnnotations validation for client-side form feedback
- FluentValidation in the API to protect backend commands and enforce business rules

Example API validation:

- Product name is required
- Product name cannot exceed 100 characters
- Price must be greater than zero
- Stock cannot be negative

## Technologies

- ASP.NET Core 8
- Blazor
- ASP.NET Core Identity
- Entity Framework Core
- Dapper
- MediatR
- FluentValidation
- SQLite
- Serilog
- Bootstrap

## Architecture

## Architecture
The backend is implemented as an ASP.NET Core Minimal API using CQRS and MediatR. Product operations are handled through commands and queries, with Dapper providing lightweight data access to a SQLite database. FluentValidation is used to enforce business rules and input validation.

Authentication and user management are implemented using ASP.NET Core Identity and Entity Framework Core.

## Running Locally

1. Clone the repository
2. Open the solution in Visual Studio
3. Build the solution
4. Run the API project
5. Run the Blazor application

## Future Enhancements

* Azure deployment
* Authentication and authorization
* Product categories
* Search and filtering
* Pagination

## Author

Ronald Rex
