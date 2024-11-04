﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreOnline.Models;

namespace BookStoreOnline.Controllers
{
    public class OrderController : Controller
    {
        NhaSachEntities db = new NhaSachEntities();
        // GET: Order
        public ActionResult Index(int id)
        {
            return View(db.DONHANGs.Where(o => o.ID == id).ToList());
        }

        
    }
}