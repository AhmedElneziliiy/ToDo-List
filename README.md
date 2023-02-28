TodoList API 
This is the documentation for the TodoList API, which is built using ASP.NET Core and .NET 6. The API allows users to perform CRUD operations on a collection of todo items.

Endpoints
The API has the following endpoints:

GET /api/todo - retrieves all todo items
GET /api/todo/{id} - retrieves a specific todo item by id
POST /api/todo - adds a new todo item
PUT /api/todo/{id} - updates a specific todo item by id
DELETE /api/todo/{id} - deletes a specific todo item by id
Request and Response Formats
The API accepts and returns JSON-formatted data. The following is a description of the data formats for each endpoint.

Error Handling
The API returns the following error responses:

400 Bad Request - when the request is invalid (e.g. missing required fields)
404 Not Found - when the requested todo item is not found
500 Internal Server Error - when an unexpected error occurs on the server
