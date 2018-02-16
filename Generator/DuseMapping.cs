

namespace Generator
{

    public class DuseMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Duse>
    {
        public DuseMapping()
            : this("dbo")
        {
        }

        public DuseMapping(string schema)
        {
            ToTable("DUSE", schema);
            HasKey(x => new { x.Duse010, x.Duse030 });

            Property(x => x.Duse010).HasColumnName(@"DUSE010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Duse020).HasColumnName(@"DUSE020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Duse030).HasColumnName(@"DUSE030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Dusedtm).HasColumnName(@"DUSEDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
