using RealEstateApp.Core.Domain.Common;

namespace RealEstateApp.Core.Domain.Entities
{
    public class Categories:AuditableBaseEntity
    {
        public string Name { get; set; }
        public ICollection<Announcement>? Announcements { get; set; }
    }
}
