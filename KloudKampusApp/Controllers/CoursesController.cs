using Microsoft.AspNetCore.Mvc;
using KloudKampusApp.Models;
using System.Collections.Generic;

namespace KloudKampusApp.Controllers
{
    public class CoursesController : Controller
    {

        //Method - Action methods 
        public IActionResult Index()
        {
            List<Course> courses = new List<Course>();

            Course course= new Course();
            course.CourseId = 1;
            course.CourseName = "ASP. Net Core MVC";
            course.Category = "Full Stack Development";
            course.CourseImg = "images/ASP.NET Core.png";
            course.Price = 12000;

            courses.Add(course);

            Course course2 = new Course();
            course2.CourseId = 2;
            course2.CourseName = "Entity Framework Core";
            course2.Category = "Full stack Development";
            course2.CourseImg = "images/efcore.png";
            course2.Price = 10000;

            courses.Add(course2);

            return View(courses);
        }

       
    }
}


/*  return type methodName(parameterList)
 *  {
 *  body 
 *  }
 *  
 *  //function -C language
 *  
 *  //Method - Java & C# 
 *  public int Add(int a, int b)
 *  {
 *  return a+b;
 *  }*/