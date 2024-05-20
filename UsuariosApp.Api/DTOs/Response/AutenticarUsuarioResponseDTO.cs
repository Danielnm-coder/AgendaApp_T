namespace UsuariosApp.Api.DTOs.Response
{
    /// <summary>
    /// Modelo de dados para a Resposta de autenticação de usuários da API.
    /// </summary>
    public class AutenticarUsuarioResponseDTO
    {

        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public DateTime DataHoraAcesso { get; set; }
        public string? AccesToken { get; set; }
        public DateTime DataHoraExpiracao { get; set; }

    }
}
