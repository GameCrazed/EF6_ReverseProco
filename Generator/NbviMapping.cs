

namespace Generator
{

    public class NbviMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbvi>
    {
        public NbviMapping()
            : this("dbo")
        {
        }

        public NbviMapping(string schema)
        {
            ToTable("NBVI", schema);
            HasKey(x => x.Nbvi999);

            Property(x => x.Nbvi001).HasColumnName(@"NBVI001").HasColumnType("int").IsRequired();
            Property(x => x.Nbvi010).HasColumnName(@"NBVI010").HasColumnType("int").IsRequired();
            Property(x => x.Nbvi015).HasColumnName(@"NBVI015").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbvi020).HasColumnName(@"NBVI020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Nbvi021).HasColumnName(@"NBVI021").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbvi025).HasColumnName(@"NBVI025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbvi030).HasColumnName(@"NBVI030").HasColumnType("int").IsRequired();
            Property(x => x.Nbvi035).HasColumnName(@"NBVI035").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbvi060).HasColumnName(@"NBVI060").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbvi080).HasColumnName(@"NBVI080").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbvi085).HasColumnName(@"NBVI085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbvi122).HasColumnName(@"NBVI122").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbvi999).HasColumnName(@"NBVI999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
