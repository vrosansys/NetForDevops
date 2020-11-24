namespace task3
{
    public class QA : Worker, IWorker
    {
        public bool Automation { get; set; }
        
        public override string Action()
        {
            return Automation ?
                "Automation and Manual Testing": 
                "Manual Testing";
        }

        public override string DoWork()
        {
            return $"ID: {Id} {base.DoWork()}";
        }
    }
}