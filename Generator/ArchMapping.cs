

namespace Generator
{

    public class ArchMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Arch>
    {
        public ArchMapping()
            : this("dbo")
        {
        }

        public ArchMapping(string schema)
        {
            ToTable("ARCH", schema);
            HasKey(x => x.Arch999);

            Property(x => x.Arch001).HasColumnName(@"ARCH001").HasColumnType("int").IsRequired();
            Property(x => x.Arch010).HasColumnName(@"ARCH010").HasColumnType("int").IsRequired();
            Property(x => x.Arch013).HasColumnName(@"ARCH013").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Arch014).HasColumnName(@"ARCH014").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Arch020).HasColumnName(@"ARCH020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Arch030).HasColumnName(@"ARCH030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Arch040).HasColumnName(@"ARCH040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Arch050).HasColumnName(@"ARCH050").HasColumnType("datetime").IsRequired();
            Property(x => x.Arch060).HasColumnName(@"ARCH060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Arch070).HasColumnName(@"ARCH070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Arch080).HasColumnName(@"ARCH080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Arch090).HasColumnName(@"ARCH090").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Arch100).HasColumnName(@"ARCH100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Arch110).HasColumnName(@"ARCH110").HasColumnType("smallint").IsRequired();
            Property(x => x.Arch120).HasColumnName(@"ARCH120").HasColumnType("datetime").IsRequired();
            Property(x => x.Arch999).HasColumnName(@"ARCH999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
