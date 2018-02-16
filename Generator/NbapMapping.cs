

namespace Generator
{

    public class NbapMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbap>
    {
        public NbapMapping()
            : this("dbo")
        {
        }

        public NbapMapping(string schema)
        {
            ToTable("NBAP", schema);
            HasKey(x => x.Nbap001);

            Property(x => x.Nbap001).HasColumnName(@"NBAP001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nbap010).HasColumnName(@"NBAP010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Nbap020).HasColumnName(@"NBAP020").HasColumnType("int").IsRequired();
            Property(x => x.Nbap030).HasColumnName(@"NBAP030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Nbap040).HasColumnName(@"NBAP040").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbap050).HasColumnName(@"NBAP050").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbap100).HasColumnName(@"NBAP100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Nbap200).HasColumnName(@"NBAP200").HasColumnType("int").IsRequired();
            Property(x => x.Nbap201).HasColumnName(@"NBAP201").HasColumnType("int").IsRequired();
            Property(x => x.Nbap202).HasColumnName(@"NBAP202").HasColumnType("int").IsRequired();
            Property(x => x.Nbap203).HasColumnName(@"NBAP203").HasColumnType("int").IsRequired();
            Property(x => x.Nbap204).HasColumnName(@"NBAP204").HasColumnType("int").IsRequired();
            Property(x => x.Nbap205).HasColumnName(@"NBAP205").HasColumnType("int").IsRequired();
            Property(x => x.Nbap206).HasColumnName(@"NBAP206").HasColumnType("int").IsRequired();
        }
    }

}
