# BookShelf App

## Instructions

The goal of this application is to allow users to keep track of the books they have on their bookshelf, as well as the authors of those books.

This application should be built in ASP.NET Core MVC with Entity and Identity Frameworks and use a SQL Server database to store data.


### Requirements

1. Only authenticated users should have access to any Book or Author functionality
1. New users should be able to register for an account.
1. Existing users should be able to login with an email and password.
1. A user should be able to perform all CRUD operations on an Author.
1. A user should be able to perform all CRUD operations on a Book.
1. Users should **only** be allowed to View, Edit or Delete Books and Authors that **they created**.
1. Only Authors **not associated with a Book** may be deleted.