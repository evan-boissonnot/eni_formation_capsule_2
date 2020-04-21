using System.Collections.Generic;
using Jeu.Core.DTOs;

namespace Jeu.Core.Businesses
{
    public interface IDroideBusiness
    {
        IEnumerable<Droide> GetList();
    }
}