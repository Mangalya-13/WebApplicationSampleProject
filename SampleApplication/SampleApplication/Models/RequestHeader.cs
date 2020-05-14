using System;
using System.Collections.Generic;

namespace SampleApplication.Models
{
    public partial class RequestHeader
    {
        public int ReqId { get; set; }
        public int AssociateId { get; set; }
        public string AssociateName { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int Pmid { get; set; }
        public int ReqTypeId { get; set; }
        public int ReqCategoryId { get; set; }
        public DateTime ReqDate { get; set; }
        public string Remarks { get; set; }
    }
}
