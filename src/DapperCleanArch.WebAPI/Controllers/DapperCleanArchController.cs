using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DapperCleanArch.WebAPI.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class DapperCleanArchController : ControllerBase
    {
        private IMediator? _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>()!;

        private ClaimsIdentity? _identity;

        protected ClaimsIdentity Identity => _identity ??= (ClaimsIdentity)HttpContext.User.Identity!;

        protected string GetClaim(string claimName)
        {
            return Identity?.FindFirst(claimName)?.Value!;
        }
    }
}
