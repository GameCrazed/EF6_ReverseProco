

namespace Generator
{

    public class NbegMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbeg>
    {
        public NbegMapping()
            : this("dbo")
        {
        }

        public NbegMapping(string schema)
        {
            ToTable("NBEG", schema);
            HasKey(x => x.Nbeg999);

            Property(x => x.Nbeg001).HasColumnName(@"NBEG001").HasColumnType("int").IsRequired();
            Property(x => x.Nbeg010).HasColumnName(@"NBEG010").HasColumnType("int").IsRequired();
            Property(x => x.Nbeg030).HasColumnName(@"NBEG030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Nbeg050).HasColumnName(@"NBEG050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Nbeg060).HasColumnName(@"NBEG060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbeg080).HasColumnName(@"NBEG080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbeg190).HasColumnName(@"NBEG190").HasColumnType("int").IsRequired();
            Property(x => x.Nbeg192).HasColumnName(@"NBEG192").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbeg999).HasColumnName(@"NBEG999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbeg995).HasColumnName(@"NBEG995").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
