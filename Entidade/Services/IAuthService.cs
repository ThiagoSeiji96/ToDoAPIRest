namespace Entidade.Services
{
    public interface IAuthService
    {
        string GenerateJwtToken(string email, string password);

        string ComputeSha256Hash(string password);
    }
}
