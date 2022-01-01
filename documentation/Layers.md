# Domain
Domain Layer implements the core, use-case independent business logic of the domain/system. By design, this layer is highly abstracted and stable. This layer contains a considerable amount of domain entities and should not depend on external libraries and frameworks. Ideally it should be loosely coupled even to the .NET Framework.
Domain project is core and backbone project. It is the heart and center project of the Clean Architecture design. All other projects should be depended on the Domain project.
This package contains the high level modules which describe the Domain via Aggregate Roots, Entities and Value Objects.
Domain layer contains:
- Entities
- Aggregates
- Value Objects
- Domain Events
- Enums
- Constants

# Application
Application Layer implements the use cases of the application based on the domain. A use case can be thought as a user interaction on the User Interface (UI). This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers.
Application layer contains the application Use Cases which orchestrate the high level business rules. By design the orchestration will depend on abstractions of external services (e.g. Repositories). The package exposes Boundaries Interfaces (in other terms Contracts or Ports or Interfaces) which are used by the User Interface.
For example, if the application need to access a email service, a new interface would be added to application and an implementation would be created within infrastructure.
Application layer contains:
- Abstractions/Contracts/Interfaces
- Application Services/Handlers
- Commands and Queries
- Exceptions
- Models (DTOs)
- Mappers
- Validators
- Behaviors
- Specifications

# Infrastructure
This layer is responsible to implement the Contracts (Interfaces/Adapters) defined within the application layer to the Secondary Actors. Infrastructure Layer supports other layer by implementing the abstractions and integrations to 3rd-party library and systems.
Infrastructure layer contains most of your application’s dependencies on external resources such as file systems, web services, third party APIs, and so on. The implementation of services should be based on interfaces defined within the application layer.
If you have a very large project with many dependencies, it may make sense to have multiple Infrastructure projects, but for most projects one Infrastructure project with folders works fine.
- Infrastructure.Persistence
  - Infrastructure.Persistence.MySQL
  - Infrastructure.Persistence.MongoDB
- Infrastructure.Identity

Infrastructure layer contains:
- Identity Services
- File Storage Services
- Queue Storage Services
- Message Bus Services
- Payment Services
- Third-party Services
- Notifications
  - Email Service
  - Sms Service

## Persistence Layer
This layer handles database concerns and other data access operations. By design the infrastructure depends on Application layer. This project contains implementations of the interfaces (e.g. Repositories) that defined in the Application project.
For instance an SQL Server Database is a secondary actor which is affected by the application use cases, all the implementation and dependencies required to consume the SQL Server is created on infrastructure (persistence) layer.
For example, if you wanted to implement the Repository pattern you would do so by adding an interface within Application layer and adding the implementation within Persistence (Infrastructure) layer.
Persistence layer contains:
- Data Context
- Repositories
- Data Seeding
- Data Migrations
- Caching (Distributed, In-Memory)

# Presentation
Presentation Layer contains the UI elements (pages, components) of the application. It handles the presentation (UI, API, etc.) concerns. This layer is responsible for rendering the Graphical User Interface (GUI) to interact with the user or Json data to other systems. It is the application entry-point.
User Interface layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. This layer can be an ASP.NET Core Web API with Single Page Application (SPA like Angular, React) or it can be an ASP.NET Core MVC with Razor Views.
This layer receives HTTP Requests from users, and Presenters converts the application outputs into ViewModels that are rendered as HTTP Responses.
User Interface layer contains:
- Controllers
- Views
- View Models
- Middlewares
- Filters/Attributes
- Web/API Utilities


[Source Ashish Patel](https://medium.com/dotnet-hub/clean-architecture-with-dotnet-and-dotnet-core-aspnetcore-overview-introduction-getting-started-ec922e53bb97) 