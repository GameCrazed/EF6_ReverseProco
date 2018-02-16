

namespace Generator
{

    public class VuseMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Vuse>
    {
        public VuseMapping()
            : this("dbo")
        {
        }

        public VuseMapping(string schema)
        {
            ToTable("VUSE", schema);
            HasKey(x => new { x.Vuse030, x.Vuse010, x.Vuse020 });

            Property(x => x.Vuse010).HasColumnName(@"VUSE010").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Vuse020).HasColumnName(@"VUSE020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Vuse030).HasColumnName(@"VUSE030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Vuse040).HasColumnName(@"VUSE040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Vusedtm).HasColumnName(@"VUSEDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
