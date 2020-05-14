using System;
using System.Collections.Generic;

namespace SampleApplication.Models
{
    public partial class RequestDetailStatus
    {
        public int ReqDetailId { get; set; }
        public int ReqId { get; set; }
        public int StatusId { get; set; }
        public int LastActionId { get; set; }
    }
}
