using Jeu.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeu.Core.Web.ViewModels
{
    /// <summary>
    /// Base des view model de notre projet
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseViewModel<T> where T: class
    {
        /// <summary>
        /// Item du view model (en lecture / écriture)
        /// </summary>
        T Item { get; set; }
    }
}
