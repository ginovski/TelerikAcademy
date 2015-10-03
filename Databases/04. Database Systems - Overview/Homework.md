### 1. What database models do you know?
* Relational model
* Hierarchical model
* Network model
* Object-Oriented model
* Document-Oriented model

### 2. Which are the main functions performed by a Relational Database Management System (RDBMS)?
* Data dictionary management.
* Data storage management.
* Data transformation and presentation.
* Security management.
* Multiuser access control.
* Backup and recovery management.
* Data integrity management.

### 3. Define what is "table" in database terms.
A table is a collection of related data held in a structured format within a database. It consists of fields (columns), and rows.

In relational databases and flat file databases, a table is a set of data elements (values) using a model of vertical columns (identifiable by name) and horizontal rows, the cell being the unit where a row and column intersect.[1] A table has a specified number of columns, but can have any number of rows.[2] Each row is identified by one or more values appearing in a particular column subset. The columns subset which uniquely identifies a row is called the primary key.

### 4. Explain the difference between a primary and a foreign key.

##### Primary Key
* Primary key uniquely identify a record in the table.
* Primary Key can't accept null values.
* By default, Primary key is clustered index and data in the database table is physically organized in the sequence of clustered index
* We can have only one Primary key in a table.
##### Foreign Key
* Foreign key is a field in the table that is primary key in another table.
* Foreign key can accept multiple null value.
* Foreign key do not automatically create an index, clustered or non-clustered. You can manually create an index on foreign key.
* We can have more than one foreign key in a table.

### 5. Explain the different kinds of relationships between tables in relational databases.
**One-To-Many Relationship**

A one-to-many relationship is the most common type of relationship. In this type of relationship, a row in table A can have many matching rows in table B, but a row in table B can have only one matching row in table A. For example, the publishers and titles tables have a one-to-many relationship: each publisher produces many titles, but each title comes from only one publisher.

**Many-To-Many Relationship**

In a many-to-many relationship, a row in table A can have many matching rows in table B, and vice versa. You create such a relationship by defining a third table, called a junction table, whose primary key consists of the foreign keys from both table A and table B.

**One-To-One Relationship**

In a one-to-one relationship, a row in table A can have no more than one matching row in table B, and vice versa. A one-to-one relationship is created if both of the related columns are primary keys or have unique constraints.

### 6. When is a certain database schema normalized? What are the advantages of normalized databases?

Database normalization is the process of organizing the columns and tables of a relational database to minimize data redundancy.

Normalization involves decomposing a table into less redundant and smaller tables without losing information; defining foreign keys in the old table referencing the primary keys of the new ones. The objective is to isolate data so that additions, deletions, and modifications of an attribute can be made in just one table and then propagated through the rest of the database using the defined foreign keys.

### 7. What are database integrity constraints and when are they used?

Integrity constraints provide a way of ensuring that changes made to the database by authorized users do not result in a loss of data consistency.

An integrity constraint can be any arbitrary predicate applied to the database.

They may be costly to evaluate, so we will only consider integrity constraints that can be tested with minimal overhead.

### 8. Point out the pros and cons of using indexes in a database.

**Pros**

*	Quick access to a database table specific information. The index is a structure of the database table the value of one or more columns to sort.
*	Fast search in large data (don't use index when you have small data)

**Cons**

*  More indexes will affect the speed of update and insert, because it requires the same update each index file.
*  When data is frequently updated and new data is inserted don't use indexes. Use indexes only when you search in the data frequently and you need quick access to it.

### 9. What's the main purpose of the SQL language?

The Main purpose of SQL Language is for communication with the database and making queries for CRUD operations.

### 10. What are transactions used for? Give an example.

A transaction symbolizes a unit of work performed within a database management system (or similar system) against a database, and treated in a coherent and reliable way independent of other transactions. A transaction generally represents any change in database. Transactions in a database environment have two main purposes:

1. To provide reliable units of work that allow correct recovery from failures and keep a database consistent even in cases of system failure, when execution stops (completely or partially) and many operations upon a database remain uncompleted, with unclear status.
2. To provide isolation between programs accessing a database concurrently. If this isolation is not provided, the programs' outcomes are possibly erroneous.

**Example:**
Withdrawing from bank account

### 11. What is a NoSQL database?
A NoSQL (originally referring to "non SQL" or "non relational") database provides a mechanism for storage and retrieval of data that is modeled in means other than the tabular relations used in relational databases.

### 12. Explain the classical non-relational data models.

A non-relational database is a database that does not incorporate the table/key model that relational database management systems (RDBMS) promote.
These kinds of databases require data manipulation techniques and processes designed to provide solutions to big data problems that big companies face. 

### 13. Give few examples of NoSQL databases and their pros and cons.

* **Document databases** pair each key with a complex data structure known as a document. Documents can contain many different key-value pairs, or key-array pairs, or even nested documents.
* **Graph stores** are used to store information about networks, such as social connections. Graph stores include Neo4J and HyperGraphDB.
* **Key-value stores** are the simplest NoSQL databases. Every single item in the database is stored as an attribute name (or "key"), together with its value. Examples of key-value stores are Riak and Voldemort. Some key-value stores, such as Redis, allow each value to have a type, such as "integer", which adds functionality.
* **Wide-column stores** such as Cassandra and HBase are optimized for queries over large datasets, and store columns of data together, instead of rows.

