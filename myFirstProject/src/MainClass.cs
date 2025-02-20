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

            int result = setVars(4, 5);
            Console.WriteLine(result);
            printVarsTypes();
            usingOperators(0, 0);
            printDate();
            String type = "switch";
            isGreaterThanTwo(1,type);
            
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
            const double pi = 3.14;
            String s2 = String.Empty;

            Console.WriteLine(name + ", " + monthlyWage + ", " + isActive + ", " + rating + ", " + ratingFloat + ", " + numberOfEmployees + ", " + pi + ", " + s2);

        }

        public static void usingOperators(BigInteger a, BigInteger b){
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(float.MaxValue);
            char userSelection = 'a';
            char upperVersion = char.ToUpper(userSelection);
            Console.WriteLine(userSelection);
            bool isLetter = char.IsLetter(userSelection);
            Console.WriteLine(isLetter);

        }

        public static void printDate(){
            DateTime employeeStartDate = new DateTime(2025, 02, 17);
            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now;
            TimeSpan workTime = new TimeSpan(8, 0, 0);
            DateTime twoDaysLater = today.AddDays(2);
            DayOfWeek dayOfWeek = twoDaysLater.DayOfWeek;
            bool isDST = twoDaysLater.IsDaylightSavingTime();
            var monthlyWageOfHamouda = 3500;

            Console.WriteLine(employeeStartDate + ", " + today + ", " + now + ", " + ", " + workTime + ", " + twoDaysLater + ", " + dayOfWeek + ", " + isDST );
            

        }

        public static bool isGreaterThanTwo(int number, String operatorUsed){
            Console.WriteLine(operatorUsed);
            if(operatorUsed.Equals("bool")){
                Console.WriteLine("type used boolean");
                return number >=2;
            }else if(operatorUsed.Equals("switch")){
                Console.WriteLine("type used swicth");
                switch(number){
                    case < 2 : 
                        Console.WriteLine("number lower than two");
                        return false;
                    default:
                        Console.WriteLine("numbre greater than two");
                        return true;
                }
            }else{
                Console.WriteLine("type used if/else");
                if (number >= 2) return true;
                else return false;
            }
            
            
        }


    }





}