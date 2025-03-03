using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstProject.src
{
    public class Employee
    {
        string firsrName;
        string secondName;
        int age;
        string wage;


        public Employee(string name1, string name2, int number, string toInsert){
            this.firsrName = name1;
            this.secondName = name2;
            this.age = number;
            this.wage = toInsert;
        }


    }
}