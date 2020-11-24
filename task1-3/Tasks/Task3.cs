using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Security.AccessControl;

namespace NetforDevOps
{
    public interface IWorker
    {
    string DoWork();
    }

    public class Task3
    {
        public abstract class Worker : IWorker
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public abstract string Action();

            #region Constructors
            public Worker(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public Worker()
            {
            }

            public Worker(Worker other)
            {
                if(other == null)
                    return;
                Id = other.Id;
                Name = other.Name;
            }

            public string DoWork()
            {
                return $"Name: {Name},{Action()}";
            }

            #endregion

        }
        
        public class QA : Worker, IWorker
        {
            public bool Automation { get; set; }

            public override string Action()
            {
                if (Automation == true)
                    return "Automation and Manual Testing";
                return "Manual Testing";
            }

            public new string DoWork()
            {
                return $"ID: {Id} Name: {Name},{Action()}";
            }

        }

        public class Developer : Worker, IWorker
        {
            public bool Unity { get; set; }
            public bool JS { get; set; }
            public bool SQL { get; set; }

            public override string Action()
            {
                if (Unity)
                {
                    if (SQL)
                    {
                        if (JS)
                        {
                            return "Full Stack Development"; 
                        }
                        return "Development with Unity and Databases";
                    }
                    return "Development with Unity";
                }
                if (JS)
                {
                    if (SQL)
                    {
                        return "Front-end Development";
                    }
                    return "JS Development";
                }
                return "DB Engineering";
            }
            public new string DoWork()
            {
                return $"ID: {Id} Name: {Name},{Action()}";
            }
        }

        public static class SetRandom
        {
            private static string[] Names;
            static SetRandom()
            {
                Names = new string[] {
                    "Ivan", "Oleg", "Andrey", "Sergey", "Aleksandr", "Vitaliy"
                }; 
            }
            
            public static Worker NextWorker(Random rnd)
            {
                Worker result = null;
                if (rnd.Next(0, 1000) >= 500)
                {
                    result = new Developer()
                    {
                        Name = Names[rnd.Next(0, Names.Length)],
                        Id = rnd.Next(1, 90)
                    };
                }
                else
                {
                    result = new QA()
                    {
                        Name = Names[rnd.Next(0, Names.Length)],
                        Id = rnd.Next(1, 90)
                    };
                }
                return result;
            }
        }
        
        public class Team: IWorker
        {
            private const int NumEmployers = 5;

            public static Worker[] Employers;
            
            public int Size => Employers.Length;

            public Team()
            {
                Employers = new Worker[Team.NumEmployers];
            }

            public new string DoWork()
            {
                for (int i = 0; i < NumEmployers; i++)
                {
                    Employers[i] = SetRandom.NextWorker();
                    return $"{Employers[0].Id}: {Employers[0].Name}";
                }
                return "";
            }

        }
    }
        

}
    