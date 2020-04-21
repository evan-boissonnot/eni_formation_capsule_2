using System.Collections.Generic;
using Jeu.Core.DTOs;

namespace Jeu.Core.Interfaces
{
    /// <summary>
    /// Contrat pour tous les businesses travaillant avec les Droides
    /// </summary>
    public interface IDroideBusiness
    {
        /// <summary>
        /// Ramène la liste complète des droides
        /// </summary>
        /// <returns></returns>
        IEnumerable<Droide> GetList();
    }
}