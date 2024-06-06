using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Features.Properties.Commands.UpdateProperties
{
    public class UpdatePropertiesResponse
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public decimal? Price { get; set; }
        public int? LandSize { get; set; }
        public int? NumberOfRooms { get; set; }
        public int? NumberOfBathrooms { get; set; }
        public string? Description { get; set; }
        public string? ImagePathOne { get; set; }
        public IFormFile? ImageFileOne { get; set; }
        public string? ImagePathTwo { get; set; }
        public IFormFile? ImageFileTwo { get; set; }
        public string? ImagePathThree { get; set; }
        public IFormFile? ImageFileThree { get; set; }
        public string? ImagePathFour { get; set; }
        public IFormFile? ImageFileFour { get; set; }
        public int? TypeOfPropertyId { get; set; }
        public int? TypeOfSaleId { get; set; }
        public List<int>? ImprovementsId { get; set; }
    }
}
