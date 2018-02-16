

namespace Generator
{

    public class BrokerNetworkDataMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BrokerNetworkData>
    {
        public BrokerNetworkDataMapping()
            : this("dbo")
        {
        }

        public BrokerNetworkDataMapping(string schema)
        {
            ToTable("brokerNetworkData", schema);
            HasKey(x => x.NetworkId);

            Property(x => x.NetworkId).HasColumnName(@"networkID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NetworkName).HasColumnName(@"networkName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NetworkContactName).HasColumnName(@"networkContactName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NetworkContactEmail).HasColumnName(@"networkContactEmail").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NetworkContactTelephone).HasColumnName(@"networkContactTelephone").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NetworkBankPayee).HasColumnName(@"networkBankPayee").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NetworkBankSortCode).HasColumnName(@"networkBankSortCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NetworkBankAccountNumber).HasColumnName(@"networkBankAccountNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NetworkAddress1).HasColumnName(@"networkAddress1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NetworkAddress2).HasColumnName(@"networkAddress2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NetworkAddress3).HasColumnName(@"networkAddress3").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NetworkTownCity).HasColumnName(@"networkTownCity").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NetworkCounty).HasColumnName(@"networkCounty").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NetworkPostcode).HasColumnName(@"networkPostcode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NetworkDateRegistered).HasColumnName(@"networkDateRegistered").HasColumnType("datetime").IsOptional();
            Property(x => x.NetworkLastAnnualCheck).HasColumnName(@"networkLastAnnualCheck").HasColumnType("datetime").IsOptional();
            Property(x => x.NetworkCompleted).HasColumnName(@"networkCompleted").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NetworkToBToBeSent).HasColumnName(@"networkToBToBeSent").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
        }
    }

}
