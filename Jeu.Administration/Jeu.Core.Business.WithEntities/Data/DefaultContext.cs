using Jeu.Core.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeu.Core.Business.WithEntities.Data
{
    /// <summary>
    /// Base de données initiale du jeu
    /// </summary>
    public class DefaultContext : DbContext
    {
        #region Internal methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Configurations.DroideEntityConfiguration());
        }
        #endregion

        #region Properties
        /// <summary>
        /// Collection des droides (et uniquement les droides)
        /// </summary>
        public DbSet<Droide> Droides { get; set; }
        #endregion
    }
}
