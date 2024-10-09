using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement
{
    public class Course
    {
        public int CourseID { get; set; }  
        public string Title { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }

        public Course(int courseID, string title, string duration, decimal price)
        {
            CourseID = courseID;
            Title = title;
            Duration = duration;
            Price = price;
        }

        public string DisplayCourseInfo()
        {
            return $"Id:{CourseID},Title:{Title},Duration:{Duration},Price:{Price}";
        }
        public override string ToString()
        {
            return DisplayCourseInfo();
        }
    }
}
