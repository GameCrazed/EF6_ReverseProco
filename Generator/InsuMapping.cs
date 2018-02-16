

namespace Generator
{

    public class InsuMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Insu>
    {
        public InsuMapping()
            : this("dbo")
        {
        }

        public InsuMapping(string schema)
        {
            ToTable("INSU", schema);
            HasKey(x => x.Insu000);

            Property(x => x.Insu000).HasColumnName(@"INSU000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Insu001).HasColumnName(@"INSU001").HasColumnType("int").IsRequired();
            Property(x => x.Insu004).HasColumnName(@"INSU004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Insu008).HasColumnName(@"INSU008").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu010).HasColumnName(@"INSU010").HasColumnType("smallint").IsRequired();
            Property(x => x.Insu020).HasColumnName(@"INSU020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Insu030).HasColumnName(@"INSU030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Insu035).HasColumnName(@"INSU035").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Insu040).HasColumnName(@"INSU040").HasColumnType("int").IsRequired();
            Property(x => x.Insu050).HasColumnName(@"INSU050").HasColumnType("int").IsRequired();
            Property(x => x.Insu051).HasColumnName(@"INSU051").HasColumnType("int").IsRequired();
            Property(x => x.Insu060).HasColumnName(@"INSU060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu070).HasColumnName(@"INSU070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Insu075).HasColumnName(@"INSU075").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu077).HasColumnName(@"INSU077").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Insu079).HasColumnName(@"INSU079").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu080).HasColumnName(@"INSU080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Insu089).HasColumnName(@"INSU089").HasColumnType("smallint").IsRequired();
            Property(x => x.Insu090).HasColumnName(@"INSU090").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu095).HasColumnName(@"INSU095").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu100).HasColumnName(@"INSU100").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu105).HasColumnName(@"INSU105").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu110).HasColumnName(@"INSU110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Insu120).HasColumnName(@"INSU120").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu150).HasColumnName(@"INSU150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Insu155).HasColumnName(@"INSU155").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu160).HasColumnName(@"INSU160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu170).HasColumnName(@"INSU170").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Insu171).HasColumnName(@"INSU171").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu175).HasColumnName(@"INSU175").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu180).HasColumnName(@"INSU180").HasColumnType("int").IsRequired();
            Property(x => x.Insu200).HasColumnName(@"INSU200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu210).HasColumnName(@"INSU210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu230).HasColumnName(@"INSU230").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Insu240).HasColumnName(@"INSU240").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Insu250).HasColumnName(@"INSU250").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu300).HasColumnName(@"INSU300").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu310).HasColumnName(@"INSU310").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu320).HasColumnName(@"INSU320").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu330).HasColumnName(@"INSU330").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu340).HasColumnName(@"INSU340").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu350).HasColumnName(@"INSU350").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Insu355).HasColumnName(@"INSU355").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu400).HasColumnName(@"INSU400").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu410).HasColumnName(@"INSU410").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu420).HasColumnName(@"INSU420").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu500).HasColumnName(@"INSU500").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Insu071).HasColumnName(@"INSU071").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu130).HasColumnName(@"INSU130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu305).HasColumnName(@"INSU305").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Insu450).HasColumnName(@"INSU450").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Insu510).HasColumnName(@"INSU510").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Insu520).HasColumnName(@"INSU520").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Insu530).HasColumnName(@"INSU530").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Insu540).HasColumnName(@"INSU540").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Insu550).HasColumnName(@"INSU550").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Insu215).HasColumnName(@"INSU215").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(41);
            Property(x => x.Insu085).HasColumnName(@"INSU085").HasColumnType("datetime").IsRequired();
            Property(x => x.Insu065).HasColumnName(@"INSU065").HasColumnType("tinyint").IsRequired();
            Property(x => x.Insu560).HasColumnName(@"INSU560").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Insu570).HasColumnName(@"INSU570").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
