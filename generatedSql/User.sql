CREATE TABLE Users(
Guid uniqueidentifier,
Id bigint IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(250),
UserName VARCHAR(250),
IsLoggedIn int
);
