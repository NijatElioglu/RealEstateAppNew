using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateApp.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Infrastructure.Persistence.EntityConfiguration
{
    public abstract class BaseEntityConfiguration<T>:IEntityTypeConfiguration<T> where T : AuditableBaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder) {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();

        } 
    }
}
