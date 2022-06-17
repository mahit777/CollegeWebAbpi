using CollegeWebAbpi.Data;
using Microsoft.EntityFrameworkCore;

namespace CollegeWebAbpi.Services
{
    public class CollegeService : ICollegeService
    {
        public readonly DbSet<College> colleges;
        public CollegeService(CollegeContext collegeContext) {
            colleges = collegeContext.Colleges;
        }
        public IEnumerable<College> GetAllColleges()
        {
            return colleges.ToList();
        }
    }
}
