

namespace Generator
{

    public class BrokerManagerMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BrokerManager>
    {
        public BrokerManagerMapping()
            : this("dbo")
        {
        }

        public BrokerManagerMapping(string schema)
        {
            ToTable("BrokerManagers", schema);
            HasKey(x => x.BrokerManagerId);

            Property(x => x.BrokerManagerId).HasColumnName(@"BrokerManagerId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar(max)").IsOptional();
        }
    }

}
