

namespace Generator
{

    public class XnoteMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Xnote>
    {
        public XnoteMapping()
            : this("dbo")
        {
        }

        public XnoteMapping(string schema)
        {
            ToTable("XNOTE", schema);
            HasKey(x => new { x.Xnote010, x.Xnote020 });

            Property(x => x.Xnote010).HasColumnName(@"XNOTE010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xnote020).HasColumnName(@"XNOTE020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xnote030).HasColumnName(@"XNOTE030").HasColumnType("int").IsRequired();
            Property(x => x.Xnote040).HasColumnName(@"XNOTE040").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.Xnote050).HasColumnName(@"XNOTE050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Xnote060).HasColumnName(@"XNOTE060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Xnote120).HasColumnName(@"XNOTE120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Xnote070).HasColumnName(@"XNOTE070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Xnote080).HasColumnName(@"XNOTE080").HasColumnType("int").IsRequired();
            Property(x => x.Xnote100).HasColumnName(@"XNOTE100").HasColumnType("int").IsRequired();
            Property(x => x.Xnote110).HasColumnName(@"XNOTE110").HasColumnType("smallint").IsRequired();
            Property(x => x.Xnote090).HasColumnName(@"XNOTE090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(75);
        }
    }

}
