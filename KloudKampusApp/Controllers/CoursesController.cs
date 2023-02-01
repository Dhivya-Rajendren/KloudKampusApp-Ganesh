using Microsoft.AspNetCore.Mvc;

namespace KloudKampusApp.Controllers
{
    public class CoursesController : Controller
    {

        //Method - Action methods 
        public string Index()
        {
            return "All Courses";
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