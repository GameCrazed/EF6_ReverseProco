

namespace Generator
{

    public class NbadMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbad>
    {
        public NbadMapping()
            : this("dbo")
        {
        }

        public NbadMapping(string schema)
        {
            ToTable("NBAD", schema);
            HasKey(x => x.Nbad999);

            Property(x => x.Nbad001).HasColumnName(@"NBAD001").HasColumnType("int").IsRequired();
            Property(x => x.Nbad005).HasColumnName(@"NBAD005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbad010).HasColumnName(@"NBAD010").HasColumnType("int").IsRequired();
            Property(x => x.Nbad020).HasColumnName(@"NBAD020").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbad030).HasColumnName(@"NBAD030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Nbad035).HasColumnName(@"NBAD035").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Nbad040).HasColumnName(@"NBAD040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Nbad050).HasColumnName(@"NBAD050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Nbad060).HasColumnName(@"NBAD060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbad070).HasColumnName(@"NBAD070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbad080).HasColumnName(@"NBAD080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbad085).HasColumnName(@"NBAD085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbad090).HasColumnName(@"NBAD090").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Nbad100).HasColumnName(@"NBAD100").HasColumnType("int").IsRequired();
            Property(x => x.Nbad999).HasColumnName(@"NBAD999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbad990).HasColumnName(@"NBAD990").HasColumnType("int").IsRequired();
            Property(x => x.Nbad995).HasColumnName(@"NBAD995").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
