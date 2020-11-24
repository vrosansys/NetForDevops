namespace task3
{
    public abstract class Worker : IWorker
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        public abstract string Action();
        
        public virtual string DoWork()
        {
            return $"Name: {Name},{Action()}";
        }
        
        #region Constructors
        
        public Worker() 
        {
        }
        
        public Worker(string id, string name)
        {
            Id = id;
            Name = name;
        }
        
        public Worker(Worker other)
        {
            if(other == null)
                return;
            Id = other.Id;
            Name = other.Name;
        }
        
        #endregion
        
    }
}