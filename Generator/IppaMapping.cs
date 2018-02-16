

namespace Generator
{

    public class IppaMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ippa>
    {
        public IppaMapping()
            : this("dbo")
        {
        }

        public IppaMapping(string schema)
        {
            ToTable("IPPA", schema);
            HasKey(x => x.Ippa000);

            Property(x => x.Ippa000).HasColumnName(@"IPPA000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ippa001).HasColumnName(@"IPPA001").HasColumnType("int").IsRequired();
            Property(x => x.Ippa002).HasColumnName(@"IPPA002").HasColumnType("int").IsRequired();
            Property(x => x.Ippa005).HasColumnName(@"IPPA005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ippa010).HasColumnName(@"IPPA010").HasColumnType("datetime").IsRequired();
            Property(x => x.Ippa020).HasColumnName(@"IPPA020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ippa021).HasColumnName(@"IPPA021").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ippa025).HasColumnName(@"IPPA025").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Ippa030).HasColumnName(@"IPPA030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ippa031).HasColumnName(@"IPPA031").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Ippa032).HasColumnName(@"IPPA032").HasColumnType("smallint").IsRequired();
            Property(x => x.Ippa033).HasColumnName(@"IPPA033").HasColumnType("int").IsRequired();
            Property(x => x.Ippa034).HasColumnName(@"IPPA034").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ippa035).HasColumnName(@"IPPA035").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Ippa036).HasColumnName(@"IPPA036").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Ippa037).HasColumnName(@"IPPA037").HasColumnType("datetime").IsRequired();
            Property(x => x.Ippa038).HasColumnName(@"IPPA038").HasColumnType("int").IsRequired();
            Property(x => x.Ippa039).HasColumnName(@"IPPA039").HasColumnType("tinyint").IsRequired();
        }
    }

}
