

namespace Generator
{

    public class Ty31Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty31>
    {
        public Ty31Mapping()
            : this("dbo")
        {
        }

        public Ty31Mapping(string schema)
        {
            ToTable("TY31", schema);
            HasKey(x => x.Ty31001);

            Property(x => x.Ty31001).HasColumnName(@"TY31001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty31020).HasColumnName(@"TY31020").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ty31030).HasColumnName(@"TY31030").HasColumnType("tinyint").IsRequired();
        }
    }

}
