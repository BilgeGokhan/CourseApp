using System;
using System.Collections.Generic;
using System.Linq;
using CourseApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Web.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour > 12 ? "Good Afternoon" : "Good Morning";

            return View("MyView");
        }

        public ViewResult List()
        {
            var studentList = Repository.Students.Where(x => x.WillAttend == true);
            return View(studentList);
        }

        public ViewResult Apply()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Apply(Student student)
        {
            //Model Binding --> Student modeli view den doldurulup birebir eşleniyor. 

            //Student verisini işle (Veritabanına kayıt et vs...)

            if (!ModelState.IsValid)
            {
                return View();
            }

            Repository.AddStudent(student);

            return View("Thanks",student);
        }
    }
} 