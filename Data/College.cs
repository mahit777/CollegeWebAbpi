namespace CollegeWebAbpi
{
    public class College
    {
  
            public string Name { get; set; }
            public int Id { get; set; }
            public string Address { get; set; }
            public ICollection<Department> Departments { get; set; }
    
    }


}
