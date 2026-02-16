<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/1099673152/25.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1314126)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# DevExtreme DataGrid - Bind to an OData Service

This example binds the DevExtreme DataGrid component to an OData v4 service. The ODataStore is configured to run server-side data operations including filtering, record selection, and sorting.

## Implementation Details

### Setup the OData Server

This example includes a pre-configured ASP.NET Core OData server (see [ODataServer](/ODataServer/)) that uses OData REST APIs to expose sample data. The server runs at `http://localhost:5005` and creates the following endpoint: `/odata/Products`.

### Configure the DataGrid

All framework projects share the same implementation:

1. Create an [ODataStore](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/ODataStore/). Specify the service [url](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/ODataStore/Configuration/#url), [key](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/ODataStore/Configuration/#key) data field, and OData [version](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/ODataStore/Configuration/#version).
2. You can configure a standalone **ODataStore** service (see [OData](https://js.devexpress.com/Documentation/Guide/Data_Binding/Specify_a_Data_Source/OData/) for details), but this examples uses a [DataSource](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/DataSource/) to implement data [filtering](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/DataSource/Configuration/#filter) and [selection](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/DataSource/Configuration/#select) operations.
3. [Bind the DataGrid](https://js.devexpress.com/Documentation/Guide/UI_Components/DataGrid/Getting_Started_with_DataGrid/#Bind_the_DataGrid_to_Data) to the data source.

## Run the Example

### Angular, React, Vue, and jQuery

1. **Start the OData Server**
    Execute the following command to start the OData server:

    ```bash
    cd ODataServer
    dotnet run
    ```

    The server is available at the following URL: `http://localhost:5005`.

2. **Run the Client Application**
    Execute one of the following commands to run the client application:
   
    - **Angular:** `cd Angular && npm install && npm start`
    - **React:** `cd React && npm install && npm run dev`
    - **Vue:** `cd Vue && npm install && npm run dev`
    - **jQuery:** `cd jQuery && npm install && npm start`

### ASP.NET Core

Our ASP.NET Core example includes a standalone OData server. Run the following command to start the client application and server:

```bash
cd "ASP.NET Core"
dotnet run
```

The application is available at the following URL: `http://localhost:59183` .

## Files to Review

- **OData Server**
    - [Program.cs](ODataServer/Program.cs) - OData service configuration
    - [ProductsController.cs](ODataServer/Controllers/ProductsController.cs) - OData controller
    - [Product.cs](ODataServer/Models/Product.cs) - Product entity model

- **Angular**
    - [app.component.html](Angular/src/app/app.component.html)
    - [app.component.ts](Angular/src/app/app.component.ts)

- **React**
    - [App.tsx](React/src/App.tsx)

- **Vue**
    - [HomeContent.vue](Vue/src/components/HomeContent.vue)

- **jQuery**
    - [index.js](jQuery/src/index.js)

- **ASP.NET Core**    
    - [Index.cshtml](ASP.NET%20Core/Views/Home/Index.cshtml)
    - [Program.cs](ASP.NET%20Core/Program.cs)
    - [ProductsController.cs](ASP.NET%20Core/Controllers/ProductsController.cs)
    - [Product.cs](ASP.NET%20Core/Models/Product.cs)

## Documentation

- [Getting Started with DataGrid](https://js.devexpress.com/Documentation/Guide/UI_Components/DataGrid/Getting_Started_with_DataGrid/)
- [Specify a Data Source - OData](https://js.devexpress.com/Documentation/Guide/Data_Binding/Specify_a_Data_Source/OData/)
- [Data Source Examples - OData](https://js.devexpress.com/Angular/Documentation/Guide/Data_Layer/Data_Source_Examples/#OData)

## More Examples

- [ODataContext for DevExtreme - How to filter data by a foreign key value](https://github.com/DevExpress-Examples/devextreme-odatacontext-filter-data-by-foreign-key-value)
<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=devextreme-datagrid-odata&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=devextreme-datagrid-odata&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
