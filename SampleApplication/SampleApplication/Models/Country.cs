using System;
using System.Collections.Generic;

namespace SampleApplication.Models
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public bool IsActive { get; set; }
    }
}
