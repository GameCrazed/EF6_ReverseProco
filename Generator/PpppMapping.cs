

namespace Generator
{

    public class PpppMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pppp>
    {
        public PpppMapping()
            : this("dbo")
        {
        }

        public PpppMapping(string schema)
        {
            ToTable("PPPP", schema);
            HasKey(x => x.Pppp001);

            Property(x => x.Pppp001).HasColumnName(@"PPPP001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Pppp010).HasColumnName(@"PPPP010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pppp020).HasColumnName(@"PPPP020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Pppp030).HasColumnName(@"PPPP030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Pppp040).HasColumnName(@"PPPP040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pppp050).HasColumnName(@"PPPP050").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pppp060).HasColumnName(@"PPPP060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pppp070).HasColumnName(@"PPPP070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pppp080).HasColumnName(@"PPPP080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pppp090).HasColumnName(@"PPPP090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pppp100).HasColumnName(@"PPPP100").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pppp110).HasColumnName(@"PPPP110").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pppp120).HasColumnName(@"PPPP120").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pppp085).HasColumnName(@"PPPP085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Pppp091).HasColumnName(@"PPPP091").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pppp092).HasColumnName(@"PPPP092").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pppp093).HasColumnName(@"PPPP093").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Pppp096).HasColumnName(@"PPPP096").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pppp097).HasColumnName(@"PPPP097").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pppp098).HasColumnName(@"PPPP098").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Pppp115).HasColumnName(@"PPPP115").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pppp140).HasColumnName(@"PPPP140").HasColumnType("int").IsRequired();
            Property(x => x.Pppp400).HasColumnName(@"PPPP400").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pppp410).HasColumnName(@"PPPP410").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pppp420).HasColumnName(@"PPPP420").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pppp450).HasColumnName(@"PPPP450").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pppp460).HasColumnName(@"PPPP460").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pppp500).HasColumnName(@"PPPP500").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pppp510).HasColumnName(@"PPPP510").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pppp520).HasColumnName(@"PPPP520").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pppp550).HasColumnName(@"PPPP550").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pppp560).HasColumnName(@"PPPP560").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
        }
    }

}
