# Clean Architecture


# Seperation of Concerns
## Domain
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

## Application
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

## Infrastructure
This layer is responsible to implement the Contracts (Interfaces/Adapters) defined within the application layer to the Secondary Actors. Infrastructure Layer supports other layer by implementing the abstractions and integrations to 3rd-party library and systems.
Infrastructure layer contains most of your application’s dependencies on external resources such as file systems, web services, third party APIs, and so on. The implementation of services should be based on interfaces defined within the application layer.
If you have a very large project with many dependencies, it may make sense to have multiple Infrastructure projects, but for most projects one Infrastructure project with folders works fine.
- Infrastructure.Persistence
-- Infrastructure.Persistence.MySQL
-- Infrastructure.Persistence.MongoDB
- Infrastructure.Identity

Infrastructure layer contains:
- Identity Services
- File Storage Services
- Queue Storage Services
- Message Bus Services
- Payment Services
- Third-party Services
- Notifications
-- Email Service
-- Sms Service