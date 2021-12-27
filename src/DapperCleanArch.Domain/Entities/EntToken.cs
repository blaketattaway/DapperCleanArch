namespace DapperCleanArch.Domain.Entities
{
    public class EntToken
    {
        public EntToken()
        {
            Token = string.Empty;
        }
        public string Token { get; set; }
        public DateTime Expiracion { get; set; }
    }
}
