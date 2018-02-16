

namespace Generator
{

    public class NbdeMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbde>
    {
        public NbdeMapping()
            : this("dbo")
        {
        }

        public NbdeMapping(string schema)
        {
            ToTable("NBDE", schema);
            HasKey(x => x.Nbde999);

            Property(x => x.Nbde001).HasColumnName(@"NBDE001").HasColumnType("int").IsRequired();
            Property(x => x.Nbde002).HasColumnName(@"NBDE002").HasColumnType("int").IsRequired();
            Property(x => x.Nbde015).HasColumnName(@"NBDE015").HasColumnType("int").IsRequired();
            Property(x => x.Nbde020).HasColumnName(@"NBDE020").HasColumnType("int").IsRequired();
            Property(x => x.Nbde030).HasColumnName(@"NBDE030").HasColumnType("int").IsRequired();
            Property(x => x.Nbde035).HasColumnName(@"NBDE035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Nbde036).HasColumnName(@"NBDE036").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbde045).HasColumnName(@"NBDE045").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbde050).HasColumnName(@"NBDE050").HasColumnType("int").IsRequired();
            Property(x => x.Nbde500).HasColumnName(@"NBDE500").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Nbde999).HasColumnName(@"NBDE999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbde029).HasColumnName(@"NBDE029").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Nbde032).HasColumnName(@"NBDE032").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbde033).HasColumnName(@"NBDE033").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
