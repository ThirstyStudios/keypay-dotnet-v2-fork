using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.WhiteLabel
{
    public class SignupReportQueryModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string EmailAddresses { get; set; }
        public int LocationId { get; set; }
        public int? EmployingEntityId { get; set; }
    }
}