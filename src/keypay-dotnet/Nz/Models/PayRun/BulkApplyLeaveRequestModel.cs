using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class BulkApplyLeaveRequestModel
    {
        public List<Int32> LeaveRequestIds { get; set; }
    }
}
