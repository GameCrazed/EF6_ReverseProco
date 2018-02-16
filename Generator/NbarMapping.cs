

namespace Generator
{

    public class NbarMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbar>
    {
        public NbarMapping()
            : this("dbo")
        {
        }

        public NbarMapping(string schema)
        {
            ToTable("NBAR", schema);
            HasKey(x => x.Nbar999);

            Property(x => x.Nbar001).HasColumnName(@"NBAR001").HasColumnType("int").IsRequired();
            Property(x => x.Nbar002).HasColumnName(@"NBAR002").HasColumnType("int").IsRequired();
            Property(x => x.Nbar015).HasColumnName(@"NBAR015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbar020).HasColumnName(@"NBAR020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbar030).HasColumnName(@"NBAR030").HasColumnType("int").IsRequired();
            Property(x => x.Nbar035).HasColumnName(@"NBAR035").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbar040).HasColumnName(@"NBAR040").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbar050).HasColumnName(@"NBAR050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbar055).HasColumnName(@"NBAR055").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbar110).HasColumnName(@"NBAR110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbar220).HasColumnName(@"NBAR220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbar999).HasColumnName(@"NBAR999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbar025).HasColumnName(@"NBAR025").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbar300).HasColumnName(@"NBAR300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbar031).HasColumnName(@"NBAR031").HasColumnType("int").IsRequired();
        }
    }

}
