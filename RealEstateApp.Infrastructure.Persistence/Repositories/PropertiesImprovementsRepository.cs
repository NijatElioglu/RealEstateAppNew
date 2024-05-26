using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Domain.Entities;
using RealEstateApp.Infrastructure.Persistence.Contexts;
using RealEstateApp.Infrastructure.Persistence.Repository;

namespace RealEstateApp.Infrastructure.Persistence.Repositories
{
    internal class PropertiesImprovementsRepository : GenericRepository<PropertiesImprovements>, IPropertiesImprovementsRepository
    {
        private readonly ApplicationContext _dbContext;

        public PropertiesImprovementsRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
