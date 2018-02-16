

namespace Generator
{

    public class NbspMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbsp>
    {
        public NbspMapping()
            : this("dbo")
        {
        }

        public NbspMapping(string schema)
        {
            ToTable("NBSP", schema);
            HasKey(x => x.Nbsp999);

            Property(x => x.Nbsp001).HasColumnName(@"NBSP001").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp002).HasColumnName(@"NBSP002").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp003).HasColumnName(@"NBSP003").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp004).HasColumnName(@"NBSP004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Nbsp005).HasColumnName(@"NBSP005").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp007).HasColumnName(@"NBSP007").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp010).HasColumnName(@"NBSP010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbsp020).HasColumnName(@"NBSP020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbsp030).HasColumnName(@"NBSP030").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp040).HasColumnName(@"NBSP040").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp050).HasColumnName(@"NBSP050").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp054).HasColumnName(@"NBSP054").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp060).HasColumnName(@"NBSP060").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbsp061).HasColumnName(@"NBSP061").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbsp063).HasColumnName(@"NBSP063").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Nbsp065).HasColumnName(@"NBSP065").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbsp067).HasColumnName(@"NBSP067").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbsp068).HasColumnName(@"NBSP068").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbsp070).HasColumnName(@"NBSP070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Nbsp071).HasColumnName(@"NBSP071").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbsp072).HasColumnName(@"NBSP072").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Nbsp074).HasColumnName(@"NBSP074").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbsp075).HasColumnName(@"NBSP075").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp076).HasColumnName(@"NBSP076").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp077).HasColumnName(@"NBSP077").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp078).HasColumnName(@"NBSP078").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbsp079).HasColumnName(@"NBSP079").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbsp080).HasColumnName(@"NBSP080").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbsp081).HasColumnName(@"NBSP081").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbsp082).HasColumnName(@"NBSP082").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp090).HasColumnName(@"NBSP090").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbsp091).HasColumnName(@"NBSP091").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp100).HasColumnName(@"NBSP100").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbsp110).HasColumnName(@"NBSP110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Nbsp120).HasColumnName(@"NBSP120").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbsp125).HasColumnName(@"NBSP125").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbsp127).HasColumnName(@"NBSP127").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbsp130).HasColumnName(@"NBSP130").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbsp140).HasColumnName(@"NBSP140").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbsp145).HasColumnName(@"NBSP145").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbsp146).HasColumnName(@"NBSP146").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Nbsp147).HasColumnName(@"NBSP147").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbsp148).HasColumnName(@"NBSP148").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbsp150).HasColumnName(@"NBSP150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbsp160).HasColumnName(@"NBSP160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Nbsp165).HasColumnName(@"NBSP165").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbsp170).HasColumnName(@"NBSP170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Nbsp175).HasColumnName(@"NBSP175").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbsp180).HasColumnName(@"NBSP180").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Nbsp190).HasColumnName(@"NBSP190").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp200).HasColumnName(@"NBSP200").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbsp210).HasColumnName(@"NBSP210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbsp220).HasColumnName(@"NBSP220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbsp230).HasColumnName(@"NBSP230").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbsp240).HasColumnName(@"NBSP240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbsp250).HasColumnName(@"NBSP250").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbsp260).HasColumnName(@"NBSP260").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbsp270).HasColumnName(@"NBSP270").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbsp280).HasColumnName(@"NBSP280").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbsp310).HasColumnName(@"NBSP310").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp320).HasColumnName(@"NBSP320").HasColumnType("int").IsRequired();
            Property(x => x.Nbsp330).HasColumnName(@"NBSP330").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbsp340).HasColumnName(@"NBSP340").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbsp350).HasColumnName(@"NBSP350").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbsp360).HasColumnName(@"NBSP360").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbsp370).HasColumnName(@"NBSP370").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbsp380).HasColumnName(@"NBSP380").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Nbsp560).HasColumnName(@"NBSP560").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbsp600).HasColumnName(@"NBSP600").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Nbsp999).HasColumnName(@"NBSP999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbsp351).HasColumnName(@"NBSP351").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbsp352).HasColumnName(@"NBSP352").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbsp353).HasColumnName(@"NBSP353").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbsp354).HasColumnName(@"NBSP354").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbsp355).HasColumnName(@"NBSP355").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbsp356).HasColumnName(@"NBSP356").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbsp357).HasColumnName(@"NBSP357").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbsp358).HasColumnName(@"NBSP358").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbsp359).HasColumnName(@"NBSP359").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbsp048).HasColumnName(@"NBSP048").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Nbsp017).HasColumnName(@"NBSP017").HasColumnType("int").IsRequired();
        }
    }

}
