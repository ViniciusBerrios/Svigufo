using Senai.SviGufo.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SviGufo.WebApi.Interfaces
{
    interface IConviteRepository
    {
        List<ConviteDomain> Listar();

        /// <summary>
        /// Listar somente os convites do usuário
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <returns></returns>
        List<ConviteDomain> ListarMeusConvites(int usuarioId);

        /// <summary>
        /// Cadastrar um novo convite
        /// </summary>
        /// <param name=""></param>
        void Cadastrar(ConviteDomain convite);
    }
}
