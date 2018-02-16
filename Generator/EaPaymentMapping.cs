

namespace Generator
{

    public class EaPaymentMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaPayment>
    {
        public EaPaymentMapping()
            : this("dbo")
        {
        }

        public EaPaymentMapping(string schema)
        {
            ToTable("ea_payment", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplicationId).HasColumnName(@"ApplicationID").HasColumnType("int").IsRequired();
            Property(x => x.LoanAddressId).HasColumnName(@"LoanAddressID").HasColumnType("int").IsOptional();
            Property(x => x.FeePaymentMethod).HasColumnName(@"FeePaymentMethod").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.FeePaymentCardType).HasColumnName(@"FeePaymentCardType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.FeePaymentNameOnCard).HasColumnName(@"FeePaymentNameOnCard").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.FeePaymentCardNumber).HasColumnName(@"FeePaymentCardNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.FeePaymentCardValidFromMm).HasColumnName(@"FeePaymentCardValidFromMM").HasColumnType("int").IsOptional();
            Property(x => x.FeePaymentCardValidFromYy).HasColumnName(@"FeePaymentCardValidFromYY").HasColumnType("int").IsOptional();
            Property(x => x.FeePaymentCardExpireMm).HasColumnName(@"FeePaymentCardExpireMM").HasColumnType("int").IsOptional();
            Property(x => x.FeePaymentCardExpireYy).HasColumnName(@"FeePaymentCardExpireYY").HasColumnType("int").IsOptional();
            Property(x => x.FeePaymentSecurityNumber).HasColumnName(@"FeePaymentSecurityNumber").HasColumnType("int").IsOptional();
            Property(x => x.FeePaymentIssueNumber).HasColumnName(@"FeePaymentIssueNumber").HasColumnType("int").IsOptional();
            Property(x => x.FeePaymentDebitHappy).HasColumnName(@"FeePaymentDebitHappy").HasColumnType("tinyint").IsOptional();
            Property(x => x.LoanPaymentMethod).HasColumnName(@"LoanPaymentMethod").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.LoanSortCode).HasColumnName(@"LoanSortCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.LoanBankName).HasColumnName(@"LoanBankName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.LoanAccountNumber).HasColumnName(@"LoanAccountNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.LoanAccountName).HasColumnName(@"LoanAccountName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.InsuranceQuestionAnswer1).HasColumnName(@"InsuranceQuestionAnswer1").HasColumnType("tinyint").IsOptional();
            Property(x => x.InsuranceQustionAnswer2).HasColumnName(@"InsuranceQustionAnswer2").HasColumnType("tinyint").IsOptional();
            Property(x => x.InsuranceQuestionAnswer3).HasColumnName(@"InsuranceQuestionAnswer3").HasColumnType("tinyint").IsOptional();
            Property(x => x.InsuranceNotes).HasColumnName(@"InsuranceNotes").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2000);
            Property(x => x.InsuranceAccepted).HasColumnName(@"InsuranceAccepted").HasColumnType("tinyint").IsOptional();
            Property(x => x.CapitalQuestionAnswer1).HasColumnName(@"CapitalQuestionAnswer1").HasColumnType("tinyint").IsOptional();
            Property(x => x.CapitalQuestionAnswer2).HasColumnName(@"CapitalQuestionAnswer2").HasColumnType("tinyint").IsOptional();
            Property(x => x.CapitalQuestionAnswer3).HasColumnName(@"CapitalQuestionAnswer3").HasColumnType("tinyint").IsOptional();
            Property(x => x.CapitalAcceptance).HasColumnName(@"CapitalAcceptance").HasColumnType("tinyint").IsOptional();
            Property(x => x.ExceedRetirementAcceptance).HasColumnName(@"ExceedRetirementAcceptance").HasColumnType("tinyint").IsOptional();
            Property(x => x.SelfCertificationAccepted).HasColumnName(@"SelfCertificationAccepted").HasColumnType("tinyint").IsOptional();
            Property(x => x.RepaymentInRetirement).HasColumnName(@"RepaymentInRetirement").HasColumnType("tinyint").IsOptional();
            Property(x => x.CapitalNotes).HasColumnName(@"CapitalNotes").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2000);
        }
    }

}
