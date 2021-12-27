using System.Data;

namespace DapperCleanArch.Infrastructure.Repositories
{
    public abstract class GenericRepository
    {
        private protected readonly IDbTransaction _dbTransaction;
        private protected readonly IDbConnection _dbConnection;

        public GenericRepository(IDbTransaction dbTransaction)
        {
            _dbTransaction = dbTransaction;
            _dbConnection = dbTransaction.Connection!;
        }
    }
}
