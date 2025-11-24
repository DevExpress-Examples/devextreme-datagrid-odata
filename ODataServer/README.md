# ODataServer

An [ASP.NET Core OData 8](https://learn.microsoft.com/en-us/odata/webapi-8/overview) project that creates OData endpoints.

## Overview

This server creates OData endpoints to expose sample data. You can use standardized OData queries to access data and run filtering, sorting, and selection operations.

## Features

- **OData Protocol** - OData-compliant REST API
- **CORS enabled** - Allows cross-origin requests from client applications

## Project Structure

```
ODataServer/
├── Controllers/
│   └── ProductsController.cs    # OData controller for the Products entity
├── Models/
│   ├── Product.cs               # Product entity model
│   └── SampleData.cs            # Sample product data
├── Program.cs                   # Application startup and OData configuration
├── appsettings.json             # Application settings
└── ODataServer.csproj           # Project file
```

## Configuration

`Program.cs` configures the OData service and implements the following features:

- **Entity Sets**: Products
- **Query Options**: `$select`, `$filter`, `$orderby`, `$expand`, `$count`, `$top`
- **CORS**: Allows requests from `http://localhost:5050`

## Run the Server

```bash
dotnet run
```

The server starts at the following URLs:
- HTTP: http://localhost:5005
- HTTPS: https://localhost:5006

Access the OData service at:
- Products endpoint: http://localhost:5005/odata/Products
- Metadata document: http://localhost:5005/odata/$metadata

## CORS Policy

The server allows all requests from `http://localhost:5050` (all methods and headers). This configuration is for development purposes. In production, update the CORS policy in `Program.cs` to restrict allowed origins as needed.
