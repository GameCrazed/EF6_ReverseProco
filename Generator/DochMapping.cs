

namespace Generator
{

    public class DochMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Doch>
    {
        public DochMapping()
            : this("dbo")
        {
        }

        public DochMapping(string schema)
        {
            ToTable("DOCH", schema);
            HasKey(x => x.Doch001);

            Property(x => x.Doch001).HasColumnName(@"DOCH001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Doch003).HasColumnName(@"DOCH003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Doch010).HasColumnName(@"DOCH010").HasColumnType("int").IsRequired();
            Property(x => x.Doch015).HasColumnName(@"DOCH015").HasColumnType("int").IsRequired();
            Property(x => x.Doch030).HasColumnName(@"DOCH030").HasColumnType("int").IsRequired();
            Property(x => x.Doch035).HasColumnName(@"DOCH035").HasColumnType("datetime").IsRequired();
            Property(x => x.Doch045).HasColumnName(@"DOCH045").HasColumnType("datetime").IsRequired();
            Property(x => x.Doch050).HasColumnName(@"DOCH050").HasColumnType("int").IsRequired();
            Property(x => x.Doch055).HasColumnName(@"DOCH055").HasColumnType("datetime").IsRequired();
        }
    }

}
