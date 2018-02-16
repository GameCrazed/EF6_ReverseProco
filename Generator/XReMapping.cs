

namespace Generator
{

    public class XReMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XRe>
    {
        public XReMapping()
            : this("dbo")
        {
        }

        public XReMapping(string schema)
        {
            ToTable("X__RE", schema);
            HasKey(x => x.XRe001);

            Property(x => x.XRe001).HasColumnName(@"X__RE001").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.XRe003).HasColumnName(@"X__RE003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.XRe002).HasColumnName(@"X__RE002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.XRe004).HasColumnName(@"X__RE004").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.XRedtm).HasColumnName(@"X__REDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
