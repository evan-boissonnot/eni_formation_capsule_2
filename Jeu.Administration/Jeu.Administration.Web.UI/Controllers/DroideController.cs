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
            DroideListViewModel viewModel = new DroideListViewModel();

            viewModel.Item = this._business.GetList()
                                           .ToList();

            return viewModel;
        }
        #endregion
    }
}