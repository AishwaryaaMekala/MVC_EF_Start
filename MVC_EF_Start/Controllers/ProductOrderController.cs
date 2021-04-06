using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_EF_Start.DataAccess;
using MVC_EF_Start.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_EF_Start.Controllers
{
    public class ProductOrderController : Controller
    {
        public ApplicationDbContext dbContext;

        public ProductOrderController(ApplicationDbContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            //I would create data for the 3 tables viz. Product, Order and OrderDetails in this controller
            // Below code for adding these to tables and finally saving changes:

            //dbContext.Products.Add();
            //dbContext.Orders.Add();
            //dbContext.OrderDetails.Add();

            dbContext.SaveChanges();
            return View();
        }
    }
}
