using HR_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyProfileController : ControllerBase
    {
        private readonly ILogger _logger;
        public CompanyProfileController(ILogger<CompanyProfile> logger)
        {
            _logger = logger;
        }
    }
}
