using RealEstateApp.Core.Domain.Common;

namespace RealEstateApp.Core.Domain.Entities
{
    public class Properties : AuditableBaseEntity
    {
        public string Code { get; set; }
       
        public decimal Price { get; set; }
        public int LandSize { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public string Description { get; set; }
        public string? ImagePathOne { get; set; }
        public string? ImagePathTwo { get; set; }
        public string? ImagePathThree { get; set; }
        public string? ImagePathFour { get; set; }
        public int TypeOfPropertyId { get; set; }
        public int TypeOfSaleId { get; set; }
        public int AnnouncementId { get; set; }
        
        public TypeOfProperties? TypeOfProperty { get; set; }
        public TypeOfSales? TypeOfSale { get; set; }
        public Announcement? Announcement { get; set; }
    }
}
