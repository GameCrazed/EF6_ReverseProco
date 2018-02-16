

namespace Generator
{

    public class Ty34Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty34>
    {
        public Ty34Mapping()
            : this("dbo")
        {
        }

        public Ty34Mapping(string schema)
        {
            ToTable("TY34", schema);
            HasKey(x => x.Ty34001);

            Property(x => x.Ty34001).HasColumnName(@"TY34001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty34010).HasColumnName(@"TY34010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty34100).HasColumnName(@"TY34100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
