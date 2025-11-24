using System.Collections.Generic;
using ASP_NET_Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace ASP.NET_Core.Controllers;
public class ProductsController: ODataController {
    [EnableQuery]
    public ActionResult<IEnumerable<Product>> Get() {
        return Ok(SampleData.Products);
    }
}
