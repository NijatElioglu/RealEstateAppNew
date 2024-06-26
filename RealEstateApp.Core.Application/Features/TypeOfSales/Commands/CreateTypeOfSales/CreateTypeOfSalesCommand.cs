﻿using AutoMapper;
using MediatR;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Core.Application.Features.TypeOfSales.Commands.CreateTypeOfSales
{
    using RealEstateApp.Core.Domain.Entities;

    public class CreateTypeOfSalesCommand : IRequest<int>
    {
        //public int Id { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Description { get; set; }
    }

    public class CreateTypeOfSalesCommandHandler : IRequestHandler<CreateTypeOfSalesCommand, int>
    {
        private readonly ITypeOfSalesRepository _improvementsRepository;
        private readonly IMapper _mapper;

        public CreateTypeOfSalesCommandHandler(ITypeOfSalesRepository improvementsRepository, IMapper mapper)
        {
            _improvementsRepository = improvementsRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateTypeOfSalesCommand command, CancellationToken cancellationToken)
        {
            var improvements = _mapper.Map<TypeOfSales>(command);
            improvements = await _improvementsRepository.AddAsync(improvements);
            return improvements.Id;
        }
    }
}
