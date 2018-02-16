

namespace Generator
{

    public class BrokerBdmDataDeprecatedMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BrokerBdmDataDeprecated>
    {
        public BrokerBdmDataDeprecatedMapping()
            : this("dbo")
        {
        }

        public BrokerBdmDataDeprecatedMapping(string schema)
        {
            ToTable("brokerBDMDataDeprecated", schema);
            HasKey(x => x.BdmId);

            Property(x => x.BdmId).HasColumnName(@"bdmID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BrokerCompanyShortName).HasColumnName(@"brokerCompanyShortName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerAgentForename).HasColumnName(@"brokerAgentForename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerAgentSurname).HasColumnName(@"brokerAgentSurname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BdmName).HasColumnName(@"bdmName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.ErClubMember).HasColumnName(@"erClubMember").HasColumnType("bit").IsOptional();
            Property(x => x.PremierClubMember).HasColumnName(@"premierClubMember").HasColumnType("bit").IsOptional();
            Property(x => x.Created).HasColumnName(@"Created").HasColumnType("datetime").IsOptional();
            Property(x => x.Updated).HasColumnName(@"Updated").HasColumnType("timestamp").IsRequired().IsFixedLength().HasMaxLength(8).IsRowVersion().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.IsFieldBased).HasColumnName(@"IsFieldBased").HasColumnType("int").IsRequired();
        }
    }

}
