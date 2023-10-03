namespace todolist
{
    public class todoTask
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string status { get; set; }  // todo, process, done
    }
}
