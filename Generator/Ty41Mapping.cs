

namespace Generator
{

    public class Ty41Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty41>
    {
        public Ty41Mapping()
            : this("dbo")
        {
        }

        public Ty41Mapping(string schema)
        {
            ToTable("TY41", schema);
            HasKey(x => x.Ty41010);

            Property(x => x.Ty41010).HasColumnName(@"TY41010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty41020).HasColumnName(@"TY41020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Ty41030).HasColumnName(@"TY41030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
        }
    }

}
