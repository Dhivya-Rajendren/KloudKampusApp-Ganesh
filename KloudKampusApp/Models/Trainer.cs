using System.ComponentModel.DataAnnotations;

namespace KloudKampusApp.Models
{
    public class Trainer
    {
        [Required]
        public int TrainerId { get; set; }
        [Required]// For Mandatory
        [MinLength(3)]
        public string TrainerName { get; set; }
        public int YearsOfExperience { get; set; }
        [Required]
        public string Skills { get; set; }

        public string TrainerImg { get; set; }
    }
}
