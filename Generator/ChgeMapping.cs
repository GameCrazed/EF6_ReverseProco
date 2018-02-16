

namespace Generator
{

    public class ChgeMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Chge>
    {
        public ChgeMapping()
            : this("dbo")
        {
        }

        public ChgeMapping(string schema)
        {
            ToTable("CHGE", schema);
            HasKey(x => x.Chge001);

            Property(x => x.Chge001).HasColumnName(@"CHGE001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Chge005).HasColumnName(@"CHGE005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Chge010).HasColumnName(@"CHGE010").HasColumnType("int").IsRequired();
            Property(x => x.Chge020).HasColumnName(@"CHGE020").HasColumnType("int").IsRequired();
            Property(x => x.Chge030).HasColumnName(@"CHGE030").HasColumnType("int").IsRequired();
            Property(x => x.Chge040).HasColumnName(@"CHGE040").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chge050).HasColumnName(@"CHGE050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Chge140).HasColumnName(@"CHGE140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Chge150).HasColumnName(@"CHGE150").HasColumnType("datetime").IsRequired();
            Property(x => x.Chge160).HasColumnName(@"CHGE160").HasColumnType("datetime").IsRequired();
            Property(x => x.Chge170).HasColumnName(@"CHGE170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Chge190).HasColumnName(@"CHGE190").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Chge2001).HasColumnName(@"CHGE2001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Chge2002).HasColumnName(@"CHGE2002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Chge2003).HasColumnName(@"CHGE2003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Chge2004).HasColumnName(@"CHGE2004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Chge2005).HasColumnName(@"CHGE2005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Chge205).HasColumnName(@"CHGE205").HasColumnType("datetime").IsRequired();
            Property(x => x.Chge207).HasColumnName(@"CHGE207").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Chge208).HasColumnName(@"CHGE208").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Chge209).HasColumnName(@"CHGE209").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Chge210).HasColumnName(@"CHGE210").HasColumnType("datetime").IsRequired();
            Property(x => x.Chge220).HasColumnName(@"CHGE220").HasColumnType("datetime").IsRequired();
            Property(x => x.Chge300).HasColumnName(@"CHGE300").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chge310).HasColumnName(@"CHGE310").HasColumnType("datetime").IsRequired();
            Property(x => x.Chge320).HasColumnName(@"CHGE320").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge321).HasColumnName(@"CHGE321").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge330).HasColumnName(@"CHGE330").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge331).HasColumnName(@"CHGE331").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge340).HasColumnName(@"CHGE340").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge350).HasColumnName(@"CHGE350").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Chge360).HasColumnName(@"CHGE360").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chge370).HasColumnName(@"CHGE370").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Chge380).HasColumnName(@"CHGE380").HasColumnType("datetime").IsRequired();
            Property(x => x.Chge390).HasColumnName(@"CHGE390").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge400).HasColumnName(@"CHGE400").HasColumnType("datetime").IsRequired();
            Property(x => x.Chge410).HasColumnName(@"CHGE410").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge415).HasColumnName(@"CHGE415").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge430).HasColumnName(@"CHGE430").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge440).HasColumnName(@"CHGE440").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge450).HasColumnName(@"CHGE450").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge460).HasColumnName(@"CHGE460").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Chge470).HasColumnName(@"CHGE470").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge480).HasColumnName(@"CHGE480").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge500).HasColumnName(@"CHGE500").HasColumnType("int").IsRequired();
            Property(x => x.Chge510).HasColumnName(@"CHGE510").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge520).HasColumnName(@"CHGE520").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge560).HasColumnName(@"CHGE560").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge570).HasColumnName(@"CHGE570").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Chge580).HasColumnName(@"CHGE580").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge590).HasColumnName(@"CHGE590").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge4901).HasColumnName(@"CHGE4901").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Chge4902).HasColumnName(@"CHGE4902").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Chge4903).HasColumnName(@"CHGE4903").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Chge4904).HasColumnName(@"CHGE4904").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Chge4905).HasColumnName(@"CHGE4905").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Chge100).HasColumnName(@"CHGE100").HasColumnType("int").IsRequired();
            Property(x => x.Chge105).HasColumnName(@"CHGE105").HasColumnType("datetime").IsRequired();
            Property(x => x.Chge060).HasColumnName(@"CHGE060").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chgedtm).HasColumnName(@"CHGEDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Chge700).HasColumnName(@"CHGE700").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge710).HasColumnName(@"CHGE710").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chge900).HasColumnName(@"CHGE900").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chge165).HasColumnName(@"CHGE165").HasColumnType("datetime").IsRequired();
        }
    }

}
