

namespace Generator
{

    public class Ty32Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty32>
    {
        public Ty32Mapping()
            : this("dbo")
        {
        }

        public Ty32Mapping(string schema)
        {
            ToTable("TY32", schema);
            HasKey(x => x.Ty32001);

            Property(x => x.Ty32001).HasColumnName(@"TY32001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ty32010).HasColumnName(@"TY32010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty32100).HasColumnName(@"TY32100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
