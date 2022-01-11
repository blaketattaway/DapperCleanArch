using DapperCleanArch.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperCleanArch.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [HttpPost("")]
        public IActionResult Company(EntCompanyForm company)
        {
            return Ok();
        }
    }
}
