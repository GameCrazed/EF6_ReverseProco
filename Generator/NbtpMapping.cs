

namespace Generator
{

    public class NbtpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbtp>
    {
        public NbtpMapping()
            : this("dbo")
        {
        }

        public NbtpMapping(string schema)
        {
            ToTable("NBTP", schema);
            HasKey(x => x.Nbtp999);

            Property(x => x.Nbtp001).HasColumnName(@"NBTP001").HasColumnType("int").IsRequired();
            Property(x => x.Nbtp002).HasColumnName(@"NBTP002").HasColumnType("int").IsRequired();
            Property(x => x.Nbtp010).HasColumnName(@"NBTP010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Nbtp020).HasColumnName(@"NBTP020").HasColumnType("int").IsRequired();
            Property(x => x.Nbtp030).HasColumnName(@"NBTP030").HasColumnType("int").IsRequired();
            Property(x => x.Nbtp999).HasColumnName(@"NBTP999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbtp995).HasColumnName(@"NBTP995").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
