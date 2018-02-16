

namespace Generator
{

    public class AcquMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Acqu>
    {
        public AcquMapping()
            : this("dbo")
        {
        }

        public AcquMapping(string schema)
        {
            ToTable("ACQU", schema);
            HasKey(x => x.Acqu001);

            Property(x => x.Acqu001).HasColumnName(@"ACQU001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Acqu010).HasColumnName(@"ACQU010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Acqu020).HasColumnName(@"ACQU020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Acqudtm).HasColumnName(@"ACQUDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
