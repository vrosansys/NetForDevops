using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace NetforDevOps
{
    public class ProgramTest
    {
        public static void First(int num1, int num2, string str)
        {
            switch (str)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("Filed, you need input +-*/ ");
                    break;
            }
        }

        public static double Second(ref int num1, ref int num2)
        {
            double result;
            if (num1 > num2)
            {
                result = num1 * num2;
                return result;
            }
            else if (num1 < num2)
            {
                result = num1 / num2;
                return result;
            }
            else
            {
                ++num1;
                ++num2;
                return (0);
            }
        }
    }
}