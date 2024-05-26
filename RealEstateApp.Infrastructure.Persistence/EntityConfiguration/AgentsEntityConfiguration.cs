using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateApp.Core.Domain.Entities;
using RealEstateApp.Infrastructure.Persistence.Contexts;

namespace RealEstateApp.Infrastructure.Persistence.EntityConfiguration
{
    public class AgentsEntityConfiguration : BaseEntityConfiguration<Agents>
    {
        public override void Configure(EntityTypeBuilder<Agents> builder)
        {
            base.Configure(builder);
            builder.ToTable("Agents", ApplicationContext.DEFAULT_SCHEMA);
        }
    }
}

