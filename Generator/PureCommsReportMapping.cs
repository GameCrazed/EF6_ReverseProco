

namespace Generator
{

    public class PureCommsReportMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PureCommsReport>
    {
        public PureCommsReportMapping()
            : this("dbo")
        {
        }

        public PureCommsReportMapping(string schema)
        {
            ToTable("pureCommsReport", schema);
            HasKey(x => x.AccountNumber);

            Property(x => x.AccountNumber).HasColumnName(@"Account Number").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompletionDate).HasColumnName(@"Completion Date").HasColumnType("datetime").IsOptional();
            Property(x => x.Surname).HasColumnName(@"Surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Postcode).HasColumnName(@"Postcode").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.LoanAmount).HasColumnName(@"Loan Amount").HasColumnType("numeric").IsOptional().HasPrecision(22,4);
            Property(x => x.Commission).HasColumnName(@"Commission").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.LoanPurpose).HasColumnName(@"LoanPurpose").HasColumnType("smallint").IsOptional();
            Property(x => x.IsInternalPlan).HasColumnName(@"IsInternalPlan").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Commission37).HasColumnName(@"Commission %").HasColumnType("numeric").IsOptional().HasPrecision(38,15);
            Property(x => x.BrokerFirm).HasColumnName(@"Broker Firm").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.BrokerAgent).HasColumnName(@"Broker Agent").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(101);
            Property(x => x.CompanyToPay).HasColumnName(@"Company To Pay").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.PayType).HasColumnName(@"Pay Type").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(7);
            Property(x => x.CompletionDateString).HasColumnName(@"Completion Date String").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CompanySageRef).HasColumnName(@"companySageRef").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(51);
            Property(x => x.OriginalBrokerFirm).HasColumnName(@"Original Broker Firm").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
        }
    }

}
