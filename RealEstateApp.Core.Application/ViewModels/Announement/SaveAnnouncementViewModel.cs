using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.ViewModels.Announement
{
    public class SaveAnnouncementViewModel
    {
        public int CategoriesId { get; set; }
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
    }
}
