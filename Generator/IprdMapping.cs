

namespace Generator
{

    public class IprdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Iprd>
    {
        public IprdMapping()
            : this("dbo")
        {
        }

        public IprdMapping(string schema)
        {
            ToTable("IPRD", schema);
            HasKey(x => x.Iprd000);

            Property(x => x.Iprd000).HasColumnName(@"IPRD000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Iprd001).HasColumnName(@"IPRD001").HasColumnType("int").IsRequired();
            Property(x => x.Iprd002).HasColumnName(@"IPRD002").HasColumnType("int").IsRequired();
            Property(x => x.Iprd020).HasColumnName(@"IPRD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Iprd030).HasColumnName(@"IPRD030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Iprd040).HasColumnName(@"IPRD040").HasColumnType("datetime").IsRequired();
            Property(x => x.Iprd050).HasColumnName(@"IPRD050").HasColumnType("datetime").IsRequired();
            Property(x => x.Iprd060).HasColumnName(@"IPRD060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
