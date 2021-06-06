﻿using Estore.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly EstoreDBContext DB = new EstoreDBContext();

        [HttpGet]
        [Route("GetProduct")]
        public string getProduct()
        {
            return "Umair";
        }

        [HttpPost]
        [Route("AddProduct")]
        public async void AddProduct(Product p1)
        {
            DB.Products.Add(p1);
            await DB.SaveChangesAsync();
        }

        [HttpDelete]
        [Route("DeleteProduct")]
        public void DeleteProduct(Product p1)
        {
            var x = (from y in DB.Products
                     where y.Name == p1.Name
                     select y).FirstOrDefault();
            DB.Remove(x);
            DB.SaveChangesAsync();
        }

        [HttpPut]
        [Route("UpdateProduct")]
        public void UpdateProduct(Product p1)
        {
            var query = from prod in DB.Products
                        where prod.Name == p1.Name
                        select prod;

            // Execute the query, and change the column values
            // you want to change.
            foreach (Product pro in query)
            {
                pro.Name = p1.Name;
                pro.Price = p1.Price;
                pro.Discount = p1.Discount;
                pro.ImageAddress = p1.ImageAddress;
                pro.Category = p1.Category;
                pro.OwnerId = p1.OwnerId;
                pro.Ratings = p1.Ratings;
                // Insert any additional changes to column values.
            }

            // Submit the changes to the database.
            try
            {
                DB.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Provide for exceptions.
            }
        }
    }
}
