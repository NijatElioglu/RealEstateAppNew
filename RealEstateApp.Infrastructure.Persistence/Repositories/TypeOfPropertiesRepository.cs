using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Domain.Entities;
using RealEstateApp.Infrastructure.Persistence.Contexts;
using RealEstateApp.Infrastructure.Persistence.Repository;

namespace RealEstateApp.Infrastructure.Persistence.Repositories
{
    public class TypeOfPropertiesRepository : GenericRepository<TypeOfProperties>, ITypeOfPropertiesRepository
    {
        private readonly ApplicationContext _dbContext;

        public TypeOfPropertiesRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
