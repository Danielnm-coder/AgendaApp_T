using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosApp.Domain.Entities;
using UsuariosApp.Domain.Interfaces.Repositories;
using UsuariosApp.Domain.Interfaces.Services;

namespace UsuariosApp.Domain.Services
{
    public class UsuarioDomainService : IUsuarioDomainService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPerfilRepository _perfilRepository;

        public UsuarioDomainService(IUsuarioRepository usuarioRepository, IPerfilRepository perfilRepository)
        {
            _usuarioRepository = usuarioRepository;
            _perfilRepository = perfilRepository;
        }

        public void CriarConta(Usuario usuario)
        {
            #region Verificar se já existe um usuario com emial cadastrado

            if (_usuarioRepository.GetByEmail(usuario.Email) != null)
                throw new ApplicationException("O email informado já foi cadastrado. Tente outro");
            #endregion

            #region Cadastrar usário

            _usuarioRepository.Add(usuario);

            #endregion
        }

        public Usuario Autenticar(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
