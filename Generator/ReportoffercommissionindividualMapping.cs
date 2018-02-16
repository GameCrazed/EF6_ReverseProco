

namespace Generator
{

    public class ReportoffercommissionindividualMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Reportoffercommissionindividual>
    {
        public ReportoffercommissionindividualMapping()
            : this("dbo")
        {
        }

        public ReportoffercommissionindividualMapping(string schema)
        {
            ToTable("reportoffercommissionindividual", schema);
            HasKey(x => new { x.AccountNumber, x.OfferDate, x.Postcode, x.LoanAmount, x.Commission, x.BrokerIndividualName });

            Property(x => x.AccountNumber).HasColumnName(@"Account Number").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OfferDate).HasColumnName(@"Offer Date").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DateOfFirstOffer).HasColumnName(@"Date of first offer").HasColumnType("datetime").IsOptional();
            Property(x => x.Surname).HasColumnName(@"Surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Postcode).HasColumnName(@"Postcode").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LoanAmount).HasColumnName(@"Loan Amount").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Commission).HasColumnName(@"Commission").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Commission37).HasColumnName(@"Commission %").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.BrokerIndividualName).HasColumnName(@"Broker individual name").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(101).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BrokerFirm).HasColumnName(@"Broker Firm").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(20);
        }
    }

}
