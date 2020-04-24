using Jeu.Core.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jeu.Core.Business.WithEntities.Data.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class DroideEntityConfiguration : IEntityTypeConfiguration<Droide>
    {
        #region Public methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Droide> builder)
        {
            builder.ToTable("Droide");
            builder.HasKey(item => item.Id);
            builder.Property(item => item.Matricule).IsRequired(true);
        }
        #endregion
    }
}
