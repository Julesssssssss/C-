using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public double Tax { get; set; }

        public User(int ID, string FirstName, string LastName, int Age, int Salary, int Tax)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Salary = Salary;
            this.Tax = Tax;
        }
    }
}
