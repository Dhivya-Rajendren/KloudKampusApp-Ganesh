using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using KloudKampusApp.Models;

namespace KloudKampusApp.Controllers
{
    public class TrainersController : Controller
    {
        private static List<Trainer> trainers = new List<Trainer>();

        public IActionResult Index()
        {
            DBHelper db = new DBHelper();
            trainers = db.GetTrainers();


            return View(trainers);

            
        }

        public IActionResult GetTrainerDetail(int TrainerId)
        {

            Trainer trainer = new Trainer();

            foreach (Trainer item in trainers)
            {
                if(item.TrainerId==TrainerId)
                {
                    trainer = item;
                }
            }
            return View(trainer);
        }
  
        public IActionResult AddNewTrainer()
        {
            return View();
        }
    
        [HttpPost]
        public IActionResult AddNewTrainer(Trainer trainer)
        {
            DBHelper db = new DBHelper();
            db.AddNewTrainer(trainer);

           
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTrainer(int trainerId)
        {
            Trainer trainer = new Trainer();

            foreach (Trainer item in trainers)
            {
                if (item.TrainerId == trainerId)
                {
                    trainer = item;
                }
            }
            return View(trainer);
        }
    
        public IActionResult ConfirmDelete(int trainerId)
        {
            DBHelper repo = new DBHelper();
            repo.DeleteTrainer(trainerId);
            return RedirectToAction("Index");
        }
    }
}

