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
    public class AnnouncementEntityConfiguration:BaseEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> builder)
        {
            base.Configure(builder);
            builder.ToTable("Announcement", ApplicationContext.DEFAULT_SCHEMA);
            builder.HasOne(i => i.Categories)
               .WithMany(i => i.Announcements)
               .HasForeignKey(i => i.CategoriesId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
