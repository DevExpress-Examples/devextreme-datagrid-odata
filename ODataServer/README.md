# ODataServer

An [ASP.NET Core OData 8](https://learn.microsoft.com/en-us/odata/webapi-8/overview) project that provides OData endpoints for querying data.

## Overview

This server exposes product data through OData endpoints, enabling advanced querying capabilities such as filtering, sorting, selecting specific fields, and more through standardized OData query options.

## Features

- **OData v8 Protocol** - Standards-compliant REST API with full OData support
- **CORS enabled** - Allows cross-origin requests from client applications
- **Port 5005** - Runs on HTTP port 5005 and HTTPS port 5006

## Project Structure

```
ODataServer/
├── Controllers/
│   └── ProductsController.cs    # OData controller for Products entity
├── Models/
│   ├── Product.cs               # Product entity model
│   └── SampleData.cs            # Sample product data
├── Program.cs                   # Application startup and OData configuration
├── appsettings.json             # Application settings
└── ODataServer.csproj           # Project file
```

## Configuration

The OData service is configured in `Program.cs` with the following features:

- **Entity Sets**: Products
- **Query Options**: `$select`, `$filter`, `$orderby`, `$expand`, `$count`, `$top`
- **CORS**: Configured to allow requests from `http://localhost:5050`

## Running the Server

```bash
dotnet run
```

The server will start on:
- HTTP: http://localhost:5005
- HTTPS: https://localhost:5006

Access the OData service at:
- Products endpoint: http://localhost:5005/odata/Products
- Metadata document: http://localhost:5005/odata/$metadata

## CORS Policy

The server allows requests from `http://localhost:5050` with all methods and headers. This is configured for development purposes. For production, update the CORS policy in `Program.cs` to restrict allowed origins as needed.
