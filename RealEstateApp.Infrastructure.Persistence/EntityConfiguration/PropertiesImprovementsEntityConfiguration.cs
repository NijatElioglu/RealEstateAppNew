using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateApp.Core.Domain.Entities;
using RealEstateApp.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Infrastructure.Persistence.EntityConfiguration
{
    public class PropertiesImprovementsEntityConfiguration : BaseEntityConfiguration<PropertiesImprovements>
    {
        public override void Configure(EntityTypeBuilder<PropertiesImprovements> builder)
        {
            base.Configure(builder);

            builder.ToTable("PropertiesImprovements", ApplicationContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.Improvement)
                   .WithMany(i => i.PropertiesImprovements)
                   .HasForeignKey(i => i.PropertyId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(i => i.Property)
                  .WithMany(i => i.PropertiesImprovements)
                  .HasForeignKey(i => i.ImprovementId)
                  .OnDelete(DeleteBehavior.Cascade);

        }

        }
    }
