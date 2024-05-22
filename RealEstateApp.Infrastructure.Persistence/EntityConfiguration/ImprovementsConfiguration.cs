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
    public class ImprovementsConfiguration:BaseEntityConfiguration<Improvements>
    {
        public override void Configure(EntityTypeBuilder<Improvements> builder)
        {
            base.Configure(builder);
            builder.ToTable("Improvments",ApplicationContext.DEFAULT_SCHEMA);


  
        }
    }
}
