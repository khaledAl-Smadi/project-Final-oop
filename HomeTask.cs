using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Final_oop
{
    public class HomeTask:TaskApp
    {
        public string Room { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" Room={Room}";
        }
    }
}
