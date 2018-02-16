

namespace Generator
{

    public class Typ4Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Typ4>
    {
        public Typ4Mapping()
            : this("dbo")
        {
        }

        public Typ4Mapping(string schema)
        {
            ToTable("TYP4", schema);
            HasKey(x => x.Typ4001);

            Property(x => x.Typ4001).HasColumnName(@"TYP4001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Typ4010).HasColumnName(@"TYP4010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Typ4100).HasColumnName(@"TYP4100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Typ4Dtm).HasColumnName(@"TYP4DTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
