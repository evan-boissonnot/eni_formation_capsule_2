using Jeu.Core.Business.WithEntities.Data;
using Jeu.Core.DTOs;
using Jeu.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Jeu.Core.Business.WithEntities
{
    /// <summary>
    /// Class utilisant entities framework, avec le context <c>DefaultContext</c>
    /// </summary>
    public class DroideBusiness : IDroideBusiness
    {
        #region Fields
        private DefaultContext _context = null;
        #endregion

        #region Constructors
        public DroideBusiness(DefaultContext context) 
               => this._context = context;
        #endregion

        #region Public methods
        public Droide AddOne(Droide item)
        {
            this._context.Droides.Add(item);
            this._context.SaveChanges();

            if (item.Id <= 0)
            {
                throw new ArgumentException("Item.Id");
            }

            return item;
        }

        public IEnumerable<Droide> GetList()
        {
            var query = from droide in this._context.Droides
                        orderby droide.PointsDeVie
                        select droide;

            return query;
        }
        #endregion
    }
}
