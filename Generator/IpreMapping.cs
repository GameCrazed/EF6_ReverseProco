

namespace Generator
{

    public class IpreMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ipre>
    {
        public IpreMapping()
            : this("dbo")
        {
        }

        public IpreMapping(string schema)
        {
            ToTable("IPRE", schema);
            HasKey(x => x.Ipre999);

            Property(x => x.Ipre001).HasColumnName(@"IPRE001").HasColumnType("int").IsRequired();
            Property(x => x.Ipre005).HasColumnName(@"IPRE005").HasColumnType("datetime").IsRequired();
            Property(x => x.Ipre010).HasColumnName(@"IPRE010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ipre020).HasColumnName(@"IPRE020").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ipre060).HasColumnName(@"IPRE060").HasColumnType("int").IsRequired();
            Property(x => x.Ipre150).HasColumnName(@"IPRE150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ipre155).HasColumnName(@"IPRE155").HasColumnType("datetime").IsRequired();
            Property(x => x.Ipre999).HasColumnName(@"IPRE999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
