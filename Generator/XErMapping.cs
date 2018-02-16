

namespace Generator
{

    public class XErMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XEr>
    {
        public XErMapping()
            : this("dbo")
        {
        }

        public XErMapping(string schema)
        {
            ToTable("X__ER", schema);
            HasKey(x => new { x.XEr001, x.XEr002 });

            Property(x => x.XEr002).HasColumnName(@"X__ER002").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.XEr001).HasColumnName(@"X__ER001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(16).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.XErdtm).HasColumnName(@"X__ERDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
