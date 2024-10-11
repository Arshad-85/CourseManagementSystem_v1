using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class CourseManager
    {
        public List<Course> courses = new List<Course>();

        public void CreateCourse(string courseId, string title, string duration, decimal price)
        {
            var newObj = new Course(courseId,title, duration, price);

            courses.Add(newObj);
            Console.WriteLine("Course created sucessfully");
        }

        public void ReadCourse()
        {
            if(courses.Count > 0)
            {
                foreach (var course in courses)
                {
                    Console.WriteLine($"CourseId:{course.CourseId} Title:{course.Title} Duration: {course.Duration} Price: {course.Price}");
                }
            }
        }

        public void UpdateCourse(string id, string title, string duration, decimal price)
        {
            var updateid = courses.Find(c => c.CourseId == id);

            if (updateid != null)
            {
                updateid.Title = title;
                updateid.Duration = duration;
                updateid.Price = price;
            }
            else
            {
                Console.WriteLine("Course id not found...");
            }
        }

        public void DeleteCourse(string id)
        {
            var updateid = courses.Find(c => c.CourseId == id);

            if (updateid != null)
            {
                courses.Remove(updateid);
                Console.WriteLine("Course deleted successfully...");
            }
            else
            {
                Console.WriteLine("Course id not found...");
            }
        }

        public decimal ValidateCoursePrice(decimal price)
        {
            decimal price;
            do
            {
                Console.WriteLine("Enter the Price");
                decimal price = decimal.Parse(Console.ReadLine());
                if (price <= 0)
                {
                    Console.WriteLine("Price should be positive values....!!");
                }
            }
            while (price <= 0);
            return price;

        }

    }
}
