using System;
using System.Collections.Generic;

namespace KeyPayV2.Au.Enums
{
    public enum AuPayCategoryType
    {
        Standard,
        LeaveLoading,
        GenuineRedundancyLeavePayment,
        OpeningBalanceAllowances,
        EtpTypeRTaxable,
        EtpTypeRTaxFree,
        EtpTypeOTaxable,
        EtpTypeOTaxFree,
        EtpLumpSumD,
        GenuineRedundancyLeaveLoading,
        MethodB2AdditionalPaymentsOpeningBalance,
        EtpSuperableTypeOTaxable,
        EtpSuperableTypeOTaxFree,
        EtpTypeOUnusedLeavePayment,
        EtpTypeSTaxable,
        EtpTypeSTaxFree,
        EtpTypePTaxable,
        EtpTypePTaxFree,
        EtpSuperableTypePTaxable,
        EtpSuperableTypePTaxFree,
        EtpTypePUnusedLeavePayment,
        JobKeeperTier,
        JobKeeperCancelTier,
        JobMakerNomination,
        JobMakerRenomination,
        JobMakerPeriod,
        JobMakerCancelNomination,
        JobMakerCancelRenomination,
        JobMakerCancelPeriod,
        NormalTerminationLeaveLoading,
        PublicHolidayWorked,
        PublicHolidayNotWorked,
        UnusedLeavePaymentNormalTermination,
        BackPayment,
        PaidFamilyAndDomesticViolenceLeave,
        GST
    }
    //https://github.com/KeyPay/keypay-dotnet-v2/issues/9
}
