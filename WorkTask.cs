using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Final_oop
{
    public class WorkTask : TaskApp
    {
        public string Company { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" Company={Company}";
        }
    }
}
