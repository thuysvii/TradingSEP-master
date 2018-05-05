﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TradingVLU.Controllers
{
    [RoutePrefix("items")]
    [Route("{action=index}")]
    public class ItemController : Controller
    {
        public ActionResult index()
        {
            return View();
        }

        public ActionResult detail()
        {
            return View();
        }

        public ActionResult list()
        {
            return View();
        }
    }
}