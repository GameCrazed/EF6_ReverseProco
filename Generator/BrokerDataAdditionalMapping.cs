

namespace Generator
{

    public class BrokerDataAdditionalMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BrokerDataAdditional>
    {
        public BrokerDataAdditionalMapping()
            : this("dbo")
        {
        }

        public BrokerDataAdditionalMapping(string schema)
        {
            ToTable("brokerDataAdditional", schema);
            HasKey(x => x.BrokerAdditionalId);

            Property(x => x.BrokerAdditionalId).HasColumnName(@"brokerAdditionalID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BrokerRef).HasColumnName(@"brokerRef").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerBankPayee).HasColumnName(@"brokerBankPayee").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.SageRef).HasColumnName(@"sageRef").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
        }
    }

}
