using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Domain.Entities;
using RealEstateApp.Infrastructure.Persistence.Contexts;
using RealEstateApp.Infrastructure.Persistence.Repository;

namespace RealEstateApp.Infrastructure.Persistence.Repositories
{
    public class ImprovementsRepository : GenericRepository<Improvements>, IImprovementsRepository
    {
        private readonly ApplicationContext _dbContext;

        public ImprovementsRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
