using AutoMapper;
using MediatR;
using RealEstateApp.Core.Application.Features.TypeOfProperties.Queries.GetAllTypeOfProperties;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Application.ViewModels.Announement;
using RealEstateApp.Core.Application.ViewModels.TypeOfProperties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Features.Announcement.Queries.GetAllAnnouncement
{
    public class GetAllAnnouncementQuery:IRequest<IEnumerable<AnnouncementViewModel>>
    {

        public class GetAllAnnouncementQueryHandler : IRequestHandler<GetAllAnnouncementQuery, IEnumerable<AnnouncementViewModel>>
        {
            private readonly IAnnouncementRepository _announcementRepository;
            private readonly IMapper _mapper;

            public GetAllAnnouncementQueryHandler(IAnnouncementRepository announcementRepository,IMapper mapper)
            {
                _announcementRepository = announcementRepository;
                _mapper = mapper;
            }

            public async Task<IEnumerable<AnnouncementViewModel>> Handle(GetAllAnnouncementQuery request, CancellationToken cancellationToken)
            {
                var GetAllAnnouncement = await GetAllViewModel();
                return GetAllAnnouncement;
            }
            private async Task<List<AnnouncementViewModel>> GetAllViewModel()
            {
                var Announcements = await _announcementRepository.GetAllAsync();
                if (Announcements.Count() == 0) throw new Exception("No Exits");
                var result = _mapper.Map<List<AnnouncementViewModel>>(Announcements);
                return result;
            }
        }

    }
}
