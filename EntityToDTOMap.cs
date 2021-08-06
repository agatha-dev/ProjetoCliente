using AutoMapper;
using ProjetoCliente.Application.DTOs;
using ProcessoSeletivoScae.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCliente.Application.Mappings
{
    public class EntityToDTOMap : Profile
    {
        public EntityToDTOMap()
        {
            #region Cliente

            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteDTO, Cliente>();


            #endregion
        }

    }
}
