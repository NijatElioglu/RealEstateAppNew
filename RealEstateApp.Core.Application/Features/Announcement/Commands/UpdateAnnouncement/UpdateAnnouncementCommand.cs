using AutoMapper;
using MediatR;

using RealEstateApp.Core.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Features.Announcement.Commands.UpdateAnnouncement
{
    public class UpdateAnnouncementCommand:IRequest<UpdateAnnouncementResponse>
    {
          public int Id { get; set; }
        public double? Price { get; set; }
        public bool? Availability { get; set; }
        public bool? NeighborhoodNoise { get; set; }
        public bool? Garage { get; set; }
        public int? Floor { get; set; }
        public bool? IsRepaired { get; set; }
        public float? AreaSize { get; set; }
        public int? BedCount { get; set; }
        public int? RoomCount { get; set; }
        public int? BathCount { get; set; }
        public DateTime? BuildingCreatedDate { get; set; }
        public int? CategoriesId { get; set; }
    }


    public class UpdateAnnouncementCommandHandler : IRequestHandler<UpdateAnnouncementCommand,UpdateAnnouncementResponse>
    {
        private readonly IAnnouncementRepository _announcementRepository;
        private readonly IMapper _mapper;
        public UpdateAnnouncementCommandHandler(IAnnouncementRepository announcementRepository, IMapper mapper)
        {
            _announcementRepository = announcementRepository;
            _mapper = mapper;   
        }

        public async Task<UpdateAnnouncementResponse> Handle(UpdateAnnouncementCommand request, CancellationToken cancellationToken)
        {
            var Announcement = await _announcementRepository.GetByIdAsync(request.Id);
            if (Announcement == null) throw new Exception("El tipo de propiedad no ha sido encontrada.");

            await _announcementRepository.UpdateAsync(Announcement, Announcement.Id);
            var AnnouncementResponse = _mapper.Map<UpdateAnnouncementResponse>(Announcement);
            return AnnouncementResponse;
        }
    }
    }

