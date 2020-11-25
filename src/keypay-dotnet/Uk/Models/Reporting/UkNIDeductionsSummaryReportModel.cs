using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkNIDeductionsSummaryReportModel
    {
        public IList<UkNIDeductionsSummaryReportPeriod> NiReportMonths { get; set; }
        public IList<UkNIDeductionsSummaryReportPeriod> NiReportQuarters { get; set; }
        public UkNIDeductionsSummaryReportPeriod NiReportTotals { get; set; }
    }
}