using System.ComponentModel.DataAnnotations;

namespace UsuariosApp.Api.DTOs.Request
{
    /// <summary>
    /// Modelo de dados para a requisição de autenticação de usuários da API.
    /// </summary>
    public class AutenticarUsuarioRequestDTO
    {
        [EmailAddress(ErrorMessage ="Informe um endereço de email valido.")]
        [Required(ErrorMessage = "Por favor , informe o email do usuario")]
        public string? Email { get; set; }

        [MinLength(8, ErrorMessage ="Por favor, informe no minimo {1} caracteres")]
        [Required(ErrorMessage = "Por favor , informe a senha do usuario")]
        public string? Senha { get; set; }
    }
}
