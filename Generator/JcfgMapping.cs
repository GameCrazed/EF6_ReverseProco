

namespace Generator
{

    public class JcfgMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Jcfg>
    {
        public JcfgMapping()
            : this("dbo")
        {
        }

        public JcfgMapping(string schema)
        {
            ToTable("JCFG", schema);
            HasKey(x => x.Jcfg001);

            Property(x => x.Jcfg001).HasColumnName(@"JCFG001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Jcfg010).HasColumnName(@"JCFG010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Jcfg020).HasColumnName(@"JCFG020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Jcfg030).HasColumnName(@"JCFG030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jcfg040).HasColumnName(@"JCFG040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(400);
            Property(x => x.Jcfg050).HasColumnName(@"JCFG050").HasColumnType("datetime").IsRequired();
            Property(x => x.Jcfg060).HasColumnName(@"JCFG060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Jcfg070).HasColumnName(@"JCFG070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Jcfg080).HasColumnName(@"JCFG080").HasColumnType("datetime").IsRequired();
            Property(x => x.Jcfg090).HasColumnName(@"JCFG090").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Jcfg100).HasColumnName(@"JCFG100").HasColumnType("tinyint").IsRequired();
            Property(x => x.Jcfg101).HasColumnName(@"JCFG101").HasColumnType("int").IsRequired();
            Property(x => x.Jcfg110).HasColumnName(@"JCFG110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jcfg111).HasColumnName(@"JCFG111").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
