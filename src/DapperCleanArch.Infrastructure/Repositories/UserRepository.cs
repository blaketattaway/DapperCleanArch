using Dapper;
using DapperCleanArch.Application.Common.Interfaces;
using DapperCleanArch.Domain.Entities;
using System.Data;
using System.Data.SqlClient;

namespace DapperCleanArch.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository, IUserRepository
    {
        public UserRepository(IDbTransaction dbTransaction)
            : base(dbTransaction) { }

        public async Task<EntUser> GetUserByName(EntUser user)
        {
            SqlParameter[] param = {
                new ("@pc_User", user.User)
            };
            var userFromDomainCommand = SQLHelper.GenerateCommand("[DBO].[Usp_User_SEL]", _dbTransaction, default, param);
            return (await _dbConnection.QueryAsync<EntUser>(userFromDomainCommand)).FirstOrDefault() ?? null!;
        }
    }
}
