using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosApp.Domain.Entities
{
    /// <summary>
    /// Modelo de entidades de usuario
    /// </summary>
    public class Usuario
    {
        #region proripedades

        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public DateTime DataHoraCadastro { get; set; }
        public Guid PerfilId { get; set; }

        #endregion

        #region Relacionamento

        public Perfil? Perfil { get; set; }

        #endregion


    }
}
