using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;

namespace NetforDevOps
{
    public class Task2B
    {
        public static void First()
        {    
            var rand = new Random();
            var arr = new int [8];
            foreach (var item in arr)
            {
                arr[item] = rand.Next(100);
                Console.Write(arr[item] + "\t");
            }
            
        }

        public static void Second(int [] arr)
        {
            var min = arr[0];
            var max = arr[0];
            var indexmin = 0;
            var indexmax = 0;
            var avarage = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    indexmin = i;
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                    indexmax = i;
                }
                avarage += arr[i];
            }
            Console.WriteLine($"Minimal is:{min}, index is {indexmin}");
            Console.WriteLine($"Maximum is:{max}, index is {indexmax}");
            Console.WriteLine(avarage / arr.Length);
        }

        public static void SortArray(int[] arr,string Method)
        {
            int tmp;
            switch (Method)
            {
                case "Ascending":
                    for (int i = 0; i < arr.Length-1; i++)
                    {
                        for (int j = i+1; j < arr.Length; j++)
                        {
                            if (arr[i] > arr[j])
                            {
                                tmp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = tmp;
                            }
                        }
                    }
                    break;
                case "Descending":
                    for (int i = 0; i < arr.Length-1; i++)
                    {
                        for (int j = i+1; j < arr.Length; j++)
                        {
                            if (arr[i] < arr[j])
                            {
                                tmp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = tmp;
                            }
                        }
                    }
                    break;
                    
            }
            Console.WriteLine("Array is sorted:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            
        }

        public static void merger(int[] arr1,int[] arr2, int index)
        {
            
        }
    }
    
}