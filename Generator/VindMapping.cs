

namespace Generator
{

    public class VindMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Vind>
    {
        public VindMapping()
            : this("dbo")
        {
        }

        public VindMapping(string schema)
        {
            ToTable("VIND", schema);
            HasKey(x => new { x.Vind010, x.Vind020 });

            Property(x => x.Vind010).HasColumnName(@"VIND010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Vind020).HasColumnName(@"VIND020").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Vind030).HasColumnName(@"VIND030").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Vind040).HasColumnName(@"VIND040").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Vind050).HasColumnName(@"VIND050").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Vind090).HasColumnName(@"VIND090").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Vinddtm).HasColumnName(@"VINDDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Vind110).HasColumnName(@"VIND110").HasColumnType("datetime").IsRequired();
            Property(x => x.Vind120).HasColumnName(@"VIND120").HasColumnType("datetime").IsRequired();
        }
    }

}
