LAB 2: Setting Up EF Core in a C# Application
In this lab, we focus on establishing a core connection between our C# application and a SQL Server database using Entity Framework Core (EF Core).

We start by creating model classes for Category and Product, which define the structure of the data we’ll store in the database. These models represent the tables in SQL Server.

To manage the communication between our application and the database, we introduce a class called AppDbContext. This context class instructs EF Core on which tables to generate—specifically, Products and Categories—and how to connect to the database using a defined connection string.

By configuring this DbContext, we allow EF Core to handle the object-relational mapping (ORM) process. This means C# objects can be automatically translated to SQL tables and vice versa, without requiring us to manually write SQL queries.

The setup begins with creating a new console project named RetailInventory and navigating into the project directory. We then install the required EF Core packages: one for SQL Server integration, one for design-time features, and finally, the EF Core CLI tool globally to assist with commands like migrations and updates.

Once this configuration is complete, the application is ready to interact with SQL Server using EF Core, streamlining data operations with minimal boilerplate code.