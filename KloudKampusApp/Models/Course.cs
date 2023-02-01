namespace KloudKampusApp.Models
{
    public class Course
    {
        //property in C# 

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Category { get; set; }

        public string CourseImg { get; set; }

        public int Price { get; set; }


        public int F1()
        {
            return 0;
        }
    }
}
