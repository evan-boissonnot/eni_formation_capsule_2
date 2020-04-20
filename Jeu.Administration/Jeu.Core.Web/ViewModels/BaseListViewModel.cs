using Jeu.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeu.Core.Web.ViewModels
{
    /// <summary>
    /// Base abstraite pour les view model fournissant les listes
    /// </summary>
    public abstract class BaseListViewModel<U> : BaseViewModel<List<U>> 
                                                 where U: BaseItem
    {

    }
}
