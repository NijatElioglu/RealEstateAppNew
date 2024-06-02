using RealEstateApp.Core.Domain.Common;

namespace RealEstateApp.Core.Domain.Entities
{
    public class Announcement : AuditableBaseEntity
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
        public DateTime BuildingCreatedDate { get; set; }

        #region Relations
        public Categories Categories { get; set; }
        public int CategoriesId { get; set; }

        #endregion
    }
}
