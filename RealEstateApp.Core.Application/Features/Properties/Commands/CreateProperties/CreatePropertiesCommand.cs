using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Application.ViewModels.TypeOfProperties;
using RealEstateApp.Core.Application.ViewModels.TypeOfSales;
using RealEstateApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Features.Properties.Commands.CreateProperties
{
    public class CreatePropertiesCommand : IRequest<int>
    {
        public string? Code { get; set; }


        [Required(ErrorMessage = "You must type the Property's price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "You must choose the Property's size in meters")]
        [Range(1, int.MaxValue, ErrorMessage = "You must choose the Property's size in meters")]
        public int LandSize { get; set; }

        [Required(ErrorMessage = "You must choose the Number of Rooms")]
        [Range(1, int.MaxValue, ErrorMessage = "You must choose the Number of Rooms")]
        public int NumberOfRooms { get; set; }


        [Required(ErrorMessage = "You must choose the Number of BathRooms")]
        [Range(1, int.MaxValue, ErrorMessage = "You must choose the Number of BathRooms")]
        public int NumberOfBathrooms { get; set; }

        [Required(ErrorMessage = "You must type the Property's description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(240)]
        public string Description { get; set; }

        public string? ImagePathOne { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile? ImageFileOne { get; set; }

        public string? ImagePathTwo { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile? ImageFileTwo { get; set; }

        public string? ImagePathThree { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile? ImageFileThree { get; set; }

        public string? ImagePathFour { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile? ImageFileFour { get; set; }

        [Required(ErrorMessage = "You must choose the Type of Property")]
        [Range(1, int.MaxValue, ErrorMessage = "You must choose the Type of Property")]
        public int TypeOfPropertyId { get; set; }

        [Required(ErrorMessage = "You must choose the Type of Sale")]
        [Range(1, int.MaxValue, ErrorMessage = "You must choose the Type of Sale")]
        public int TypeOfSaleId { get; set; }

        public int AnnouncementId { get; set; }
        public List<int>? ImprovementsId { get; set; }

        public List<TypeOfPropertiesViewModel>? TypeOfProperties { get; set; }
        public List<TypeOfSalesViewModel>? TypeOfSales { get; set; }



    }
    public class CreatePropertiesCommandHandler : IRequestHandler<CreatePropertiesCommand, int>
    {
        private readonly IPropertiesRepository _propertiesRepository;
        private readonly IMapper _mapper;

        public CreatePropertiesCommandHandler(IPropertiesRepository propertiesRepository, IMapper mapper)
        {
            _propertiesRepository = propertiesRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreatePropertiesCommand request, CancellationToken cancellationToken)
        {
            var properties = _mapper.Map<Domain.Entities.Properties>(request);

            properties = await _propertiesRepository.AddAsync(properties);

            return properties.Id;

        }
    }
}
