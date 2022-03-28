# backend
Project Structure 
Separate systems functionalities into  separated modules for ease development  process
Common,utils,services,Repo,Data,web api,web app,Dto

Adoption for Repository Pattern as data access layer to restrict data access only through our defined interfaces,
With base implements for ease decoupling  data sources and ORM engines.

Introduce the use of services as a logic layer to limit and  move the  heavy logic from controlled to services,with defined interfaces, that helps with maintainability and code reusability.
Use of Common and Utils modules  for shared components and helpers.

Separate Data module for  Data sources, domain entities  and migrations in a single module.

Produce one unified communication structure between all system modules and layers.
That works as  an internal protocol for system units to communicate.

Each module is responsible for registering its interfaces In DI container.

Use Swagger as documentation tool  for WebApi App.

How to start the app:

Make sure postgresql is installed and running.
Update database migration using Package Manager Console, Type (update-database) command  make sure to target the Data project module as migration destination.
Run the application.
Auto seed process will kick in and fill the database with sample data

