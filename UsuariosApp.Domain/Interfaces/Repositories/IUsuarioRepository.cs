﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosApp.Domain.Entities;

namespace UsuariosApp.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interface de repositorio  de dados para entidade Usuario
    /// </summary>
    public interface IUsuarioRepository 
    {
        void Add(Usuario usuario);
        Usuario? GetByEmail(string email);
        Usuario? GetByEmailAndSenha(string email, string senha);
    }
}
