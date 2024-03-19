using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Krasivo
    {

        public string name {  get; set; }

        public string email { get; set; }

        public int age { get; set; }

        public string product { get; set; }

        public  Krasivo(Users user)
        {
            name = user.UserName;
            email = user.Email;
            age = (int) user.Age;
        }   
    }
}
