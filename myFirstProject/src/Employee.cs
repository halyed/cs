using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using static myFirstProject.src.Syntax;

namespace myFirstProject.src
{
    public class Employee
    {
        private string firsrName;
        private string secondName;
        private int age;
        private string wage;
    
        string typeOfEmployee;


        public Employee(string name1, string name2, int number, string toInsert){
            this.firsrName = name1;
            this.secondName = name2;
            this.age = number;
            this.wage = toInsert;
            this.TypeOfEmployee = Syntax.employeeType.Developper.ToString();
        }

        

        /*public static void updateEmployee(string variableToUpdate, string toUpdate, Employee employee){
            if(variableToUpdate.equalsTo("firstname")) employee.firstname = toUpdate;
            if(variableToUpdate.equalsTo("lastname")) employee.firstname = toUpdate;
            if(variableToUpdate.equalsTo("age")) {   
                int ageParsed;
                if(int.TryParse(toUpdate, out parsed))
                    employee.age = ageParsed
                else Console.WriteLine("Parsing error"); 
            }
            if(variableToUpdate.equalsTo("wage")) employee.wage = toUpdate;
        }*/

        public string FirsrName { get => firsrName; set => firsrName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public int Age { get => age; set => age = value; }
        public string Wage { get => wage; set => wage = value; }
        public string TypeOfEmployee { get => typeOfEmployee; set => typeOfEmployee = value; }
    }
}