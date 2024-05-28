using RealEstateApp.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Domain.Entities
{
    public class Categories:AuditableBaseEntity
    {
        public string Name { get; set; }
        public ICollection<Announcement> Announcements { get; set; }
    }
}
