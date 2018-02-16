

namespace Generator
{

    public class Ty40Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty40>
    {
        public Ty40Mapping()
            : this("dbo")
        {
        }

        public Ty40Mapping(string schema)
        {
            ToTable("TY40", schema);
            HasKey(x => x.Ty40999);

            Property(x => x.Ty40001).HasColumnName(@"TY40001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ty40010).HasColumnName(@"TY40010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Ty40100).HasColumnName(@"TY40100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ty40110).HasColumnName(@"TY40110").HasColumnType("int").IsRequired();
            Property(x => x.Ty40999).HasColumnName(@"TY40999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
