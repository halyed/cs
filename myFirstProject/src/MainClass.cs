using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstProject.src
{
    public class MainClass
    {
        public static void Main(){
            Console.WriteLine("Hello world");
            //Console.Write("What is your name : ");
            //var name = Console.ReadLine();
            //var curDate = DateTime.Now;

            /*Console.WriteLine($"{Environment.NewLine} Hello, {name}, we are on {curDate}");
            Console.WriteLine($"{Environment.NewLine} Hello, " + name + ", we are on {curDate}");
            Console.Write("Teslicapota");*/

            int result = setVars(4, 5);
            Console.WriteLine(result);
            printVarsTypes();
            
        }

        public static int setVars(int a, int b){
            return a + b;
        }


        public static void printVarsTypes(){
            string name = "Hamouda";
            int monthlyWage = 34776;
            bool isActive = false;
            double rating = 99.50;
            float ratingFloat = 99.50f;
            byte numberOfEmployees = 255; // limited to 255

            Console.WriteLine(name, monthlyWage, isActive, rating, ratingFloat, numberOfEmployees);

        }
    }





}