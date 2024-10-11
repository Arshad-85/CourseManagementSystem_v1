using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courseManager = new CourseManager();
            bool exist = true;

            while (exist)
            {
                Console.Clear();
                Console.WriteLine("Course Management System:");
                Console.WriteLine("1. Add a Course:");
                Console.WriteLine("2. View All Courses:");
                Console.WriteLine("3. Update a Course:");
                Console.WriteLine("4. Delete a Course:");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option:");

                var option = Console.ReadLine();

                switch(option)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Enter Course ID : ");
                        var id = Console.ReadLine();
                        Console.Write("Enter the Title: ");
                        var title = Console.ReadLine();
                        Console.Write("Enter the Duration: ");
                        var duration = Console.ReadLine();
                        Console.Write("Enter the Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());

                        courseManager.CreateCourse(id,title,duration,price);
                    break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("-----List All Courses-----\n");
                        courseManager.ReadCourse();
                    break;

                    case "3":
                        Console.Clear();
                        Console.Write("Enter the Course ID to update: ");
                        var updateId = Console.ReadLine();
                        Console.Write("Enter new Title: ");
                        var newtitle = Console.ReadLine();
                        Console.Write("Enter new Duration: ");
                        var newDuration = Console.ReadLine();
                        Console.Write("Enter new Price: ");
                        decimal newupdateprice = decimal.Parse(Console.ReadLine());

                        courseManager.UpdateCourse(updateId,newtitle, newDuration, newupdateprice);
                    break;

                    case "4":
                        Console.Clear();
                        Console.Write("Enter the Course ID to delete: ");
                        var deleteId = Console.ReadLine();
                        
                        courseManager.DeleteCourse(deleteId);
                    break;

                    case "5":
                        Console.Clear();
                        exist = false;
                        Console.ReadLine();
                    break;

                    default:
                        Console.WriteLine("Invalid option...\n");
                    break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
    }
}
