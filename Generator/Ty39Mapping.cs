

namespace Generator
{

    public class Ty39Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty39>
    {
        public Ty39Mapping()
            : this("dbo")
        {
        }

        public Ty39Mapping(string schema)
        {
            ToTable("TY39", schema);
            HasKey(x => x.Ty39999);

            Property(x => x.Ty39999).HasColumnName(@"TY39999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ty39010).HasColumnName(@"TY39010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ty39020).HasColumnName(@"TY39020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ty39030).HasColumnName(@"TY39030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Ty39050).HasColumnName(@"TY39050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
