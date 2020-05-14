using System;
using System.Collections.Generic;

namespace SampleApplication.Models
{
    public partial class Facility
    {
        public int FacilityId { get; set; }
        public string FacilityHcmcode { get; set; }
        public string FacilityHcmdescription { get; set; }
        public string CityId { get; set; }
        public string GsmsbuildingId { get; set; }
        public string GsmsbuildingName { get; set; }
        public string MyAccessLocationId { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
