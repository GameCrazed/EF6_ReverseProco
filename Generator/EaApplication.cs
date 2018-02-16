

namespace Generator
{

    public class EaApplication
    {
        public int ApplicationId { get; set; }
        public int? PropertyAddressId { get; set; }
        public int? ValuerAddressId { get; set; }
        public int? SolicitorAddressId { get; set; }
        public byte? OwnSolicitor { get; set; }
        public byte? OverSeventeen { get; set; }
        public double? NetLoanAmount { get; set; }
        public int? TermYears { get; set; }
        public int? TermMonths { get; set; }
        public string PurposeOfLoan { get; set; }
        public byte? RightToBuy { get; set; }
        public double? ProperyValue { get; set; }
        public string SolicitorCompanyName { get; set; }
        public string SolicitorContactName { get; set; }
        public string SolicitorContactNumber { get; set; }
        public string SolicitorFaxNumber { get; set; }
        public string SolicitorEmailAddress { get; set; }
        public string SolicitorDxNumber { get; set; }
        public string SolicitorPracticeType { get; set; }
        public string SolicitorPhoneType { get; set; }
        public double? PurchaseSalePrice { get; set; }
        public double? PurchasePropertyPrice { get; set; }
        public double? PurchaseDepositAmount { get; set; }
        public string PurchaseSource { get; set; }
        public string PurchaseDetails { get; set; }
        public byte? PurchaseOtherLoan { get; set; }
        public double? PurchaseLoanAmount { get; set; }
        public string PurchaseLoanDetails { get; set; }
        public byte? PropertyResidentialPurpose { get; set; }
        public string PropertyType { get; set; }
        public string PropertyStyle { get; set; }
        public string PropertyBuilt { get; set; }
        public string PropertyRoofed { get; set; }
        public string PropertyRooms { get; set; }
        public string PropertyBedrooms { get; set; }
        public string PropertyBathrooms { get; set; }
        public string PropertyGaraging { get; set; }
        public byte? PropertyBusinessPremiseClose { get; set; }
        public string PropertyTenure { get; set; }
        public int? PropertyLeaseYears { get; set; }
        public string PropertyConstructionType { get; set; }
        public byte? PropertyLocalAuthority { get; set; }
        public string PropertyFlatFoors { get; set; }
        public string PropertyOtherMatBuilt { get; set; }
        public string PropertyOtherMatRoofed { get; set; }
        public string PropertyNonResProportion { get; set; }
        public string PropertyNonResNature { get; set; }
        public string ValuerPersonToContact { get; set; }
        public string ValuerContactName { get; set; }
        public string ValuerContactNumber { get; set; }
        public string ValuerFaxNumber { get; set; }
        public string ValuerEmailAddress { get; set; }
        public string ValuerPhoeType { get; set; }
        public int? ApplicationStatus { get; set; }
        public string LedgerCode { get; set; }
        public string ApplicationType { get; set; }
        public double? InterestOnlyAmount { get; set; }
    }

}
