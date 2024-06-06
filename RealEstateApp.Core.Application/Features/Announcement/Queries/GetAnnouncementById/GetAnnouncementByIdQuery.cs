using AutoMapper;
using MediatR;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Application.ViewModels.Announement;
using RealEstateApp.Core.Application.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Features.Announcement.Queries.GetAnnouncementById
{
    public class GetAnnouncementByIdQuery:IRequest<AnnouncementViewModel>
    {
        public int Id { get; set; }
        public class GetAnnouncementByIdQueryHandler : IRequestHandler<GetAnnouncementByIdQuery, AnnouncementViewModel>
        {
            private readonly IAnnouncementRepository _announcementRepository;
            private readonly IMapper _mapper;
            public GetAnnouncementByIdQueryHandler(IAnnouncementRepository announcementRepository, IMapper mapper)
            {
                _announcementRepository = announcementRepository;
                _mapper = mapper;
            }
            public async Task<AnnouncementViewModel> Handle(GetAnnouncementByIdQuery request, CancellationToken cancellationToken)
            {
                var Announcements = await _announcementRepository.GetAllAsync();
                var Announcement = Announcements.FirstOrDefault(x => x.Id == request.Id);
                if (Announcement is null) throw new Exception("No existe la propiedad.");
               
                return _mapper.Map<AnnouncementViewModel>(Announcement);
            }
        }
    }


}
