using ApiOnkar.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiOnkar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Data.ApplicationDbContext db;
        public ProductController(Data.ApplicationDbContext db) {
            this.db = db;
        }

        [HttpPost]
        [Route("addproduct")]
        public IActionResult Addproduct(Products e)
        {
            db.Products.Add(e);
            db.SaveChanges();
            return Ok("Product Added Successfully");
        }
        [HttpGet]
        [Route("fetchproducts")]
        public IActionResult fetch()
        {
            return Ok(db.Products.ToList());
        }
        [HttpPost]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var data = db.Products.Find(id);
            db.Products.Remove(data);
            db.SaveChanges();
            return Ok("Deleted");
        }

        [HttpPut]
        [Route("update/{id}")]
        public IActionResult Update(int id,Products p)
        {
            //var data = db.Products.Find(id);
            //data.Name = p.Name;
            //data.Category = p.Category;
            //data.Price = p.Price;
            db.Products.Update(p);
            db.SaveChanges();
            return Ok("Updated");
        }

    }
}
