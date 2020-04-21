using Jeu.Core.DTOs;
using Jeu.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Jeu.Core.Businesses
{
    public class DroideBusiness : IDroideBusiness
    {
        #region Public methods
        /// <summary>
        /// Ramène toute la liste (complète) des droides
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Droide> GetList()
        {
            return new List<Droide>()
            {
                new Droide(1, "A1", 100),
                new Droide(2, "A2", 100)
            };
        }
        #endregion
    }
}
