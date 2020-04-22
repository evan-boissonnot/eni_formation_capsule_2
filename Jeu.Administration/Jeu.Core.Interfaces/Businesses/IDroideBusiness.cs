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

        /// <summary>
        /// Ajout d'un droide en base
        /// </summary>
        /// <param name="item">Item non null et renseigné</param>
        /// <returns>Retourne le même item, avec l'id > 0</returns>
        Droide AddOne(Droide item);
    }
}