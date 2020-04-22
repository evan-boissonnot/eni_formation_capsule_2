using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jeu.Core.Businesses;
using Jeu.Core.DTOs;
using Jeu.Core.Interfaces;
using Jeu.Core.Web.Controllers;
using Jeu.Core.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Jeu.Administration.Web.UI.Controllers
{
    public class DroideController : BaseController<Droide>
    {
        private IDroideBusiness _business = null;

        #region Constructors
        public DroideController(IDroideBusiness business)
        {
            this._business = business;
        }
        #endregion

        #region Protected methods
        protected override BaseListViewModel<Droide> DoIndex()
        {
            const int nbPointsDeVies = 100;
            DroideListViewModel viewModel = new DroideListViewModel();

            viewModel.Item = new List<Droide>()
            {
                new Droide(1, "aaaa", nbPointsDeVies),
                new Droide(2, "bbbb", nbPointsDeVies)
            };

            return viewModel;
        }
        #endregion
    }
}