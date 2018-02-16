

namespace Generator
{

    public class LandMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Land>
    {
        public LandMapping()
            : this("dbo")
        {
        }

        public LandMapping(string schema)
        {
            ToTable("LAND", schema);
            HasKey(x => x.Land010);

            Property(x => x.Land010).HasColumnName(@"LAND010").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Land020).HasColumnName(@"LAND020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Land030).HasColumnName(@"LAND030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Landdtm).HasColumnName(@"LANDDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Land040).HasColumnName(@"LAND040").HasColumnType("int").IsRequired();
        }
    }

}
