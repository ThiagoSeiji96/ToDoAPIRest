using System.Text.Json.Serialization;

namespace Dominio.InputModels
{
    public class CreateUserInputModel
    {
        public CreateUserInputModel(int id, string email, string password, string nome, DateTime dtNascimento)
        {
            Id = id;
            Email = email;
            Password = password;
            Nome = nome;
            DtNascimento = dtNascimento;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
    }
}
