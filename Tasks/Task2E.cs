using System;

namespace NetforDevOps
{
    public class Task2E
    {
        public static int Method()
        {
            var rand = new Random();
            var arr = new int[20];
            var index = rand.Next(-20,20);
            int result;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            try
            {
                Console.WriteLine($"Index is: {index} and value is {arr[index]}");
                return arr[index];
                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Error Index: {index} in Array is out of range, generate new index");
                for (int i = 0; index < 0; i++)
                {
                    index = rand.Next(-20,20);
                    Console.WriteLine($"New index is: {index}");
                }
                Console.WriteLine($"Value of {index} is:");
                return arr[index];
            }
            
        }
    }
}