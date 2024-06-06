using AutoMapper;
using MediatR;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Features.Announcement.Commands.CreateAnnouncement
{
    public class CreateAnnouncementCommand : IRequest<int>
    {

        public double Price { get; set; }
        public bool Availability { get; set; }
        public bool NeighborhoodNoise { get; set; }
        public bool Garage { get; set; }
        public int Floor { get; set; }
        public bool IsRepaired { get; set; }
        public float AreaSize { get; set; }
        public int BedCount { get; set; }
        public int RoomCount { get; set; }
        public int BathCount { get; set; }
        public DateTime? BuildingCreatedDate { get; set; }
        public int CategoriesId { get; set; }
    }

    public class CreateAnnouncementCommandHandler : IRequestHandler<CreateAnnouncementCommand, int>
    {
        private readonly IAnnouncementRepository _announcementRepository;
        private readonly IMapper _mapper;

        public CreateAnnouncementCommandHandler(IAnnouncementRepository announcementRepository, IMapper mapper)
        {
            _announcementRepository = announcementRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateAnnouncementCommand request, CancellationToken cancellationToken)
        {
            var Announcement = _mapper.Map<Domain.Entities.Announcement>(request);
            Announcement = await _announcementRepository.AddAsync(Announcement);
            return Announcement.Id;
        }
    }
}
