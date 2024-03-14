using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    class ClassStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set;}

        public int Age { get; set; }
        public string Phone { get; set; }
        public double Scholarship { get; set; }

        public ClassStudent() 
        {
            Id= 0;
            Name = string.Empty;
            LastName = string.Empty;
            Age = 0;
            Phone = string.Empty;
            Scholarship = 0;
        }
        public ClassStudent(int id, string lastname, string name, int age, string phone, double scholarship)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            Age = age;
            Phone = phone;
            Scholarship = scholarship;
        }
    }
}
