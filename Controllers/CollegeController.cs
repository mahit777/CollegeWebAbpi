using CollegeWebAbpi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CollegeWebAbpi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CollageController : ControllerBase
    {
       

        private readonly ILogger<CollageController> _logger;
        private readonly ICollegeService _collegeService;
        public CollageController(ILogger<CollageController> logger,ICollegeService collegeService)
        {
            _logger = logger;
            _collegeService = collegeService;
        }

        [HttpGet(Name = "Colleges")]
        public IEnumerable<College> Get()
        {

            return _collegeService.GetAllColleges();
        }
    }
}