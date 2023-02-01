using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using KloudKampusApp.Models;

namespace KloudKampusApp.Controllers
{
    public class TrainersController : Controller
    {
        public IActionResult Index()
        {
            Trainer dhivya = new Trainer();//Creating an object 
            dhivya.TrainerName = "Dhivya Rajendren";
            dhivya.TrainerId = 1;
            dhivya.Skills = "Sql, Angular,EF Core, ASP .NET Core";
            dhivya.YearsOfExperience = 10;
            dhivya.TrainerImg = "/images/dhivya.png";

            List<Trainer> trainers = new List<Trainer>();
            trainers.Add(dhivya);

            Trainer aabha = new Trainer();
            aabha.TrainerName = "Aabha Bhusan";
            aabha.TrainerId = 2;
            aabha.Skills = "Java,AWS";
            aabha.YearsOfExperience = 12;
            aabha.TrainerImg = "/images/Aabha.png";

            trainers.Add(aabha);

            string name = "Dhivya";
            //Pass the data from a controller to view 
            // ViewBag
            //ViewData
            //TempData
            //Models


            List<string> names = new List<string>();
            names.Add("Dhivya");
            names.Add("Aabha");
            names.Add("geetha");

            ViewBag.Names = names;

            ViewData["Name"] = name;

            ViewData["Names"] = names;
            TempData["Names"] = names;

            ViewData["Trainers"] = trainers;


            return View();

            
        }
    }
}


//class a extends b-->inheritance 

//    class a:b -->inheritance 