

namespace Generator
{

    public class LgvrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Lgvr>
    {
        public LgvrMapping()
            : this("dbo")
        {
        }

        public LgvrMapping(string schema)
        {
            ToTable("LGVR", schema);
            HasKey(x => x.Lgvr000);

            Property(x => x.Lgvr000).HasColumnName(@"LGVR000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Lgvr001).HasColumnName(@"LGVR001").HasColumnType("int").IsRequired();
            Property(x => x.Lgvr002).HasColumnName(@"LGVR002").HasColumnType("datetime").IsRequired();
            Property(x => x.Lgvr003).HasColumnName(@"LGVR003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr004).HasColumnName(@"LGVR004").HasColumnType("int").IsRequired();
            Property(x => x.Lgvr010).HasColumnName(@"LGVR010").HasColumnType("int").IsRequired();
            Property(x => x.Lgvr020).HasColumnName(@"LGVR020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr030).HasColumnName(@"LGVR030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr040).HasColumnName(@"LGVR040").HasColumnType("int").IsRequired();
            Property(x => x.Lgvr050).HasColumnName(@"LGVR050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Lgvr060).HasColumnName(@"LGVR060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr070).HasColumnName(@"LGVR070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr080).HasColumnName(@"LGVR080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr090).HasColumnName(@"LGVR090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr100).HasColumnName(@"LGVR100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Lgvr110).HasColumnName(@"LGVR110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr120).HasColumnName(@"LGVR120").HasColumnType("int").IsRequired();
            Property(x => x.Lgvr130).HasColumnName(@"LGVR130").HasColumnType("int").IsRequired();
            Property(x => x.Lgvr140).HasColumnName(@"LGVR140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr150).HasColumnName(@"LGVR150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr160).HasColumnName(@"LGVR160").HasColumnType("int").IsRequired();
            Property(x => x.Lgvr170).HasColumnName(@"LGVR170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr180).HasColumnName(@"LGVR180").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr190).HasColumnName(@"LGVR190").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Lgvr200).HasColumnName(@"LGVR200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Lgvr210).HasColumnName(@"LGVR210").HasColumnType("int").IsRequired();
            Property(x => x.Lgvr220).HasColumnName(@"LGVR220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Lgvr230).HasColumnName(@"LGVR230").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Lgvr240).HasColumnName(@"LGVR240").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Lgvr250).HasColumnName(@"LGVR250").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr260).HasColumnName(@"LGVR260").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr270).HasColumnName(@"LGVR270").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr280).HasColumnName(@"LGVR280").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr290).HasColumnName(@"LGVR290").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr300).HasColumnName(@"LGVR300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Lgvr310).HasColumnName(@"LGVR310").HasColumnType("decimal").IsRequired().HasPrecision(9,4);
            Property(x => x.Lgvr320).HasColumnName(@"LGVR320").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr330).HasColumnName(@"LGVR330").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr340).HasColumnName(@"LGVR340").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr350).HasColumnName(@"LGVR350").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr360).HasColumnName(@"LGVR360").HasColumnType("decimal").IsRequired().HasPrecision(9,4);
            Property(x => x.Lgvr370).HasColumnName(@"LGVR370").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr380).HasColumnName(@"LGVR380").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Lgvr390).HasColumnName(@"LGVR390").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr400).HasColumnName(@"LGVR400").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr410).HasColumnName(@"LGVR410").HasColumnType("decimal").IsRequired().HasPrecision(9,4);
            Property(x => x.Lgvr420).HasColumnName(@"LGVR420").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Lgvr430).HasColumnName(@"LGVR430").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Lgvr440).HasColumnName(@"LGVR440").HasColumnType("decimal").IsRequired().HasPrecision(9,4);
            Property(x => x.Lgvr450).HasColumnName(@"LGVR450").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Lgvr460).HasColumnName(@"LGVR460").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr470).HasColumnName(@"LGVR470").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr480).HasColumnName(@"LGVR480").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr490).HasColumnName(@"LGVR490").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr500).HasColumnName(@"LGVR500").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr510).HasColumnName(@"LGVR510").HasColumnType("decimal").IsRequired().HasPrecision(9,4);
            Property(x => x.Lgvr520).HasColumnName(@"LGVR520").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr530).HasColumnName(@"LGVR530").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr540).HasColumnName(@"LGVR540").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr550).HasColumnName(@"LGVR550").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr560).HasColumnName(@"LGVR560").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr570).HasColumnName(@"LGVR570").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Lgvr580).HasColumnName(@"LGVR580").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr590).HasColumnName(@"LGVR590").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr600).HasColumnName(@"LGVR600").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr610).HasColumnName(@"LGVR610").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr620).HasColumnName(@"LGVR620").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr630).HasColumnName(@"LGVR630").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr640).HasColumnName(@"LGVR640").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr650).HasColumnName(@"LGVR650").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr660).HasColumnName(@"LGVR660").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgvr670).HasColumnName(@"LGVR670").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr680).HasColumnName(@"LGVR680").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr690).HasColumnName(@"LGVR690").HasColumnType("int").IsRequired();
            Property(x => x.Lgvr700).HasColumnName(@"LGVR700").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr710).HasColumnName(@"LGVR710").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr720).HasColumnName(@"LGVR720").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr730).HasColumnName(@"LGVR730").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgvr740).HasColumnName(@"LGVR740").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
