

namespace Generator
{

    public class Typ9Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Typ9>
    {
        public Typ9Mapping()
            : this("dbo")
        {
        }

        public Typ9Mapping(string schema)
        {
            ToTable("TYP9", schema);
            HasKey(x => x.Typ9001);

            Property(x => x.Typ9001).HasColumnName(@"TYP9001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Typ9010).HasColumnName(@"TYP9010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Typ9100).HasColumnName(@"TYP9100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Typ9Dtm).HasColumnName(@"TYP9DTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
