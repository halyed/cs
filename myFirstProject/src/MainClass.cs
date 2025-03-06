using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace myFirstProject.src
{
    public class MainClass
    {
        const String country = "FRANCE";
        public static void Main(){
            Console.WriteLine("Hello world");
            //Console.Write("What is your name : ");
            //var name = Console.ReadLine();
            //var curDate = DateTime.Now;

            /*Console.WriteLine($"{Environment.NewLine} Hello, {name}, we are on {curDate}");
            Console.WriteLine($"{Environment.NewLine} Hello, " + name + ", we are on {curDate}");
            Console.Write("Teslicapota");*/

            int result = Syntax.setVars(4, 5);
            Console.WriteLine(result);
            Syntax.printVarsTypes();
            Syntax.usingOperators(0, 0);
            Syntax.printDate();
            String type = "switch";
            Syntax.isGreaterThanTwo(1,type);
            int facto = Syntax.usingIterationForFactoriel(5, "for");
            Console.WriteLine("result of factoriel : " + facto);
            // calling the optional method
            int sumOf = Syntax.sumWithOptional(3,5);
            Console.WriteLine("result of first sumOf : " + sumOf);
            int sumOf2 = Syntax.sumWithOptional(4,5,11);
            Console.WriteLine("result of second sumOf : " +sumOf2);
            // using named parameters
            int sumOf3 = Syntax.sumWithOptional(a:4,b:5,c:21);
            Console.WriteLine("result of third sumOf : " +sumOf3);
            // using expression bodied method
            int result2 = Syntax.expressionMethodSumWithOptional(20, 20, 20);
            Console.WriteLine($"result of sum with expression bodied method : {result2}");
            // ignoring backslash in file name and escaping character
            Syntax.ignoringBackslash();
            // comapring string
            Syntax.comparingString();
            // parsing string to bool
            string isFalse = "trueii";
            bool.TryParse(isFalse, out bool parsedString);
            Console.WriteLine("the result of parsed string in bool is : " + parsedString);


            Employee employee = new Employee("Hamouda", "SABOU", 31, "45k");
            string employeeInfo = employee.ToString();
            Console.WriteLine($"The employee informations are : {employee.SecondName}");

            
        }

        


    }





}