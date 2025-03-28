using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public Student(int id, string name, string surname, decimal point)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _point = point;
        }

        public int _id { get; set; }
        public string _name { get; set; }
        public string _surname { get; set; }
        public decimal _point { get; set; }

        public void StudentInfo()
        {
            Console.WriteLine($"{_id}. {_name} {_surname}. Point : {_point}");
        }
    }
}
