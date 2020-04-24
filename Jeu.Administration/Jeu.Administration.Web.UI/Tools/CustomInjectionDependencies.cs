using Jeu.Core.Business.WithEntities;
using Jeu.Core.Business.WithEntities.Data;
using Jeu.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeu.Administration.Web.UI.Tools
{
    /// <summary>
    /// Definit des extensions de méthodes pour ajouter le paramétrage de l'injection des dépendances du projet
    /// </summary>
    public static class CustomInjectionDependencies
    {
        #region Public methods
        /// <summary>
        /// Injections du projet
        /// </summary>
        public static void DefineDependencyInjections(this IServiceCollection services)
        {
            // TODO: 23/04/2020, add config sql server
            services.AddDbContext<DefaultContext>();
            services.AddScoped<IDroideBusiness, DroideBusiness>();
        }
        #endregion
    }
}
