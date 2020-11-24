namespace task3
{
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
            return $"ID: {Id} {base.DoWork()}";
        }
    }
}