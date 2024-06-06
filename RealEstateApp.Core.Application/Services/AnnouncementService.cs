using AutoMapper;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Application.Interfaces.Services;
using RealEstateApp.Core.Application.ViewModels.Announement;
using RealEstateApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Services
{
    public class AnnouncementService : GenericService<SaveAnnouncementViewModel, AnnouncementViewModel, Announcement>, IAnnouncementService
    {
        public AnnouncementService(IGenericRepository<Announcement> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
