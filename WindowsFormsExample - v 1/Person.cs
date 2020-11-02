using System;
using System.Drawing;

namespace WindowsFormsExample
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime Birthday { get; set; }
        public Image Photo { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Name}, {Birthday:MM/dd/yyyy}";
        }
    }
}
