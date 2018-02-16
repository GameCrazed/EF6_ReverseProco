

namespace Generator
{

    public class XPcrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XPcr>
    {
        public XPcrMapping()
            : this("dbo")
        {
        }

        public XPcrMapping(string schema)
        {
            ToTable("X_PCR", schema);
            HasKey(x => x.XPcr001);

            Property(x => x.XPcr001).HasColumnName(@"X_PCR001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.XPcr002).HasColumnName(@"X_PCR002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.XPcr003).HasColumnName(@"X_PCR003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.XPcr004).HasColumnName(@"X_PCR004").HasColumnType("datetime").IsRequired();
            Property(x => x.XPcr005).HasColumnName(@"X_PCR005").HasColumnType("datetime").IsRequired();
            Property(x => x.XPcr006).HasColumnName(@"X_PCR006").HasColumnType("datetime").IsRequired();
            Property(x => x.XPcr007).HasColumnName(@"X_PCR007").HasColumnType("tinyint").IsRequired();
            Property(x => x.XPcr008).HasColumnName(@"X_PCR008").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.XPcr020).HasColumnName(@"X_PCR020").HasColumnType("int").IsRequired();
            Property(x => x.XPcr021).HasColumnName(@"X_PCR021").HasColumnType("int").IsRequired();
        }
    }

}
