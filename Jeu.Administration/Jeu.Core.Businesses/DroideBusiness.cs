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
        #region Constants
        const int NB_POINTS_VIE_MAX = 100;

        #endregion

        #region Public methods
        public Droide AddOne(Droide item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ramène toute la liste (complète) des droides
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Droide> GetList()
        {
            return new List<Droide>()
            {
                new Droide(1, "A1", NB_POINTS_VIE_MAX),
                new Droide(2, "A2", NB_POINTS_VIE_MAX)
            };
        }
        #endregion
    }
}
