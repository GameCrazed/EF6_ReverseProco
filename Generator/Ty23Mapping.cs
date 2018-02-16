

namespace Generator
{

    public class Ty23Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty23>
    {
        public Ty23Mapping()
            : this("dbo")
        {
        }

        public Ty23Mapping(string schema)
        {
            ToTable("TY23", schema);
            HasKey(x => x.Ty23001);

            Property(x => x.Ty23001).HasColumnName(@"TY23001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty23010).HasColumnName(@"TY23010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty23100).HasColumnName(@"TY23100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
