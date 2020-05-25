﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var course = new Course() { Id=1,Name="Asp.Net Core 2 Kursu" };

            return View(course);
        }
    }
}