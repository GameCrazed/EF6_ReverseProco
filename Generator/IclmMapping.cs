

namespace Generator
{

    public class IclmMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Iclm>
    {
        public IclmMapping()
            : this("dbo")
        {
        }

        public IclmMapping(string schema)
        {
            ToTable("ICLM", schema);
            HasKey(x => x.Iclm000);

            Property(x => x.Iclm000).HasColumnName(@"ICLM000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Iclm001).HasColumnName(@"ICLM001").HasColumnType("int").IsRequired();
            Property(x => x.Iclm010).HasColumnName(@"ICLM010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Iclm020).HasColumnName(@"ICLM020").HasColumnType("datetime").IsRequired();
            Property(x => x.Iclm030).HasColumnName(@"ICLM030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Iclm040).HasColumnName(@"ICLM040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Iclm050).HasColumnName(@"ICLM050").HasColumnType("datetime").IsRequired();
        }
    }

}
