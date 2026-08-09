# Agile Team Development Project

A collaborative team project implementing a web application built with C# and ASP.NET, backed by a T-SQL (SQL Server) database. This repository contains the code, database scripts, and documentation for the project developed using Agile practices (user stories, sprints, code review, CI).

---

## Table of contents
- [Project overview](#project-overview)
- [Tech stack](#tech-stack)
- [Key features](#key-features)
- [Architecture](#architecture)
- [Getting started (local development)](#getting-started-local-development)
- [Database setup](#database-setup)
- [Running tests](#running-tests)
- [Development workflow](#development-workflow)
- [CI / Deployment](#ci--deployment)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)
- [Repository language composition](#repository-language-composition)

---

## Project overview
This project is an example of an Agile team software-development effort. It demonstrates typical patterns for building an ASP.NET web application with a C# codebase and a SQL Server backend. The intent is to be a collaborative codebase for teaching or demonstrating Agile development practices (stories, sprint planning, iterative delivery, code review).

Add a short one- or two-line mission statement here (what problem the app solves, target users, and primary use case).

---

## Tech stack
- Primary language: C#
- Web framework: ASP.NET (MVC / Web API / Razor Pages — adjust as appropriate)
- Database: Microsoft SQL Server (T-SQL)
- Build & runtime: .NET SDK (see project settings for exact version)
- Testing: xUnit / NUnit / MSTest (adjust to your chosen test framework)
- Optional: Docker for containerized local development

---

## Key features
- User authentication and authorization (if present)
- CRUD operations for core domain entities
- REST API endpoints for integration
- Server-side validation and error handling
- Data persistence with SQL Server
- Unit and integration tests

Tailor this list to reflect actual features implemented in the repository.

---

## Architecture
A typical structure you can adapt:
- /src
  - /WebApp (ASP.NET project: controllers, pages, views)
  - /Core (domain models, business logic)
  - /Data (data access, repositories, EF Core or ADO.NET mapping)
  - /Tests (unit and integration tests)
- /db
  - SQL scripts and migration artifacts
- /docs
  - Sprint notes, design docs, user stories

Adjust to match the repository layout.

---

## Getting started (local development)

Prerequisites
- .NET SDK (check `global.json` or use .NET 6.0/7.0/8.0 as used by the repo)
- SQL Server (LocalDB, SQL Server Developer, or Docker image)
- Optional: Docker & Docker Compose

Quick start
1. Clone the repo:
   git clone https://github.com/AT0673/Agile-Team-Development-Project.git
2. Change into the repo:
   cd Agile-Team-Development-Project
3. Restore dependencies and build:
   dotnet restore
   dotnet build
4. Run the web project (replace `<WebProjectPath>` with the actual path, e.g., `src/WebApp` or the .sln entry):
   dotnet run --project src/<WebProjectProjectName>
5. Open your browser at http://localhost:5000 (or the URL printed by the run command)

If the repository includes a solution (.sln), you can run:
   dotnet run --project path/to/Your.Web.Project.csproj

---

## Database setup

If the project uses migrations (EF Core):
1. Ensure your connection string (in `appsettings.Development.json` or environment variables) points to your local SQL Server instance.
2. From the project containing the EF migrations:
   dotnet ef database update

If the project uses SQL scripts:
1. Create the database in your local SQL Server instance.
2. Execute the SQL scripts located in `/db` (or other folder) in the correct order (tables → seed data → stored procedures).

Notes:
- Provide your connection string using environment variables or a secrets manager during development to avoid committing credentials.
- If you want, I can look at the repository and generate exact database setup steps (e.g., list the script filenames and order).

---

## Running tests
Run unit tests with:
   dotnet test

For integration tests that require a database, ensure the test database is configured and available before running tests.

---

## Repository language composition
According to GitHub language stats:
- C#: 86.9%
- ASP.NET: 13.0%
- T-SQL: 0.1%
