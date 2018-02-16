

namespace Generator
{

    public class Typ1Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Typ1>
    {
        public Typ1Mapping()
            : this("dbo")
        {
        }

        public Typ1Mapping(string schema)
        {
            ToTable("TYP1", schema);
            HasKey(x => x.Typ1001);

            Property(x => x.Typ1001).HasColumnName(@"TYP1001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Typ1010).HasColumnName(@"TYP1010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Typ1100).HasColumnName(@"TYP1100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Typ1Dtm).HasColumnName(@"TYP1DTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
