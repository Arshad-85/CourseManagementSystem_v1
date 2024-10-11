using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class OnPremisCourse : Course
    {

        public string Schedule { get; set; }
        public int ClassroomCapacity { get; set; }

        public OnPremisCourse(string courseId, string title, string duration, decimal price, string schedule, int classroomcapacity) : base(courseId, title, duration, price)
        {
            Schedule = Schedule;
            ClassroomCapacity = classroomcapacity;
        }

        public string DisplayOnPremisCourseInfo()
        {
            return base.ToString() + $"ID: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price}";

        }
    }
}
