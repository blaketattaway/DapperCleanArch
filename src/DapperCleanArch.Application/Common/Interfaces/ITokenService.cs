using DapperCleanArch.Domain.Entities;

namespace DapperCleanArch.Application.Common.Interfaces
{
    public interface ITokenService
    {
        public EntToken Generate(EntUser user);
    }
}
