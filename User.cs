using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Final_oop
{
    public class User
    {
        private string email;
        private string name;
        public int Id { get; set; }
        public string Name 
        {
            get
            {
                return name;
            }
            set 
            {
                if (value.Length<3 || string.IsNullOrEmpty(value))
                {
                    name = "Invalid Name";
                }
                else
                {
                    name = value;
                    
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (!value.Contains("@")||string.IsNullOrEmpty(value))
                {
                    email = "Invalid Email";
                }
                else
                {
                    email = value;
                }
            }
        
        }
        public List<TaskApp> Tasks { get; set; }= new List<TaskApp>();

        //public void AddTask(TaskApp task)
        //{
        //    if (Tasks == null)
        //    {
        //        Tasks = new List<TaskApp>();
        //    }
        //    Tasks.Add(task);
        //}
        public void ListAllTasks()
        {
            if (Tasks == null || Tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }
            foreach (var task in Tasks)
            {
                Console.WriteLine($"Task ID: {task.Id}, Title: {task.Title}, Description: {task.Description}, Due Date: {task.DueDate.Value.ToString("dd-MM-yyyy")}, Status: {task.Status}");
            }
        }

      
        public void AddUserTask(TaskApp task)
        {
            Tasks.Add(task);
        }
        public void RemoveUserTask(int taskId)
        {
            var taskToRemove = Tasks.FirstOrDefault(t => t.Id == taskId);
            if (taskToRemove != null)
            {
                Tasks.Remove(taskToRemove);
            }
        }
        
        public List<TaskApp> GetActiveTasks()
        {
            return Tasks.Where(t => t.Status != TaskApp.status.Done).ToList();
        }

    }
}
