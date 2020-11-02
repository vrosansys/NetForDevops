using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
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

        public class Random : Worker, IWorker
        {

            public static string SetRandom()
            {
                var FamalyName = new List<string>();
                FamalyName.Add("Sidorov Vanya");
                FamalyName.Add("Naumenko Petya");
                FamalyName.Add("Sunstar Margolotta");
                FamalyName.Add("Gerard Maaka");
                FamalyName.Add("Saltzman Montoya");
                
                var randId = new System.Random();
                
                var dev = new Developer();
                dev.Name = FamalyName[randId.Next(maxValue: 4)];
                dev.Id = randId.Next(maxValue: 999);
                dev.Unity= randId.Next(0, 2) > 0;
                dev.JS= randId.Next(0, 2) > 0;
                dev.SQL= randId.Next(0, 2) > 0;
                
                var qa = new QA();
                qa.Name = FamalyName[randId.Next(maxValue: 4)];
                qa.Id = randId.Next(maxValue: 999);
                qa.Automation = randId.Next(0, 2) > 0;
                
                return $"{dev.DoWork()}\n{qa.DoWork()}";
            }

            public override string Action()
            {
                
                return SetRandom();;
            }
            public new string DoWork()
            {
                return $"Random of Developer and Qa is: \n{Action()}";
            }

        }
        
        public class Team : Worker, IWorker
        {
            public Worker[] Employers;

            public override string Action()
            {
                return "Manual Testing";
            }

            public new string DoWork()
            {
                return $"ID: {Id} Name: {Name},{Action()}";
            }

        }
    }
        

}
    