using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DapperCleanArch.Infrastructure
{
    internal class SQLHelper
    {
        public static CommandDefinition GenerateCommand(string spName, IDbTransaction transaction, CancellationToken cancellationToken, params SqlParameter[] paramters)
        {
            var args = new DynamicParameters(new { });
            paramters.ToList().ForEach(p => args.Add(p.ParameterName, p.Value));
            var cmd = new CommandDefinition(spName, args, transaction, default, CommandType.StoredProcedure, default, cancellationToken);
            return cmd;
        }
    }
}
