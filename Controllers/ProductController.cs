﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assignment2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Models.Product p = new Models.Product();

            //pass a list of products to the view
            return View(p.GetProducts());
           
        }
    }
}