

namespace Generator
{

    public class XinMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Xin>
    {
        public XinMapping()
            : this("dbo")
        {
        }

        public XinMapping(string schema)
        {
            ToTable("XINS", schema);
            HasKey(x => new { x.Xins010, x.Xins011 });

            Property(x => x.Xins010).HasColumnName(@"XINS010").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xins011).HasColumnName(@"XINS011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xins015).HasColumnName(@"XINS015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xins020).HasColumnName(@"XINS020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Xins030).HasColumnName(@"XINS030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Xins040).HasColumnName(@"XINS040").HasColumnType("tinyint").IsRequired();
        }
    }

}
