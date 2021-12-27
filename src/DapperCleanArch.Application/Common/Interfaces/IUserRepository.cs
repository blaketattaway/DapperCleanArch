using DapperCleanArch.Domain.Entities;

namespace DapperCleanArch.Application.Common.Interfaces
{
    public interface IUserRepository
    {
        public Task<EntUser> GetUserByName(EntUser user);
    }
}
