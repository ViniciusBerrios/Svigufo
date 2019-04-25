using Senai.SviGufo.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SviGufo.WebApi.Interfaces
{
    interface IEventoRepository
    {
        List<EventoDomain> Listar();

        void Cadastrar(EventoDomain evento);

        void Atualizar(EventoDomain evento, int id);
    }
}
