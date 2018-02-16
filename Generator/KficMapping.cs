

namespace Generator
{

    public class KficMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Kfic>
    {
        public KficMapping()
            : this("dbo")
        {
        }

        public KficMapping(string schema)
        {
            ToTable("KFIC", schema);
            HasKey(x => x.Kfic001);

            Property(x => x.Kfic000).HasColumnName(@"KFIC000").HasColumnType("int").IsRequired();
            Property(x => x.Kfic001).HasColumnName(@"KFIC001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Kfic002).HasColumnName(@"KFIC002").HasColumnType("int").IsRequired();
            Property(x => x.Kfic020).HasColumnName(@"KFIC020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfic030).HasColumnName(@"KFIC030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfic040).HasColumnName(@"KFIC040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfic050).HasColumnName(@"KFIC050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfic060).HasColumnName(@"KFIC060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfic070).HasColumnName(@"KFIC070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfic080).HasColumnName(@"KFIC080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfic090).HasColumnName(@"KFIC090").HasColumnType("datetime").IsRequired();
            Property(x => x.Kfic200).HasColumnName(@"KFIC200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Kfic210).HasColumnName(@"KFIC210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Kfic220).HasColumnName(@"KFIC220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Kfic230).HasColumnName(@"KFIC230").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfic240).HasColumnName(@"KFIC240").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfic250).HasColumnName(@"KFIC250").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfic260).HasColumnName(@"KFIC260").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfic900).HasColumnName(@"KFIC900").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfic910).HasColumnName(@"KFIC910").HasColumnType("datetime").IsRequired();
            Property(x => x.Kfic920).HasColumnName(@"KFIC920").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfic930).HasColumnName(@"KFIC930").HasColumnType("datetime").IsRequired();
            Property(x => x.Kfic270).HasColumnName(@"KFIC270").HasColumnType("int").IsRequired();
        }
    }

}
