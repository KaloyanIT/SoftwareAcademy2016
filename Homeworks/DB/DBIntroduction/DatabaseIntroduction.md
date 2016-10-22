# Databases Introduction

### 1.What database models do you know?
  * Object-relational Model
  * Relational Model
  * Network Model and Hierarchical Model
  * Object-oriented Model

### 2.Which are the main functions performed by a Relational Database Management System (RDBMS)?
  This model organizes data into one or more tables (or "relations") of columns and rows, with a unique key identifying each row. Rows are also called records or tuples. Generally, each table/relation represents one "entity type" (such as customer or product). The rows represent instances of that type of entity (such as "Lee" or "chair") and the columns representing values attributed to that instance (such as address or price).

### 3.Define what is "table" in database terms.

    Table is a set of data elements (values) using a model of vertical columns
    (identifiable by name) and horizontal rows, the cell being the unit
     where a row and column intersect.
     A table has a specified number of columns,
     but can have any number of rows.

### 4.Explain the difference between a primary and a foreign key.
   | Primary Key | Foreign Key |
   |-------------|-------------|
   |Primary key uniquely identify a record in the table. |We can have more than one foreign key in a table. |
   |Primary Key can't accept null values. |We can have more than one foreign key in a table. |
   |By default, Primary key is clustered index and data in the database table is physically organized in the sequence of clustered index.| Foreign key can accept multiple null value. |
   |We can have only one Primary key in a table| Foreign key is a field in the table that is primary key in another table.|

### 5.Explain the different kinds of relationships between tables in relational databases.

- One to One: One entity is associated with another entity. For Ex: Each employee is associated with one department
- One to Many: One entity is associated with many other entities. For Ex: A company is associated with all working employees in one branch/office/country.
- Many to One: Many entities are associated with only one entity. For Ex: Many employees are associated with one project.
- Many to Many: Many entities are associated with many other entities. For Ex: In a company many employees are associated with multiple projects(completed/existing), and at the same time, projects are associated with multiple employees.

### 6.When is a certain database schema normalized?
 - ##### What are the advantages of normalized databases?

### 7.What are database integrity constraints and when are they used?
### 8.Point out the pros and cons of using indexes in a database.
### 9.What's the main purpose of the SQL language?
### 10.What are transactions used for? Give an example.

### 11.What is a NoSQL database?
### 12.Explain the classical non-relational data models.
### 13.Give few examples of NoSQL databases and their pros and cons.
