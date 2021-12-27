namespace DapperCleanArch.Application.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Repositories declaration
        public IUserRepository UserRepository { get; }
        public void Commit();
    }
}
