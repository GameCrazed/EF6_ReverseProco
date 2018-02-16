

namespace Generator
{

    public class EfaxMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Efax>
    {
        public EfaxMapping()
            : this("dbo")
        {
        }

        public EfaxMapping(string schema)
        {
            ToTable("EFAX", schema);
            HasKey(x => new { x.Efax001, x.Efax010 });

            Property(x => x.Efax001).HasColumnName(@"EFAX001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Efax002).HasColumnName(@"EFAX002").HasColumnType("int").IsRequired();
            Property(x => x.Efax003).HasColumnName(@"EFAX003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax005).HasColumnName(@"EFAX005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Efax010).HasColumnName(@"EFAX010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Efax011).HasColumnName(@"EFAX011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Efax012).HasColumnName(@"EFAX012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax013).HasColumnName(@"EFAX013").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax020).HasColumnName(@"EFAX020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Efax030).HasColumnName(@"EFAX030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Efax040).HasColumnName(@"EFAX040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Efax050).HasColumnName(@"EFAX050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Efax060).HasColumnName(@"EFAX060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Efax070).HasColumnName(@"EFAX070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax080).HasColumnName(@"EFAX080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax081).HasColumnName(@"EFAX081").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax082).HasColumnName(@"EFAX082").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax083).HasColumnName(@"EFAX083").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax084).HasColumnName(@"EFAX084").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax085).HasColumnName(@"EFAX085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax086).HasColumnName(@"EFAX086").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax087).HasColumnName(@"EFAX087").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax090).HasColumnName(@"EFAX090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax100).HasColumnName(@"EFAX100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(11);
            Property(x => x.Efax110).HasColumnName(@"EFAX110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax120).HasColumnName(@"EFAX120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Efax130).HasColumnName(@"EFAX130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Efax140).HasColumnName(@"EFAX140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(11);
            Property(x => x.Efax150).HasColumnName(@"EFAX150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Efax160).HasColumnName(@"EFAX160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax170).HasColumnName(@"EFAX170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Efax180).HasColumnName(@"EFAX180").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Efax190).HasColumnName(@"EFAX190").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Efax200).HasColumnName(@"EFAX200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Efax210).HasColumnName(@"EFAX210").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Efax220).HasColumnName(@"EFAX220").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Efax230).HasColumnName(@"EFAX230").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Efax240).HasColumnName(@"EFAX240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Efax250).HasColumnName(@"EFAX250").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Efax260).HasColumnName(@"EFAX260").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
        }
    }

}
