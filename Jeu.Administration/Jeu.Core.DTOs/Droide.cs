using System;
using System.Collections.Generic;
using System.Text;

namespace Jeu.Core.DTOs
{
    /// <summary>
    /// Représente le DTO de base pour tous les droides dans le jeu
    /// </summary>
    public class Droide : BaseItem
    {
        #region Constructors
        public Droide() { }

        public Droide(int id, string matricule, int pointsDeVie) : base(id)
        {
            this.Matricule = matricule;
            this.PointsDeVie = pointsDeVie;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Matricule unique de chaque droide
        /// </summary>
        /// <remarks>Ne peut être vide !</remarks>
        public string Matricule { get; }

        /// <summary>
        /// Points de vie du droide
        /// </summary>
        /// <remarks>A initialiser à priori supérieur à 0</remarks>
        public int PointsDeVie { get; }
        #endregion
    }
}
