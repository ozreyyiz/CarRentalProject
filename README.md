# CarRental Project

This project is developed to manage car rental operations, utilizing a web application. The project follows Clean Architecture principles, SOLID principles, and incorporates the Entity Framework.

## Technologies and Libraries
- ASP.NET Core Web API
- Entity Framework Core
- MSSQL Server
- Swagger/OpenAPI

## Getting Started

1. Clone the repository:

```bash
git clone https://github.com/yourusername/CarRentalProject.git
cd CarRentalProject
```
## Layers and Understanding the Project
The project is organized into the following fundamental layers and follows the principles of Clean Architecture:

- Core: Contains core entities and business logic rules.
- Data: Handles database connection and Entity Framework configuration.
- Application: Contains application services, DTOs, and mappings for application-level business logic.
- WebAPI: API controllers that handle incoming requests from HTTP clients and invoke application services to perform business logic.

Contributing
1. Fork this repository.
2. Create a new feature branch: git checkout -b new-feature
3. Make your changes and commit them: git commit -m 'Added a new feature'
4. Merge your branch with the main project branch: git merge main
5. Push your fork to the main repository: git push origin new-feature
6. Create a Pull Request.
