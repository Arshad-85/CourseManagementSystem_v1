using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class DigitalCourse : Course
    {

        public string CourseLink { get; set; }
        public int FileSize { get; set; }

        public DigitalCourse(string courseId, string title, string duration, decimal price, string courselink, int filesize) : base(courseId, title, duration, price)
        {
            CourseLink = courselink;
            FileSize = filesize;
        }


        public string DisplayDigitalCourseInfo()
        {
            return base.ToString() + $"ID: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price}";

        }
    }
}
