using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace MyFirstApi.Controllers

{

    [ApiController]
    
    [Route("api/[controller]")] 
    # means the route is based on the controller name (ProductsController → products)

    public class ProductsController : ControllerBase

    {

        [HttpGet] 
        # maps a method to an HTTP GET request

        public ActionResult<List<string>> Get()

        {

            return new List<string> { "Apple", "Banana", "Orange" };

        }


    }

}