using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Infrastructure.Identity.Entities;
using RealEstateApp.Core.Domain.Common;
using RealEstateApp.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace RealEstateApp.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public const string DEFAULT_SCHEMA = "dbo";

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Properties>? Properties { get; set; }
        public DbSet<TypeOfProperties>? TypeOfProperties { get; set; }
        public DbSet<TypeOfSales>? TypeOfSales { get; set; }
        public DbSet<Categories>? Categories { get; set; }
        public DbSet<Announcement>? Announcements { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = "DefaultAppUser";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.LastModifiedBy = "DefaultAppUser";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Identity configurations
            builder.HasDefaultSchema("Identity");

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "Users");
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Roles");
            });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable(name: "UserRoles");
            });

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable(name: "UserLogins");
            });

            // Fluent API configurations for application tables
            #region tables
            builder.Entity<Properties>().ToTable("Properties", DEFAULT_SCHEMA);
            builder.Entity<TypeOfProperties>().ToTable("TypeOfProperties", DEFAULT_SCHEMA);
            builder.Entity<TypeOfSales>().ToTable("TypeOfSales", DEFAULT_SCHEMA);
            builder.Entity<Categories>().ToTable("Categories", DEFAULT_SCHEMA);
            builder.Entity<Announcement>().ToTable("Announcements", DEFAULT_SCHEMA);
            #endregion
        }
    }
}
