using System.Data.SqlClient;
using System.Collections.Generic;

namespace KloudKampusApp.Models
{
    public class DBHelper
    {

        // ADO .Net Code
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public List<Trainer> GetTrainers()
        {
            List<Trainer> trainers = new List<Trainer>();

            string conString = "Server=(localdb)\\MSSQLLocaldb;Database=KloudKampusDB;integrated security=true";
            con = new SqlConnection(conString);
            con.Open();
            com = new SqlCommand("Select * from tbl_Trainers", con);
            reader = com.ExecuteReader();
            while(reader.Read())
            {
                Trainer trainer = new Trainer();
                trainer.TrainerId = reader.GetInt32(0);//First column
                trainer.TrainerName = reader.GetString(1);
                trainer.YearsOfExperience = reader.GetInt32(2);
                trainer.Skills = reader.GetString(3);
                trainer.TrainerImg = reader.GetString(4);

                trainers.Add(trainer);
            }
            reader.Close();
            con.Close();

            return trainers;

        }

        public void AddNewTrainer(Trainer trainer)
        {
            string conString = "Server=(localdb)\\MSSQLLocaldb;Database=KloudKampusDB;integrated security=true";
            con = new SqlConnection(conString);
            con.Open();
            com = new SqlCommand("insert into tbl_trainers values(" + trainer.TrainerId + ",'" + trainer.TrainerName + "'," + trainer.YearsOfExperience + ",'" + trainer.Skills + "','" + trainer.TrainerImg + "')", con);
            com.ExecuteNonQuery();
        }

        public void DeleteTrainer(int trainerId)
        {
            string conString = "Server=(localdb)\\MSSQLLocaldb;Database=KloudKampusDB;integrated security=true";
            con = new SqlConnection(conString);
            con.Open();
            com = new SqlCommand("Delete from tbl_trainers where trainerid=" + trainerId, con);
            com.ExecuteNonQuery();
        }
    }
}




