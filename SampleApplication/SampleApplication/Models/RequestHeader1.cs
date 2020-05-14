using System;
using System.Collections.Generic;

namespace SampleApplication.Models
{
    public partial class RequestHeader1
    {
        public int ReqId { get; set; }
        public int AssociateId { get; set; }
        public int Pmid { get; set; }
        public int ReqTypeId { get; set; }
        public int ReqCategoryId { get; set; }
        public DateTime ReqDate { get; set; }
    }
}
