

namespace Generator
{

    public class SgBrokerRecordMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SgBrokerRecord>
    {
        public SgBrokerRecordMapping()
            : this("dbo")
        {
        }

        public SgBrokerRecordMapping(string schema)
        {
            ToTable("sgBrokerRecords", schema);
            HasKey(x => new { x.DefaultNominal, x.TaxCode, x.TermsAgreed63 });

            Property(x => x.CompletionDate).HasColumnName(@"completionDate").HasColumnType("datetime").IsOptional();
            Property(x => x.BrokerFirm).HasColumnName(@"brokerFirm").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.BrokerAgent).HasColumnName(@"brokerAgent").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(101);
            Property(x => x.AccountReference).HasColumnName(@"Account Reference").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(51);
            Property(x => x.AccountName).HasColumnName(@"Account Name").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Street1).HasColumnName(@"Street 1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Street2).HasColumnName(@"Street 2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Town).HasColumnName(@"Town").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.County).HasColumnName(@"County").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Postcode).HasColumnName(@"Postcode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ContactName).HasColumnName(@"Contact Name").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.TelephoneNumber).HasColumnName(@"Telephone Number").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1);
            Property(x => x.DefaultNominal).HasColumnName(@"Default Nominal").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TaxCode).HasColumnName(@"Tax Code").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.EMail).HasColumnName(@"EMail").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1);
            Property(x => x.TermsAgreed63).HasColumnName(@"Terms Agreed?").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BankAccountName).HasColumnName(@"Bank Account Name").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.BankSortCode).HasColumnName(@"Bank Sort Code").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(8);
            Property(x => x.BankAccountNo).HasColumnName(@"Bank Account No").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
        }
    }

}
