using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateApp.Core.Domain.Entities;
using RealEstateApp.Infrastructure.Persistence.Contexts;

namespace RealEstateApp.Infrastructure.Persistence.EntityConfiguration
{
    public class ImprovementsConfiguration : BaseEntityConfiguration<Improvements>
    {
        public override void Configure(EntityTypeBuilder<Improvements> builder)
        {
            base.Configure(builder);
            builder.ToTable("Improvments", ApplicationContext.DEFAULT_SCHEMA);
        }
    }
}
