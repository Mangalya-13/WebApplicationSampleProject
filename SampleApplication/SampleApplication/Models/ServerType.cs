using System;
using System.Collections.Generic;

namespace SampleApplication.Models
{
    public partial class ServerType
    {
        public int ServerTypeId { get; set; }
        public string ServerTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}
