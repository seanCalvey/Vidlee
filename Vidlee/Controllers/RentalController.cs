﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidlee.Controllers
{
    public class RentalController : Controller
    {
        // GET: Rental
        public ActionResult NewRental()
        {
            return View();
        }
    }
}