using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstProject.src
{
    public class Employee
    {
        private string firsrName;
        private string secondName;
        private int age;
        private string wage;


        public Employee(string name1, string name2, int number, string toInsert){
            this.firsrName = name1;
            this.secondName = name2;
            this.age = number;
            this.wage = toInsert;
        }

        public string FirsrName { get => firsrName; set => firsrName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public int Age { get => age; set => age = value; }
        public string Wage { get => wage; set => wage = value; }
    }
}