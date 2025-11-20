using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODataServer.Models;

namespace ODataServer.Controllers
{
    public class ProductsController : ODataController
    {
        [EnableQuery]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Ok(SampleData.Products);
        }
    }
}
