using System;
using System.Collections.Generic;

namespace SampleApplication.Models
{
    public partial class PublishTypeOtherValue
    {
        public int PublishTypeOtherValueId { get; set; }
        public string PublishTypeOtherValueName { get; set; }
        public int PublishTypeOtherId { get; set; }
        public bool IsActive { get; set; }
    }
}
