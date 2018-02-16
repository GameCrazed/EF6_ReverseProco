

namespace Generator
{

    public class RaopMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Raop>
    {
        public RaopMapping()
            : this("dbo")
        {
        }

        public RaopMapping(string schema)
        {
            ToTable("RAOP", schema);
            HasKey(x => x.Raop999);

            Property(x => x.Raop010).HasColumnName(@"RAOP010").HasColumnType("int").IsRequired();
            Property(x => x.Raop020).HasColumnName(@"RAOP020").HasColumnType("int").IsRequired();
            Property(x => x.Raop025).HasColumnName(@"RAOP025").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Raop030).HasColumnName(@"RAOP030").HasColumnType("int").IsRequired();
            Property(x => x.Raop031).HasColumnName(@"RAOP031").HasColumnType("int").IsRequired();
            Property(x => x.Raop040).HasColumnName(@"RAOP040").HasColumnType("datetime").IsRequired();
            Property(x => x.Raop999).HasColumnName(@"RAOP999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Raop080).HasColumnName(@"RAOP080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Raop090).HasColumnName(@"RAOP090").HasColumnType("datetime").IsRequired();
        }
    }

}
