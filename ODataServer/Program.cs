using Microsoft.AspNetCore.OData;
using Microsoft.OData.ModelBuilder;
using ODataServer.Models;

var builder = WebApplication.CreateBuilder(args);

// Configure URLs
builder.WebHost.UseUrls("http://localhost:5005", "https://localhost:5006");

// Configure CORS
builder.Services.AddCors(options => options
    .AddPolicy("AllowWeb", policy => policy
        .WithOrigins("http://localhost:5050")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
    ));

// Build the Edm model
var modelBuilder = new ODataConventionModelBuilder();
modelBuilder.EntitySet<Product>("Products");

// Configure OData
builder.Services.AddControllers().AddOData(options => options
    .Select()
    .Filter()
    .OrderBy()
    .Expand()
    .Count()
    .SetMaxTop(null)
    .AddRouteComponents("odata", modelBuilder.GetEdmModel())
);

var app = builder.Build();

app.UseCors("AllowWeb");

app.UseRouting();

app.MapControllers();

app.Run();
