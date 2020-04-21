using System;
using System.Collections.Generic;
using System.Text;

namespace Jeu.Core.DTOs
{
    /// <summary>
    /// Base de tous les objets du projet
    /// </summary>
    public abstract class BaseItem
    {
        #region Constructors
        public BaseItem() { }

        public BaseItem(int id) 
        {
            this.Id = id;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Id représentant une instance d'un item  
        /// (à priori il faudra gérer l'autoincrément)
        /// </summary>
        public int Id { get; set; }
        #endregion
    }
}
