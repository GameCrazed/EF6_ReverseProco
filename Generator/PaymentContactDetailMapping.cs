

namespace Generator
{

    public class PaymentContactDetailMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PaymentContactDetail>
    {
        public PaymentContactDetailMapping()
            : this("dbo")
        {
        }

        public PaymentContactDetailMapping(string schema)
        {
            ToTable("paymentContactDetails", schema);
            HasKey(x => new { x.CompanyAddress3, x.CompanyContactEmail, x.CompanyContactTelephone, x.CompanyType, x.CompanyInSage });

            Property(x => x.BrokerRef).HasColumnName(@"brokerRef").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CompanyName).HasColumnName(@"companyName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CompanyAddress1).HasColumnName(@"companyAddress1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CompanyAddress2).HasColumnName(@"companyAddress2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CompanyAddress3).HasColumnName(@"companyAddress3").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompanyTownCity).HasColumnName(@"companyTownCity").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CompanyCounty).HasColumnName(@"companyCounty").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CompanyPostcode).HasColumnName(@"companyPostcode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CompanyBankPayee).HasColumnName(@"companyBankPayee").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.CompanyContactName).HasColumnName(@"companyContactName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CompanyContactEmail).HasColumnName(@"companyContactEmail").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompanyContactTelephone).HasColumnName(@"companyContactTelephone").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompanyBankSortCode).HasColumnName(@"companyBankSortCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(8);
            Property(x => x.CompanyBankAccountNumber).HasColumnName(@"companyBankAccountNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.CompanyType).HasColumnName(@"companyType").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(7).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompanySageRef).HasColumnName(@"companySageRef").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(51);
            Property(x => x.CompanyInSage).HasColumnName(@"companyInSage").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
