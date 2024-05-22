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
    public class PropertiesEntityConfiguration:BaseEntityConfiguration<Properties>
    {
        public override void Configure(EntityTypeBuilder<Properties> builder)
        {
            base.Configure(builder);
            builder.ToTable("Properties", ApplicationContext.DEFAULT_SCHEMA);

            builder.HasOne(i=>i.TypeOfProperty)
                .WithMany(i=>i.Properties)
                .HasForeignKey(i=>i.TypeOfPropertyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(i => i.TypeOfSale)
               .WithMany(i => i.Properties)
               .HasForeignKey(i => i.TypeOfSaleId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(i => i.Agents)
                     .WithMany(i => i.Properties)
                     .HasForeignKey(i => i.AgentId)
                     .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
