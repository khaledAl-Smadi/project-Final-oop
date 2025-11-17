using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Final_oop
{
    public class TaskApp
    {
        private static int Counter = 1;
        private string title { get; set; }
        public int Id { get; private set; }
        private DateTime? dueDate { get; set; }

        public string Title
        { 
            get 
            {
                return title;
            }
            set
            { 
                if(string.IsNullOrEmpty(value))
                {
                    title="No Title";
                }
                else
                {
                    title = value;
                }

            } 
        }

        public string Description { get; set; }
        public DateTime? DueDate 
        { 
            
            get
            {
                return dueDate;
            }
            set 
            { 
                if(value<DateTime.Now)
                {
                    dueDate=null;
                }
                else
                {
                    dueDate = value;
                }
            }
        }
       public enum status
        {
            Pending,
            InProgress,
            Done
        }
        public status Status { get; set; }=status.Pending;
        public TaskApp() 
        {
            this.Id =Counter ;
            Counter++;
        }

        public string MarkAsDone()
        {
            
            if (this.Status==status.Done)
            {
                return "Task is already marked as done.";
            }
            this.Status = status.Done;
            return "Task marked as done.";
        }
        public override string ToString()
        {
            return $"Task ID: {Id}, Title: {Title}, Description: {Description}, Due Date: {DueDate.Value.ToString("dd-MM-yyyy")}, Status: {Status}";
        }

    }
}
