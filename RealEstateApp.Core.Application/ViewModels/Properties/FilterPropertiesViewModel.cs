namespace RealEstateApp.Core.Application.ViewModels.Properties
{
    public class FilterPropertiesViewModel
    {
        public string? Code { get; set; }
        public List<int>? Ids { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfBathrooms { get; set; }
    }
}
