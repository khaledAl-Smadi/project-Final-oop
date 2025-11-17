using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Final_oop
{
    public class StudyTask: TaskApp
    {
        public string Subject { get; set; }
        public override string ToString()
        {
            return base.ToString() + $" Subject{Subject}";
        }
    }
}
