﻿using System;
using System.Security.Cryptography;

namespace NetforDevOps
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var num1 = 10;
            var num2 = 5;
            var rand = new Random();
            int a = rand.Next(), b = rand.Next();
            string [] operators = {"+","/","*","-","error"};
            var index = rand.Next(operators.Length);

            ProgramTest.First(3,4,"*");
            
            Console.WriteLine($"Random is: {a},{b}");
            
            double result = ProgramTest.Second(ref num1,ref num2);
            Console.WriteLine($"Result of Second method is: {result}");
            Console.WriteLine($"Variable num1, num2 set to: {num1},{num2}");
            
            // Program third
            int result3 = (int)ProgramTest.Second(ref a,ref b);
            Console.WriteLine($"The result Second method of random numbers :{result3}");
            Console.WriteLine($"Operator is: {operators[index]} , result:");
            ProgramTest.First(result3,b,operators[index]);
        }

        public static void Task2B()
        {
            NetforDevOps.Task2B.Second(new int[]{10, 3, 50, 11, 9});
            NetforDevOps.Task2B.SortArray(new int[]{10, 3, 50, 11, 9},"Descending");
        }
    }
}