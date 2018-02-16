

namespace Generator
{

    public class XsfoMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Xsfo>
    {
        public XsfoMapping()
            : this("dbo")
        {
        }

        public XsfoMapping(string schema)
        {
            ToTable("XSFO", schema);
            HasKey(x => new { x.Xsfo001, x.Xsfo010 });

            Property(x => x.Xsfo001).HasColumnName(@"XSFO001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xsfo010).HasColumnName(@"XSFO010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xsfo020).HasColumnName(@"XSFO020").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
        }
    }

}
