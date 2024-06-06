using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Domain.Entities;
using RealEstateApp.Infrastructure.Persistence.Contexts;
using RealEstateApp.Infrastructure.Persistence.Repository;


namespace RealEstateApp.Infrastructure.Persistence.Repositories
{
    public class AnnouncementRepository : GenericRepository<Announcement>, IAnnouncementRepository
    {
        private readonly ApplicationContext _context;
        public AnnouncementRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}
