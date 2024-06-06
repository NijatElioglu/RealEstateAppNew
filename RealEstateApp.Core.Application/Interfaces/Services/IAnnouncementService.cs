using RealEstateApp.Core.Application.ViewModels.Announement;
using RealEstateApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Interfaces.Services
{
    public interface IAnnouncementService:IGenericService<SaveAnnouncementViewModel,AnnouncementViewModel,Announcement>
    {
    }
}
