

namespace Generator
{

    public class TenyMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Teny>
    {
        public TenyMapping()
            : this("dbo")
        {
        }

        public TenyMapping(string schema)
        {
            ToTable("TENY", schema);
            HasKey(x => x.Teny999);

            Property(x => x.Teny010).HasColumnName(@"TENY010").HasColumnType("int").IsRequired();
            Property(x => x.Teny020).HasColumnName(@"TENY020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Teny030).HasColumnName(@"TENY030").HasColumnType("int").IsRequired();
            Property(x => x.Teny040).HasColumnName(@"TENY040").HasColumnType("int").IsRequired();
            Property(x => x.Teny050).HasColumnName(@"TENY050").HasColumnType("int").IsRequired();
            Property(x => x.Teny060).HasColumnName(@"TENY060").HasColumnType("smallint").IsRequired();
            Property(x => x.Teny080).HasColumnName(@"TENY080").HasColumnType("datetime").IsRequired();
            Property(x => x.Teny100).HasColumnName(@"TENY100").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Teny110).HasColumnName(@"TENY110").HasColumnType("datetime").IsRequired();
            Property(x => x.Teny120).HasColumnName(@"TENY120").HasColumnType("smallint").IsRequired();
            Property(x => x.Teny130).HasColumnName(@"TENY130").HasColumnType("datetime").IsRequired();
            Property(x => x.Teny135).HasColumnName(@"TENY135").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Teny140).HasColumnName(@"TENY140").HasColumnType("datetime").IsRequired();
            Property(x => x.Teny145).HasColumnName(@"TENY145").HasColumnType("tinyint").IsRequired();
            Property(x => x.Teny150).HasColumnName(@"TENY150").HasColumnType("datetime").IsRequired();
            Property(x => x.Teny155).HasColumnName(@"TENY155").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Teny160).HasColumnName(@"TENY160").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Teny170).HasColumnName(@"TENY170").HasColumnType("datetime").IsRequired();
            Property(x => x.Teny200).HasColumnName(@"TENY200").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Teny210).HasColumnName(@"TENY210").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Teny3001).HasColumnName(@"TENY3001").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Teny3002).HasColumnName(@"TENY3002").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Teny3003).HasColumnName(@"TENY3003").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Teny3004).HasColumnName(@"TENY3004").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Teny3005).HasColumnName(@"TENY3005").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Teny500).HasColumnName(@"TENY500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Teny999).HasColumnName(@"TENY999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Teny011).HasColumnName(@"TENY011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Teny015).HasColumnName(@"TENY015").HasColumnType("smallint").IsRequired();
            Property(x => x.Teny016).HasColumnName(@"TENY016").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Teny018).HasColumnName(@"TENY018").HasColumnType("int").IsRequired();
            Property(x => x.Teny026).HasColumnName(@"TENY026").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Teny028).HasColumnName(@"TENY028").HasColumnType("datetime").IsRequired();
            Property(x => x.Teny029).HasColumnName(@"TENY029").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Teny035).HasColumnName(@"TENY035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Teny205).HasColumnName(@"TENY205").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Teny212).HasColumnName(@"TENY212").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Teny215).HasColumnName(@"TENY215").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Teny220).HasColumnName(@"TENY220").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Teny225).HasColumnName(@"TENY225").HasColumnType("datetime").IsRequired();
            Property(x => x.Teny250).HasColumnName(@"TENY250").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Teny255).HasColumnName(@"TENY255").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Teny360).HasColumnName(@"TENY360").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Teny180).HasColumnName(@"TENY180").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Teny185).HasColumnName(@"TENY185").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Teny031).HasColumnName(@"TENY031").HasColumnType("int").IsRequired();
        }
    }

}
