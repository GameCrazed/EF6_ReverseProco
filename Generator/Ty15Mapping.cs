

namespace Generator
{

    public class Ty15Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty15>
    {
        public Ty15Mapping()
            : this("dbo")
        {
        }

        public Ty15Mapping(string schema)
        {
            ToTable("TY15", schema);
            HasKey(x => x.Ty15001);

            Property(x => x.Ty15001).HasColumnName(@"TY15001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty15010).HasColumnName(@"TY15010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty15100).HasColumnName(@"TY15100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
