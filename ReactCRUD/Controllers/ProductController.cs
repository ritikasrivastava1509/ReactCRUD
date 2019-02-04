using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactCRUD.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactCRUD.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {

        ProductDataAccessLayer objProductDAL = new ProductDataAccessLayer();

        // GET: api/<controller>
        [HttpGet("[action]")]
        public JsonResult GetProducts()
        {
            return Json(objProductDAL.GetAllProducts());
        }

        [HttpPost]
        [Route("api/Product/AddProduct")]
        public int AddProduct(Product product)
        {
            return objProductDAL.AddProduct(product);
        }

        //// GET api/<controller>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}


    }
}
