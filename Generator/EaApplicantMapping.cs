

namespace Generator
{

    public class EaApplicantMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaApplicant>
    {
        public EaApplicantMapping()
            : this("dbo")
        {
        }

        public EaApplicantMapping(string schema)
        {
            ToTable("ea_applicant", schema);
            HasKey(x => x.ApplicantId);

            Property(x => x.ApplicantId).HasColumnName(@"ApplicantID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PreviousNameId).HasColumnName(@"PreviousNameID").HasColumnType("int").IsOptional();
            Property(x => x.ApplicationId).HasColumnName(@"ApplicationID").HasColumnType("int").IsRequired();
            Property(x => x.ApplicantNameId).HasColumnName(@"ApplicantNameID").HasColumnType("int").IsRequired();
            Property(x => x.IncludeInIllustration).HasColumnName(@"IncludeInIllustration").HasColumnType("tinyint").IsOptional();
            Property(x => x.IncomeProvider).HasColumnName(@"IncomeProvider").HasColumnType("tinyint").IsOptional();
            Property(x => x.RelationShip).HasColumnName(@"RelationShip").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.BankruptcyStatus).HasColumnName(@"BankruptcyStatus").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Ordinal).HasColumnName(@"Ordinal").HasColumnType("int").IsRequired();
            Property(x => x.IncomeTypeOfEmployment).HasColumnName(@"IncomeTypeOfEmployment").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.IncomeEmploymentTime).HasColumnName(@"IncomeEmploymentTime").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.IncomeMethodProvidingIncome).HasColumnName(@"IncomeMethodProvidingIncome").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.IncomeMainAnnualIncome).HasColumnName(@"IncomeMainAnnualIncome").HasColumnType("float").IsOptional();
            Property(x => x.IncomeSecondAnnualIncome).HasColumnName(@"IncomeSecondAnnualIncome").HasColumnType("float").IsOptional();
            Property(x => x.IncomeSecondsJobLess6Months).HasColumnName(@"IncomeSecondsJobLess6Months").HasColumnType("tinyint").IsOptional();
            Property(x => x.IncomeOtherAnnualIncome).HasColumnName(@"IncomeOtherAnnualIncome").HasColumnType("float").IsOptional();
            Property(x => x.ContactBestTime).HasColumnName(@"ContactBestTime").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ContactDayTimeNumberStd).HasColumnName(@"ContactDayTimeNumberSTD").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ContactDayTimeNumber).HasColumnName(@"ContactDayTimeNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ContactEveningNumberStd).HasColumnName(@"ContactEveningNumberSTD").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ContactEveningNumber).HasColumnName(@"ContactEveningNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ContactMobileNumber).HasColumnName(@"ContactMobileNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ContactEmailAddress).HasColumnName(@"ContactEmailAddress").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
        }
    }

}
