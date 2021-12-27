using DapperCleanArch.Application.User.Queries;
using DapperCleanArch.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DapperCleanArch.WebAPI.Controllers
{
    public class UserController : DapperCleanArchController
    {
        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login(EntUser user)
        {
            return Ok(await Mediator.Send(new LoginQuery(user)));
        }
    }
}
