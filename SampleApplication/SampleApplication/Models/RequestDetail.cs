using System;
using System.Collections.Generic;

namespace SampleApplication.Models
{
    public partial class RequestDetail
    {
        public int ReqDetailId { get; set; }
        public int ReqId { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
        public string Facility { get; set; }
        public string SourceIp { get; set; }
        public string DestIp { get; set; }
        public string Port { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StatusId { get; set; }
    }
}
