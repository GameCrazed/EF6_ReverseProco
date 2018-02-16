

namespace Generator
{

    public class NbpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbp>
    {
        public NbpMapping()
            : this("dbo")
        {
        }

        public NbpMapping(string schema)
        {
            ToTable("NBPS", schema);
            HasKey(x => x.Nbps999);

            Property(x => x.Nbps000).HasColumnName(@"NBPS000").HasColumnType("int").IsRequired();
            Property(x => x.Nbps005).HasColumnName(@"NBPS005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbps010).HasColumnName(@"NBPS010").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbps015).HasColumnName(@"NBPS015").HasColumnType("int").IsRequired();
            Property(x => x.Nbps017).HasColumnName(@"NBPS017").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbps020).HasColumnName(@"NBPS020").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbps025).HasColumnName(@"NBPS025").HasColumnType("int").IsRequired();
            Property(x => x.Nbps030).HasColumnName(@"NBPS030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbps050).HasColumnName(@"NBPS050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbps500).HasColumnName(@"NBPS500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Nbps999).HasColumnName(@"NBPS999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
