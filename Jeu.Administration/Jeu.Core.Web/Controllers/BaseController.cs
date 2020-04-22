using Jeu.Core.DTOs;
using Jeu.Core.Web.ViewModels;
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
    // TODO: 20/04/2020, EB, Ne peut-on pas éviter d'avoir le T et le U comme ça ?
    public abstract class BaseController<T> : Controller 
                                              where T: BaseItem
    {
        #region Constructors
        public BaseController()
        {
            // TODO: 20/04/2020, EB, Penser à faire un new ici sur le générique

        }
        #endregion

        #region Public methods
        public IActionResult Index() 
        {
            var viewModel = this.DoIndex();

            if (viewModel.Item == null)
            {
                throw new ArgumentNullException("viewModel.Item", 
                                                "Vous devez renseigner une liste ici !");
            }

            return this.View(viewModel);
        }
        #endregion

        #region Internal methods
        /// <summary>
        /// Doit être renseignée, pour préciser le view model et son contenu à afficher dans l'index
        /// </summary>
        /// <returns></returns>
        protected abstract BaseListViewModel<T> DoIndex();
        #endregion

        #region Properties
        #endregion
    }
}
