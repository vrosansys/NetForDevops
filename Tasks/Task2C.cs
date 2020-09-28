using System;
using System.Runtime.InteropServices;
using static NetforDevOps.Task2C.Level;

namespace NetforDevOps
{
    public class Task2C
    {
        public enum Level
        {
            Junior = 60,
            Middle = 35,
            Senior = 15,
        }

        public static bool Task(int tasks, int estimateTime, out int timeForTask, Level level)
        {
            timeForTask = 0;
            switch (level)
            {
                case Junior:
                    timeForTask = tasks * (int) Junior;
                    if (timeForTask > estimateTime)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case Middle:
                    timeForTask = tasks * (int) Middle;
                    if (timeForTask > estimateTime)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case Senior:
                    timeForTask = tasks * (int) Senior;
                    if (timeForTask > estimateTime)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                default: return false;
            }
            
        }
    }
}