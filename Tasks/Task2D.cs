using System;
using System.Linq;

namespace NetforDevOps
{
    public class Input
    {
        public string Numbers { get; set; }

        public static int[] ToArray(string numbers)
        {
            string newStr = numbers;
            //newStr = newStr.Remove(newStr.Length - 1, 1);
            int[] arr = newStr.Split( ',',';',':').Select(int.Parse).ToArray();
            Console.WriteLine($"Array lenght is: {arr.Length} and elements is:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }
            return arr;
        }
    }

    public class Task2D
    {
        public static void ColsoleRead()
        {
            var date = new DateTime();
            date = DateTime.Now;
            Console.WriteLine($"Time is: {date.Hour}:{date.Minute}:{date.Second}");
            Console.WriteLine("Input numbers:");
            var line = new Input {Numbers = Console.ReadLine()};
            var result = Input.ToArray(line.Numbers);
            Array.Sort(result);
            Console.WriteLine($"Sorted array: {result[0]}");
        }
    }
}