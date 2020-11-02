using System.Collections.Generic;

namespace WindowsFormsExample.Model
{
    public static class Storage
    {
        public static List<Person> People { get; private set; }

        static Storage()
        {
            People = new List<Person>();
        }

        public static void Add(Person person)
        {
            People.Add(person);
        }
        
        public static void RemoveByIndex(int index)
        {
            People.RemoveAt(index);
        }
        
        public static void EditByIndex(int index, Person person)
        {
            People[index] = person;
        }
    }
}