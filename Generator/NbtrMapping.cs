

namespace Generator
{

    public class NbtrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbtr>
    {
        public NbtrMapping()
            : this("dbo")
        {
        }

        public NbtrMapping(string schema)
        {
            ToTable("NBTR", schema);
            HasKey(x => x.Nbtr999);

            Property(x => x.Nbtr001).HasColumnName(@"NBTR001").HasColumnType("int").IsRequired();
            Property(x => x.Nbtr002).HasColumnName(@"NBTR002").HasColumnType("int").IsRequired();
            Property(x => x.Nbtr020).HasColumnName(@"NBTR020").HasColumnType("int").IsRequired();
            Property(x => x.Nbtr030).HasColumnName(@"NBTR030").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbtr040).HasColumnName(@"NBTR040").HasColumnType("int").IsRequired();
            Property(x => x.Nbtr045).HasColumnName(@"NBTR045").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Nbtr050).HasColumnName(@"NBTR050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbtr060).HasColumnName(@"NBTR060").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbtr070).HasColumnName(@"NBTR070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbtr080).HasColumnName(@"NBTR080").HasColumnType("int").IsRequired();
            Property(x => x.Nbtr090).HasColumnName(@"NBTR090").HasColumnType("int").IsRequired();
            Property(x => x.Nbtr130).HasColumnName(@"NBTR130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbtr150).HasColumnName(@"NBTR150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Nbtr160).HasColumnName(@"NBTR160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Nbtr180).HasColumnName(@"NBTR180").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Nbtr190).HasColumnName(@"NBTR190").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Nbtr999).HasColumnName(@"NBTR999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbtr035).HasColumnName(@"NBTR035").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbtr995).HasColumnName(@"NBTR995").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
