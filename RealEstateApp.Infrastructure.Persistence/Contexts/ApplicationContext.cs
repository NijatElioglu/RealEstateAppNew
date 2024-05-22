using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RealEstateApp.Core.Domain.Common;
using RealEstateApp.Core.Domain.Entities;

namespace RealEstateApp.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "dbo";
        public ApplicationContext()
        {
                
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        //public DbSet<Agents>? Agent { get; set; }
        public DbSet<Properties>? Properties { get; set; }
        public DbSet<Improvements>? Improvements { get; set; }
        public DbSet<TypeOfProperties>? TypeOfProperties { get; set; }
        public DbSet<TypeOfSales>? TypeOfSales { get; set; }
        public DbSet<PropertiesImprovements>? PropertiesImprovements { get; set; }

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
  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
            #region tables
            modelBuilder.Entity<Properties>().ToTable("Properties");
            modelBuilder.Entity<TypeOfProperties>().ToTable("TypeOfProperties");
            modelBuilder.Entity<TypeOfSales>().ToTable("TypeOfSales");
            modelBuilder.Entity<Improvements>().ToTable("Improvements");
            #endregion

            #region "primary keys"
           
            #endregion

            #region relationships

           
            #endregion

            #region "property configurations"

            #region Properties
            modelBuilder.Entity<Properties>()
                .HasIndex(property => property.Code)
                .IsUnique();
            #endregion

            #endregion

        }
    }
}
