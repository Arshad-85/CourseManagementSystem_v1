using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Course
    {
        private int CourseId { get; set; }
        private string Title { get; set; }
        private string Duration { get; set; }
        private decimal Price { get; set; }

        private Course(int courseId, string title, string duration, decimal price)
        {
            this.CourseId = courseId;
            this.Title = title;
            this.Duration = duration;
            this.Price = price;
        }

        public override string ToString()
        {
            return base.ToString() + $"ID: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price}";
        }
    }
}
