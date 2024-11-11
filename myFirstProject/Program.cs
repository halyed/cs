// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("What is your name : ");
var name = Console.ReadLine();
var curDate = DateTime.Now;

Console.WriteLine($"{Environment.NewLine} Hello, {name}, we are on {curDate}");
