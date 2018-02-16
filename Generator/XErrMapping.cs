

namespace Generator
{

    public class XErrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XErr>
    {
        public XErrMapping()
            : this("dbo")
        {
        }

        public XErrMapping(string schema)
        {
            ToTable("X_ERR", schema);
            HasKey(x => x.XErr001);

            Property(x => x.XErr001).HasColumnName(@"X_ERR001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.XErr002).HasColumnName(@"X_ERR002").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(340);
            Property(x => x.XErr003).HasColumnName(@"X_ERR003").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.XErrdtm).HasColumnName(@"X_ERRDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.XErr004).HasColumnName(@"X_ERR004").HasColumnType("int").IsOptional();
            Property(x => x.XErr005).HasColumnName(@"X_ERR005").HasColumnType("datetime").IsRequired();
            Property(x => x.XErr006).HasColumnName(@"X_ERR006").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.XErr007).HasColumnName(@"X_ERR007").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
        }
    }

}
