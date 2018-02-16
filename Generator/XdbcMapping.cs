

namespace Generator
{

    public class XdbcMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Xdbc>
    {
        public XdbcMapping()
            : this("dbo")
        {
        }

        public XdbcMapping(string schema)
        {
            ToTable("XDBC", schema);
            HasKey(x => new { x.Xdbc010, x.Xdbc020 });

            Property(x => x.Xdbc010).HasColumnName(@"XDBC010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xdbc020).HasColumnName(@"XDBC020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xdbc030).HasColumnName(@"XDBC030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Xdbc040).HasColumnName(@"XDBC040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
        }
    }

}
