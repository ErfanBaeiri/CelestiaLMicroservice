## About

**Celestial** is a modular and scalable microservices-based backend system built with **.NET Core**, designed to showcase real-world software architecture patterns and enterprise-grade practices.

This project demonstrates how to build a distributed system with **Clean Architecture**, leveraging cutting-edge tools and methodologies to ensure maintainability, extensibility, and performance.

### ✨ Key Technologies

- 🧱 **.NET Core** – Cross-platform framework for building high-performance microservices  
- 📦 **Microservices Architecture** – Independent, domain-focused services for better scalability and isolation  
- ⚙️ **CQRS (Command Query Responsibility Segregation)** – Clean separation of read/write operations for scalability and clarity  
- 🧭 **MediatR** – Lightweight in-process messaging for clean decoupling between components  
- 🐇 **RabbitMQ** – Message broker for asynchronous communication and event-driven architecture  
- 🧠 **Redis** – In-memory data store used for caching and improving performance  
- 🔗 **gRPC** – High-performance RPC framework for efficient inter-service communication  
- 🗃️ **SQL Server** – Reliable and powerful relational database system for data persistence  
- 🔄 **API Versioning** – Seamless evolution of APIs without breaking existing clients  
- 🧼 **Clean Architecture** – Layered, testable, and maintainable project structure  

### 🧩 Project Structure

- `EventBus` – Infrastructure for handling and publishing integration events via RabbitMQ  
- `Services` – Each microservice handles a specific domain with its own bounded context  
- `SharedKernel` – Common contracts and abstractions shared across services  
- `API Gateway` – Entry point for client requests and service routing (can be extended with Ocelot)  
- `gRPC Contracts` – Definitions for gRPC-based inter-service communication  
- `Redis Cache` – Centralized caching for performance and scalability  



