

namespace Generator
{

    public class XGttMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XGtt>
    {
        public XGttMapping()
            : this("dbo")
        {
        }

        public XGttMapping(string schema)
        {
            ToTable("X_GTT", schema);
            HasKey(x => x.XGtt001);

            Property(x => x.XGtt001).HasColumnName(@"X_GTT001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.XGtt003).HasColumnName(@"X_GTT003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.XGtt004).HasColumnName(@"X_GTT004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.XGtt005).HasColumnName(@"X_GTT005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XGtt010).HasColumnName(@"X_GTT010").HasColumnType("int").IsRequired();
        }
    }

}
