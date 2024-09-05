using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using APID.Models;
namespace APID.Controllers
{
    public class ProductsController
    {
        [RoutePrefix("api/Producto")]
        public class ProductoController : ApiController
        {
            [Route("addProduct")]
            [HttpPost]
            public string AddProduct(Product p)
            {
                return p.AddProduct();
            }
        }
    }
}