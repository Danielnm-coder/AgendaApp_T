using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosApp.Domain.Entities;

namespace UsuariosApp.Domain.Interfaces.Services
{
    /// <summary>
    /// Metodo de serviço  de dominio para usuario 
    /// </summary>
    public interface IUsuarioDomainService
    {
        /// <summary>
        /// Método para realizar a criação de donta de usuario
        /// </summary>
        void CriarConta(Usuario usuario);

        /// <summary>
        /// Método para realizar a autenticação de conta do usuario
        /// </summary>
        Usuario Autenticar(string email, string senha);
    }
}
