using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jeu.Core.Businesses;
using Jeu.Core.DTOs;
using Jeu.Core.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Jeu.Administration.Web.UI.Controllers
{
    public class DroideController : BaseController<List<BaseItem>, BaseItem>
    {
        private IDroideBusiness _business = null;

        #region Constructors
        public DroideController(IDroideBusiness business)
        {
            this._business = business;
        }
        #endregion

        #region Public actions
        public IActionResult Index()
        {
            //this.ViewModel

            return View();
        }
        #endregion
    }
}