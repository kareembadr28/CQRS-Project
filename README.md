# CQRS Project 🚀

A small .NET 9 Web API side project built for learning and experimenting with **CQRS, MediatR, Event Handling, Minimal APIs, Dependency Injection, and Extension Methods**.

This project is intentionally kept simple and uses an in-memory static list instead of a real database. The main goal is to focus on understanding how these concepts work together in a real API structure.

---

## 🛠️ Tech Stack

- **.NET 9**
- **ASP.NET Core Minimal APIs**
- **C#**
- **MediatR**
- **CQRS**
- **Event Handling / Domain Events**
- **Dependency Injection**
- **Extension Methods**
- **Swagger / OpenAPI**
- **In-Memory Static Data**

---

## 🏗️ Architecture

The project follows a simple **CQRS-based structure** where Commands and Queries are separated.

```text
HTTP Request
     │
     ▼
Minimal API Endpoint
     │
     ▼
MediatR
     │
     ├───────────────┐
     ▼               ▼
 Command           Query
     │               │
     ▼               ▼
Command Handler   Query Handler
     │               │
     └───────┬───────┘
             ▼
       Repository
             │ 
             ▼
      In-Memory Data

For **events**, the flow looks like:

Command Handler
      │
      ▼
Create Product
      │
      ▼
Publish Event
      │
      ▼
ProductCreatedEvent
      │
      ▼
Event Handler
      │
      ▼
Logging / Side Effects
