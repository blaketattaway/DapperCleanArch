namespace DapperCleanArch.Domain.Entities
{
    public class EntUser
    {
        public EntUser(string user, string password)
        {
            User = user;
            Password = password;
        }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
