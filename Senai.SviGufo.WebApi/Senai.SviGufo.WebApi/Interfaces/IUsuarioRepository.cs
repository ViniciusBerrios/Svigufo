using Senai.SviGufo.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SviGufo.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório usuário
    /// </summary>
    interface IUsuarioRepository
    {
        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="usuario"></param>
        void Cadastrar(UsuarioDomain usuario);

        UsuarioDomain BuscarPorEmailSenha(string email, string senha);
    }
}