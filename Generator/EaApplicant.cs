

namespace Generator
{

    public class EaApplicant
    {
        public int ApplicantId { get; set; }
        public int? PreviousNameId { get; set; }
        public int ApplicationId { get; set; }
        public int ApplicantNameId { get; set; }
        public byte? IncludeInIllustration { get; set; }
        public byte? IncomeProvider { get; set; }
        public string RelationShip { get; set; }
        public string BankruptcyStatus { get; set; }
        public int Ordinal { get; set; }
        public string IncomeTypeOfEmployment { get; set; }
        public string IncomeEmploymentTime { get; set; }
        public string IncomeMethodProvidingIncome { get; set; }
        public double? IncomeMainAnnualIncome { get; set; }
        public double? IncomeSecondAnnualIncome { get; set; }
        public byte? IncomeSecondsJobLess6Months { get; set; }
        public double? IncomeOtherAnnualIncome { get; set; }
        public string ContactBestTime { get; set; }
        public string ContactDayTimeNumberStd { get; set; }
        public string ContactDayTimeNumber { get; set; }
        public string ContactEveningNumberStd { get; set; }
        public string ContactEveningNumber { get; set; }
        public string ContactMobileNumber { get; set; }
        public string ContactEmailAddress { get; set; }
    }

}
