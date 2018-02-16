

namespace Generator
{

    public class XindMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Xind>
    {
        public XindMapping()
            : this("dbo")
        {
        }

        public XindMapping(string schema)
        {
            ToTable("XIND", schema);
            HasKey(x => new { x.Xind010, x.Xind011 });

            Property(x => x.Xind010).HasColumnName(@"XIND010").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xind011).HasColumnName(@"XIND011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xind015).HasColumnName(@"XIND015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xind020).HasColumnName(@"XIND020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Xind030).HasColumnName(@"XIND030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
