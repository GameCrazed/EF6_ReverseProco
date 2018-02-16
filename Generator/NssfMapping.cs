

namespace Generator
{

    public class NssfMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nssf>
    {
        public NssfMapping()
            : this("dbo")
        {
        }

        public NssfMapping(string schema)
        {
            ToTable("NSSF", schema);
            HasKey(x => x.Nssf999);

            Property(x => x.Nssf001).HasColumnName(@"NSSF001").HasColumnType("int").IsRequired();
            Property(x => x.Nssf010).HasColumnName(@"NSSF010").HasColumnType("datetime").IsRequired();
            Property(x => x.Nssf020).HasColumnName(@"NSSF020").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nssf030).HasColumnName(@"NSSF030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nssf040).HasColumnName(@"NSSF040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nssf048).HasColumnName(@"NSSF048").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Nssf999).HasColumnName(@"NSSF999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
