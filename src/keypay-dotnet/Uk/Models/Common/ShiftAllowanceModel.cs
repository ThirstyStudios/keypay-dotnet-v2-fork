using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class ShiftAllowanceModel
    {
        public string PayCategory { get; set; }
        public int PayCategoryId { get; set; }
        public decimal Units { get; set; }
        public decimal Cost { get; set; }
        public decimal RateMultiplier { get; set; }
        public ShiftAllowanceOption Option { get; set; }
        public ShiftAllowanceType Type { get; set; }
    }
}