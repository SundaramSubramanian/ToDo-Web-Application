-----------------   Execute the Script one by one as for now ------- Workitems are in Progress --------------------------------------

--CREATE DATABASE ToDoApp 

--USE ToDoApp

--CREATE SCHEMA Users 

--CREATE SCHEMA ToDoList

--CREATE TABLE Users.Registration (UserId INT PRIMARY KEY IDENTITY(1,1), FirstName NVARCHAR(50),LastName NVARCHAR(50),EmailId NVARCHAR(50), CreatedDt DATETIME);

--CREATE TABLE Users.AccountDetails(AccountId INT PRIMARY KEY IDENTITY(1,1), UserId INT REFERENCES Users.Registration(UserId), UserPassword NVARCHAR(200),IsActive BIT, CreatedDt DATETIME);

-- CREATE TABLE ToDoList.WorkStatus(WorkStatusId INT PRIMARY KEY IDENTITY(1,1), WorkStatus NVARCHAR(25), CreatedDt DATETIME);

--CREATE TABLE ToDoList.WorkItems(WorkId INT PRIMARY KEY IDENTITY(1,1), WorkItem NVARCHAR(200),WorkItemStatus INT REFERENCES ToDoList.WorkStatus(WorkStatusId),CreatedDt DATETIME,CreatedBy INT REFERENCES Users.Registration(UserId), UpdatedDt DATETIME);




