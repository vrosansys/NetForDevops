using System;

namespace WindowsFormsExample.Model
{
    public static class RandomExtension
    {
        private static string[] FirstNames;
        private static string[] LastNames;

        static RandomExtension()
        {
            FirstNames = new string[]
            {
                "Andrey", "Ivan", "Sergey", "Anna", "Olga", "Maria"
            };
            
            LastNames= new string[]
            {
                "Andrey", "Ivan", "Sergey", "Anna", "Olga", "Maria"
            };
        }

        public static Person NextPerson(this Random rand)
        {
            return new Person()
            {
                Name = rand.NextName(),
                Id = rand.Next(10000, 99999),
                Birthday = rand.NextBirthdy()
            };
        }

        public static Person[] NextPeople(this Random rand)
        {
            var people = new Person[rand.Next(5, 25)];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = rand.NextPerson();
            }

            return people;
        }

        public static string NextName(this Random rand)
        {
            var firstName = FirstNames[rand.Next(0, FirstNames.Length)];
            var lastName = FirstNames[rand.Next(0, LastNames.Length)];
            return $"{firstName} {lastName}";
        }

        public static DateTime NextBirthdy(this Random rand)
        {
            return new DateTime(
                rand.Next(1950, 2020),
                rand.Next(1,12),
                rand.Next(1,27));
        }
    }
}