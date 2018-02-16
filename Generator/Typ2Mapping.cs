

namespace Generator
{

    public class Typ2Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Typ2>
    {
        public Typ2Mapping()
            : this("dbo")
        {
        }

        public Typ2Mapping(string schema)
        {
            ToTable("TYP2", schema);
            HasKey(x => x.Typ2001);

            Property(x => x.Typ2001).HasColumnName(@"TYP2001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Typ2010).HasColumnName(@"TYP2010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Typ2100).HasColumnName(@"TYP2100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Typ2Dtm).HasColumnName(@"TYP2DTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
