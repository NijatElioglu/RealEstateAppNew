using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.ViewModels.Buyer
{
    public class BuyerViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PropertiesQuantity { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
