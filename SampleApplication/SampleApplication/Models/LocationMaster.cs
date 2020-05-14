using System;
using System.Collections.Generic;

namespace SampleApplication.Models
{
    public partial class LocationMaster
    {
        public int Id { get; set; }
        public string NewHcmlocationCode { get; set; }
        public int? GsmsbuildingId { get; set; }
        public string GsmsbuildingName { get; set; }
        public string HcmlocationDescription { get; set; }
        public string MyAccessLocationId { get; set; }
        public string CountryId { get; set; }
        public string CountryDesc { get; set; }
        public string CityId { get; set; }
        public string CityDescription { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
    }
}
