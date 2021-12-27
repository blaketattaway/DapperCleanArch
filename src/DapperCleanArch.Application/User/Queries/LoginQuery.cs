using DapperCleanArch.Application.Common.Exceptions;
using DapperCleanArch.Application.Common.Interfaces;
using DapperCleanArch.Domain.Entities;
using MediatR;
using System.Net;

namespace DapperCleanArch.Application.User.Queries
{
    public class LoginQuery : IRequest<EntToken>
    {
        public LoginQuery(EntUser user)
        {
            User = user;
        }

        public EntUser User { get; set; }
    }

    public class LoginQueryHandler : IRequestHandler<LoginQuery, EntToken>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITokenService _tokenService;

        public LoginQueryHandler(IUnitOfWork unitOfWork, ITokenService tokenService)
        {
            _unitOfWork = unitOfWork;
            _tokenService = tokenService;
        }

        public async Task<EntToken> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.User.User) || string.IsNullOrEmpty(request.User.Password))
                throw new DapperCleanArchException("Your request has not parameters", HttpStatusCode.BadRequest);

            //We check if the user exists on our db

            var user = await _unitOfWork.UserRepository
               .GetUserByName(request.User);

            if (user is null)
                throw new DapperCleanArchException("User not found", HttpStatusCode.NotFound);

            _unitOfWork.Commit();

            return _tokenService.Generate(request.User);
        }

    }
}
