using System;
using System.Collections.Generic;

namespace SampleApplication.Models
{
    public partial class ServerLocation
    {
        public int ServerLocationId { get; set; }
        public string ServerLocationName { get; set; }
        public bool IsActive { get; set; }
    }
}
