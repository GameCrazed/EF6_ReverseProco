

namespace Generator
{

    public class EaApplicationMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaApplication>
    {
        public EaApplicationMapping()
            : this("dbo")
        {
        }

        public EaApplicationMapping(string schema)
        {
            ToTable("ea_application", schema);
            HasKey(x => x.ApplicationId);

            Property(x => x.ApplicationId).HasColumnName(@"ApplicationID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PropertyAddressId).HasColumnName(@"PropertyAddressID").HasColumnType("int").IsOptional();
            Property(x => x.ValuerAddressId).HasColumnName(@"ValuerAddressID").HasColumnType("int").IsOptional();
            Property(x => x.SolicitorAddressId).HasColumnName(@"SolicitorAddressID").HasColumnType("int").IsOptional();
            Property(x => x.OwnSolicitor).HasColumnName(@"OwnSolicitor").HasColumnType("tinyint").IsOptional();
            Property(x => x.OverSeventeen).HasColumnName(@"OverSeventeen").HasColumnType("tinyint").IsOptional();
            Property(x => x.NetLoanAmount).HasColumnName(@"NetLoanAmount").HasColumnType("float").IsOptional();
            Property(x => x.TermYears).HasColumnName(@"TermYears").HasColumnType("int").IsOptional();
            Property(x => x.TermMonths).HasColumnName(@"TermMonths").HasColumnType("int").IsOptional();
            Property(x => x.PurposeOfLoan).HasColumnName(@"PurposeOfLoan").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.RightToBuy).HasColumnName(@"RightToBuy").HasColumnType("tinyint").IsOptional();
            Property(x => x.ProperyValue).HasColumnName(@"ProperyValue").HasColumnType("float").IsOptional();
            Property(x => x.SolicitorCompanyName).HasColumnName(@"SolicitorCompanyName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.SolicitorContactName).HasColumnName(@"SolicitorContactName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.SolicitorContactNumber).HasColumnName(@"SolicitorContactNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.SolicitorFaxNumber).HasColumnName(@"SolicitorFaxNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.SolicitorEmailAddress).HasColumnName(@"SolicitorEmailAddress").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.SolicitorDxNumber).HasColumnName(@"SolicitorDXNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.SolicitorPracticeType).HasColumnName(@"SolicitorPracticeType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.SolicitorPhoneType).HasColumnName(@"SolicitorPhoneType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PurchaseSalePrice).HasColumnName(@"PurchaseSalePrice").HasColumnType("float").IsOptional();
            Property(x => x.PurchasePropertyPrice).HasColumnName(@"PurchasePropertyPrice").HasColumnType("float").IsOptional();
            Property(x => x.PurchaseDepositAmount).HasColumnName(@"PurchaseDepositAmount").HasColumnType("float").IsOptional();
            Property(x => x.PurchaseSource).HasColumnName(@"PurchaseSource").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PurchaseDetails).HasColumnName(@"PurchaseDetails").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PurchaseOtherLoan).HasColumnName(@"PurchaseOtherLoan").HasColumnType("tinyint").IsOptional();
            Property(x => x.PurchaseLoanAmount).HasColumnName(@"PurchaseLoanAmount").HasColumnType("float").IsOptional();
            Property(x => x.PurchaseLoanDetails).HasColumnName(@"PurchaseLoanDetails").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyResidentialPurpose).HasColumnName(@"PropertyResidentialPurpose").HasColumnType("tinyint").IsOptional();
            Property(x => x.PropertyType).HasColumnName(@"PropertyType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyStyle).HasColumnName(@"PropertyStyle").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyBuilt).HasColumnName(@"PropertyBuilt").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyRoofed).HasColumnName(@"PropertyRoofed").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyRooms).HasColumnName(@"PropertyRooms").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyBedrooms).HasColumnName(@"PropertyBedrooms").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyBathrooms).HasColumnName(@"PropertyBathrooms").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyGaraging).HasColumnName(@"PropertyGaraging").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyBusinessPremiseClose).HasColumnName(@"PropertyBusinessPremiseClose").HasColumnType("tinyint").IsOptional();
            Property(x => x.PropertyTenure).HasColumnName(@"PropertyTenure").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyLeaseYears).HasColumnName(@"PropertyLeaseYears").HasColumnType("int").IsOptional();
            Property(x => x.PropertyConstructionType).HasColumnName(@"PropertyConstructionType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyLocalAuthority).HasColumnName(@"PropertyLocalAuthority").HasColumnType("tinyint").IsOptional();
            Property(x => x.PropertyFlatFoors).HasColumnName(@"PropertyFlatFoors").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyOtherMatBuilt).HasColumnName(@"PropertyOtherMatBuilt").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyOtherMatRoofed).HasColumnName(@"PropertyOtherMatRoofed").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyNonResProportion).HasColumnName(@"PropertyNonResProportion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PropertyNonResNature).HasColumnName(@"PropertyNonResNature").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ValuerPersonToContact).HasColumnName(@"ValuerPersonToContact").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ValuerContactName).HasColumnName(@"ValuerContactName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ValuerContactNumber).HasColumnName(@"ValuerContactNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ValuerFaxNumber).HasColumnName(@"ValuerFaxNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ValuerEmailAddress).HasColumnName(@"ValuerEmailAddress").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ValuerPhoeType).HasColumnName(@"ValuerPhoeType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ApplicationStatus).HasColumnName(@"ApplicationStatus").HasColumnType("int").IsOptional();
            Property(x => x.LedgerCode).HasColumnName(@"LedgerCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(3);
            Property(x => x.ApplicationType).HasColumnName(@"applicationType").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.InterestOnlyAmount).HasColumnName(@"InterestOnlyAmount").HasColumnType("float").IsOptional();
        }
    }

}
