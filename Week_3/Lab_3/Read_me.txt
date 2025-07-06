LAB 3: Managing Database Schema with EF Core CLI
In this lab, we explore how to manage the structure of a SQL Server database using the Entity Framework Core Command Line Interface (CLI).

A migration in EF Core is a way to track and apply changes to the database schema over time. Based on the C# models defined in Lab 2, we generate a migration that automatically creates the SQL scripts needed to build our tables.

Once the migration is created, we apply it to the database using the dotnet ef database update command. This step materializes the changes by creating actual tables in the database. Through EF Core’s migration system, the database remains synchronized with our evolving C# model structure as the application grows.

Migration Workflow
Create the migration:
dotnet ef migrations add InitialCreate --project RetailInventory

Apply the migration to generate the database:
dotnet ef database update --project RetailInventory

Verify the database in SQL Server Object Explorer:
Navigate through:
(localdb)\MSSQLLocalDB → Databases → RetailStore → Tables
You should now see the Products and Categories tables.

Core Concepts and Terminology
ORM (Object-Relational Mapping):
Automates the mapping of C# objects (classes) to relational database tables, abstracting SQL code and simplifying database interactions.

Entity Framework Core (EF Core):
A modern, cross-platform ORM for .NET that supports LINQ, async operations, migrations, and advanced database features.

EF Core vs EF6:
EF Core is faster, lightweight, cross-platform, and more flexible. EF6 is older and limited to Windows.

EF Core 8.0 Enhancements:

JSON column mapping

Performance boost via compiled models

Interceptors

Improved bulk operations

Key EF Core Components
Models:
C# classes like Category and Product that define the structure of database tables.

Properties:
Model attributes that map to table columns (e.g., Id, Name, Price).

DbContext:
The class (AppDbContext) representing a session with the database. It tracks changes and manages interactions.

DbSet:
Represents a table in the database. For example, DbSet<Product> maps to the Products table.

Connection String:
Configuration string for database access. Example:
"Server=(localdb)\\MSSQLLocalDB;Database=RetailStore;Trusted_Connection=True;"

SQL Server LocalDB:
A lightweight version of SQL Server ideal for development and testing.

EF Core CLI:
Toolset for managing EF Core commands like migrations and updates via terminal.

Migration:
A method to version control schema changes. Created using:
dotnet ef migrations add InitialCreate --project RetailInventory

Database Update:
Applies the migration changes to the database. Command:
dotnet ef database update --project RetailInventory

Common EF Core Operations
AddRangeAsync:
Inserts multiple records into the database in one call.

SaveChangesAsync:
Commits any changes made to the database context.

LINQ (Language Integrated Query):
A powerful syntax for querying and manipulating data:

ToListAsync() – Fetches all records asynchronously

FindAsync() – Retrieves a record by primary key

FirstOrDefaultAsync() – Returns the first record that matches a condition

Where() – Filters data based on conditions

OrderByDescending() – Sorts records in descending order

Select() – Projects or transforms data into new shapes

Data Transfer Object (DTO):
A simplified object used to carry specific pieces of data—often used in API responses.

Async and Await:
Keywords enabling non-blocking operations during tasks like database access.

Update Operations:
Modify records by changing their properties and saving the context.

Delete Operations:
Remove records using Remove() followed by SaveChangesAsync().

EF Core Change Tracking:
EF Core automatically tracks added, modified, or deleted entities via the DbContext, ensuring updates are applied appropriately.

