using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosApp.Domain.Entities;

namespace UsuariosApp.Domain.Interfaces.Repositories
{
    /// <summary>
    /// interface de reposittorio de dados para a entidade Perfil
    /// </summary>
    public interface IPerfilRepository
    {
        Perfil? GetByNome(string nome);
    }
}
