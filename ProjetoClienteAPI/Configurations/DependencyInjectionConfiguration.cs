using Microsoft.Extensions.DependencyInjection;
using ProjetoCliente.Application.Contracts;
using ProcessoSeletivoScae.Application.Services;
using ProjetoCliente.Domain.Contracts.Repositories;
using ProjetoCliente.Domain.Contracts.Services;
using ProjetoCliente.Domain.Services;
using ProjetoCliente.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCliente.Presentation.API.Configurations
{
    public class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjection(IServiceCollection services)
        {
            #region Application

            services.AddTransient<IClienteApplicationService, ClienteApplicationService>();

            #endregion

            #region Domain

            services.AddTransient<IClienteDomainService, ClienteDomainService>();

            #endregion

            #region InfraStructure

            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            #endregion

        }
    }
}
