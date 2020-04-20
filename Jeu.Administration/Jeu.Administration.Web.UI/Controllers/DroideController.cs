using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jeu.Administration.Web.UI.Controllers
{
    public class DroideController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}