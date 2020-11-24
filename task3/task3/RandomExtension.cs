using System;

namespace task3
{
    public static class RandomExtension
    {
        private static string[] Names;
        private static char[] Symbols;
        
        static RandomExtension()
        {
            Names = new string[] {
                "Ivan", "Oleg", "Andrey", "Sergey", "Aleksandr", "Vitaliy"
            };
            
            Symbols = new char[]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S',
                'T', 'U', 'V', 'W', 'Q'
            };
        }
        
        public static Worker NextWorker(this Random rnd)
        {
            Worker result = null;
            int probability = 50;
            if (rnd.Next(0, 1000) >= 500)
            {
                result = new Developer()
                {
                    Name = Names[rnd.Next(0, Names.Length)],
                    Id = Symbols[rnd.Next(0, Symbols.Length)].ToString(),
                    Unity = rnd.Next(100) < probability,
                    JS = rnd.Next(100) < probability,
                    SQL = rnd.Next(100) < probability,
                };
            }
            else
            {
                result = new QA()
                {
                    Name = Names[rnd.Next(0, Names.Length)],
                    Id = Symbols[rnd.Next(0, Symbols.Length)].ToString()
                };
            }
            return result;
        }
        
    }
}