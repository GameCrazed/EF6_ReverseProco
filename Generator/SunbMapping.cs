

namespace Generator
{

    public class SunbMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sunb>
    {
        public SunbMapping()
            : this("dbo")
        {
        }

        public SunbMapping(string schema)
        {
            ToTable("SUNB", schema);
            HasKey(x => x.Sunb010);

            Property(x => x.Sunb010).HasColumnName(@"SUNB010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Sunb020).HasColumnName(@"SUNB020").HasColumnType("tinyint").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Sunbdtm).HasColumnName(@"SUNBDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
