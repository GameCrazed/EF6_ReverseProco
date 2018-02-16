

namespace Generator
{

    public class EaIllustrationMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaIllustration>
    {
        public EaIllustrationMapping()
            : this("dbo")
        {
        }

        public EaIllustrationMapping(string schema)
        {
            ToTable("ea_illustration", schema);
            HasKey(x => x.ApplicationId);

            Property(x => x.ApplicationId).HasColumnName(@"ApplicationID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BrokerCompanyBrok010).HasColumnName(@"BrokerCompanyBrok010").HasColumnType("int").IsOptional();
            Property(x => x.Fee1).HasColumnName(@"Fee1").HasColumnType("float").IsRequired();
            Property(x => x.GrossLoan).HasColumnName(@"GrossLoan").HasColumnType("float").IsRequired();
            Property(x => x.CreditAgreementRef).HasColumnName(@"CreditAgreementRef").HasColumnType("int").IsOptional();
            Property(x => x.Apr).HasColumnName(@"Apr").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.NormalRepayment).HasColumnName(@"NormalRepayment").HasColumnType("float").IsRequired();
            Property(x => x.FirstRepayment).HasColumnName(@"FirstRepayment").HasColumnType("float").IsRequired();
            Property(x => x.ProductIdProd000).HasColumnName(@"ProductIdPROD000").HasColumnType("int").IsRequired();
            Property(x => x.LoanPlanIdLpla000).HasColumnName(@"LoanPlanIdLPLA000").HasColumnType("int").IsRequired();
            Property(x => x.MarginOverBaseRate).HasColumnName(@"MarginOverBaseRate").HasColumnType("decimal").IsOptional().HasPrecision(9,6);
            Property(x => x.InterestRate).HasColumnName(@"InterestRate").HasColumnType("decimal").IsOptional().HasPrecision(9,6);
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.Division).HasColumnName(@"Division").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
        }
    }

}
