

namespace Generator
{

    public class EaPayment
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int? LoanAddressId { get; set; }
        public string FeePaymentMethod { get; set; }
        public string FeePaymentCardType { get; set; }
        public string FeePaymentNameOnCard { get; set; }
        public string FeePaymentCardNumber { get; set; }
        public int? FeePaymentCardValidFromMm { get; set; }
        public int? FeePaymentCardValidFromYy { get; set; }
        public int? FeePaymentCardExpireMm { get; set; }
        public int? FeePaymentCardExpireYy { get; set; }
        public int? FeePaymentSecurityNumber { get; set; }
        public int? FeePaymentIssueNumber { get; set; }
        public byte? FeePaymentDebitHappy { get; set; }
        public string LoanPaymentMethod { get; set; }
        public string LoanSortCode { get; set; }
        public string LoanBankName { get; set; }
        public string LoanAccountNumber { get; set; }
        public string LoanAccountName { get; set; }
        public byte? InsuranceQuestionAnswer1 { get; set; }
        public byte? InsuranceQustionAnswer2 { get; set; }
        public byte? InsuranceQuestionAnswer3 { get; set; }
        public string InsuranceNotes { get; set; }
        public byte? InsuranceAccepted { get; set; }
        public byte? CapitalQuestionAnswer1 { get; set; }
        public byte? CapitalQuestionAnswer2 { get; set; }
        public byte? CapitalQuestionAnswer3 { get; set; }
        public byte? CapitalAcceptance { get; set; }
        public byte? ExceedRetirementAcceptance { get; set; }
        public byte? SelfCertificationAccepted { get; set; }
        public byte? RepaymentInRetirement { get; set; }
        public string CapitalNotes { get; set; }
    }

}
