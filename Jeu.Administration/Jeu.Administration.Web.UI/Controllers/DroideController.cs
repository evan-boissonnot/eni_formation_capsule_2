using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jeu.Core.DTOs;
using Jeu.Core.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Jeu.Administration.Web.UI.Controllers
{
    public class DroideController : BaseController<List<BaseItem>, BaseItem>
    {
        #region Constructors

        #endregion

        #region Public actions
        public IActionResult Index()
        {
            

            return View();
        }
        #endregion
    }
}