

namespace Generator
{

    public class GushThresholdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<GushThreshold>
    {
        public GushThresholdMapping()
            : this("dbo")
        {
        }

        public GushThresholdMapping(string schema)
        {
            ToTable("GushThresholds", schema);
            HasKey(x => x.GushThresholdId);

            Property(x => x.GushThresholdId).HasColumnName(@"GushThresholdId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Value).HasColumnName(@"Value").HasColumnType("decimal").IsRequired().HasPrecision(18,2);
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsRequired();
        }
    }

}
