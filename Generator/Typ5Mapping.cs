

namespace Generator
{

    public class Typ5Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Typ5>
    {
        public Typ5Mapping()
            : this("dbo")
        {
        }

        public Typ5Mapping(string schema)
        {
            ToTable("TYP5", schema);
            HasKey(x => x.Typ5001);

            Property(x => x.Typ5001).HasColumnName(@"TYP5001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Typ5010).HasColumnName(@"TYP5010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Typ5100).HasColumnName(@"TYP5100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Typ5Dtm).HasColumnName(@"TYP5DTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
