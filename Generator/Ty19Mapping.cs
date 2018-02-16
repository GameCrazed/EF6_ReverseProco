

namespace Generator
{

    public class Ty19Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty19>
    {
        public Ty19Mapping()
            : this("dbo")
        {
        }

        public Ty19Mapping(string schema)
        {
            ToTable("TY19", schema);
            HasKey(x => x.Ty19001);

            Property(x => x.Ty19001).HasColumnName(@"TY19001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty19010).HasColumnName(@"TY19010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty19100).HasColumnName(@"TY19100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty19050).HasColumnName(@"TY19050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
        }
    }

}
