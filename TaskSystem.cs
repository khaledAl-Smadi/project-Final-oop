using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Final_oop
{
    public class TaskSystem
    {
        public List<User> Users { get; set; }
        public void AddUser(User user)
        {
            if (Users == null)
            {
                Users = new List<User>();
            }
            Users.Add(user);
        }
    }
}
