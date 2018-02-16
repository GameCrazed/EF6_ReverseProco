

namespace Generator
{

    public class EaEmploymentdetail
    {
        public int EmploymentDetailsId { get; set; }
        public int? EmploymentAddressId { get; set; }
        public int? AccountantAddressId { get; set; }
        public int? DirectorAddressId { get; set; }
        public int ApplicantId { get; set; }
        public string EmployerCompanyName { get; set; }
        public string TypeofEmployment { get; set; }
        public string OccupationType { get; set; }
        public string OccupationStatus { get; set; }
        public System.DateTime? EmployedFrom { get; set; }
        public System.DateTime? EmployedTo { get; set; }
        public string CompRegNo { get; set; }
        public int? ShareHolding { get; set; }
        public int Ordinal { get; set; }
    }

}
