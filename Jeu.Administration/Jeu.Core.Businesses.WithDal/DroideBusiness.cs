using Jeu.Core.DataAcessLayers;
using Jeu.Core.DTOs;
using Jeu.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeu.Core.Businesses.WithDal
{
    public class DroideBusiness : IDroideBusiness
    {
        private DroideDal _dal = null;

        public DroideBusiness(DroideDal dal)
        {
            this._dal = dal;
        }

        public Droide AddOne(Droide item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Droide> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
