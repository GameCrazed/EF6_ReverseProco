

namespace Generator
{

    public class GushMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Gush>
    {
        public GushMapping()
            : this("dbo")
        {
        }

        public GushMapping(string schema)
        {
            ToTable("Gushes", schema);
            HasKey(x => x.GushId);

            Property(x => x.GushId).HasColumnName(@"GushId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Reason).HasColumnName(@"Reason").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.GushThresholdId).HasColumnName(@"GushThresholdId").HasColumnType("int").IsRequired();

            HasRequired(a => a.GushThreshold).WithMany(b => b.Gushes).HasForeignKey(c => c.GushThresholdId);
        }
    }

}
