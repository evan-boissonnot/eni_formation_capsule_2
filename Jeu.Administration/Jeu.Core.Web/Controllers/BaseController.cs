using Jeu.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeu.Core.Web.Controllers
{
    /// <summary>
    ///  Base des controllers du projet de jeu 
    /// </summary>
    /// <typeparam name="T">Tout type mais une classe</typeparam>
    /// <typeparam name="U">Doit être un DTO du projet</typeparam>
    // TODO: 20/04/2020, EB, Ne peut-on pas éviter d'avoir le T et le U comme ça ?
    public abstract class BaseController<T, U> : Controller 
                                               where T: class
                                               where U: BaseItem
    {
        #region Constructors
        public BaseController()
        {
            // TODO: 20/04/2020, EB, Penser à faire un new ici sur le générique
            this.ViewModel = default(T);
        }
        #endregion

        #region Properties
        /// <summary>
        /// View model du controller
        /// </summary>
        public T ViewModel { get; set; }
        #endregion
    }
}
