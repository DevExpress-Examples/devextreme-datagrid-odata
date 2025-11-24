<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/1099673152/25.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1314126)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# DataGrid for DevExtreme - How to bind DataGrid to an OData Service

This example demonstrates how to bind the DevExtreme DataGrid component to an OData v4 service. It shows how to configure the ODataStore for server-side data operations including filtering, selecting specific fields, and querying product data.

## Implementation Overview

### OData Server Setup

This example includes a pre-configured ASP.NET Core OData server (see [ODataServer](/ODataServer/)) that exposes product data through a standardized REST API. The server runs on `http://localhost:5005` and provides the `/odata/Products` endpoint.

### DataGrid Configuration

All framework implementations follow the same pattern:

1. Create an [ODataStore](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/ODataStore/). Use its properties to specify the service's [url](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/ODataStore/Configuration/#url), [key](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/ODataStore/Configuration/#key) data field, and OData [version](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/ODataStore/Configuration/#version).
2. You can configure **ODataStore** as a standalone element (see [OData](https://js.devexpress.com/Documentation/Guide/Data_Binding/Specify_a_Data_Source/OData/) for details), but this examples uses a [DataSource](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/DataSource/) to demonstrate data [filtering](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/DataSource/Configuration/#filter) and data fields [selection](https://js.devexpress.com/Documentation/ApiReference/Data_Layer/DataSource/Configuration/#select).
3. [Bind the DataGrid](https://js.devexpress.com/Documentation/Guide/UI_Components/DataGrid/Getting_Started_with_DataGrid/#Bind_the_DataGrid_to_Data) to the data source.

## Running the Example

**For Angular, React, Vue, and jQuery:**

1. **Start the OData Server:**
   ```bash
   cd ODataServer
   dotnet run
   ```
   The server will be available at `http://localhost:5005`.

2. **Run the Client Application:**
   
   Choose your preferred framework and follow its setup:
   
   - **Angular:** `cd Angular && npm install && npm start`
   - **React:** `cd React && npm install && npm run dev`
   - **Vue:** `cd Vue && npm install && npm run dev`
   - **jQuery:** `cd jQuery && npm install && npm start`

**For ASP.NET Core:**

The ASP.NET Core example includes its own OData server, so you only need to run:

```bash
cd "ASP.NET Core"
dotnet run
```

The application will be available at `http://localhost:59183` .

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
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=devextreme-datagrid-odata&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=devextreme-datagrid-odata&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
