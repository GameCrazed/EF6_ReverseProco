

namespace Generator
{

    public class NbiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbi>
    {
        public NbiMapping()
            : this("dbo")
        {
        }

        public NbiMapping(string schema)
        {
            ToTable("NBIS", schema);
            HasKey(x => x.Nbis999);

            Property(x => x.Nbis010).HasColumnName(@"NBIS010").HasColumnType("int").IsRequired();
            Property(x => x.Nbis050).HasColumnName(@"NBIS050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Nbis060).HasColumnName(@"NBIS060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(8000);
            Property(x => x.Nbis070).HasColumnName(@"NBIS070").HasColumnType("int").IsRequired();
            Property(x => x.Nbis080).HasColumnName(@"NBIS080").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbis100).HasColumnName(@"NBIS100").HasColumnType("int").IsRequired();
            Property(x => x.Nbis110).HasColumnName(@"NBIS110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbis120).HasColumnName(@"NBIS120").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Nbis999).HasColumnName(@"NBIS999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbis140).HasColumnName(@"NBIS140").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
        }
    }

}
