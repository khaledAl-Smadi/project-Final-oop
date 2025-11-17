using System;
using System.Collections.Generic;
using System.Linq;

namespace project_Final_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // إنشاء النظام
            TaskSystem system = new TaskSystem();

            // إنشاء مستخدم
            User user1 = new User
            {
                Id = 1,
                Name = "Khaled",
                Email = "khaled@test.com"
            };

            system.AddUser(user1);

            // إنشاء المهام من جميع الأنواع
            HomeTask homeTask = new HomeTask
            {
                Title = "Clean Room",
                Description = "Vacuum and dust",
                Room = "Bedroom",
                DueDate = DateTime.Now.AddDays(2)
            };

            WorkTask workTask = new WorkTask
            {
                Title = "Finish Report",
                Description = "Monthly analysis",
                Company = "TechLine",
                DueDate = DateTime.Now.AddDays(1)
            };

            StudyTask studyTask = new StudyTask
            {
                Title = "Study ASP.NET",
                Description = "Learn controllers",
                Subject = "Programming",
                DueDate = DateTime.Now.AddDays(3)
            };

            // إضافة المهام للمستخدم
            user1.AddUserTask(homeTask);
            user1.AddUserTask(workTask);
            user1.AddUserTask(studyTask);

            // ===========================================
            // ⿡ عرض جميع المهام (Polymorphism)
            Console.WriteLine("=== All Tasks ===");
            user1.ListAllTasks();

            // ===========================================
            // ⿢ تجربة MarkAsDone
            Console.WriteLine("\n=== Mark Home Task as Done ===");
            Console.WriteLine(homeTask.MarkAsDone());
            Console.WriteLine(homeTask.ToString());

            // ===========================================
            // ⿣ جلب المهام النشطة (غير Done)
            Console.WriteLine("\n=== Active Tasks ===");
            var activeTasks = user1.GetActiveTasks();
            foreach (var t in activeTasks)
            {
                Console.WriteLine(t.ToString());
            }

            // ===========================================
            // ⿤ حذف مهمة
            Console.WriteLine("\n=== Remove Work Task ===");
            user1.RemoveUserTask(workTask.Id);

            // عرض المهام بعد الحذف
            Console.WriteLine("\n=== Tasks After Removal ===");
            user1.ListAllTasks();

            Console.ReadLine();
        }
    }
}