namespace CollegeWebAbpi
{
    public class Department
    {
        
            public int Id { get; set; }
            public string Name { get; set; }
        public virtual College College { get; set; }


    }
}
