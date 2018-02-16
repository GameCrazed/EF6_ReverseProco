

namespace Generator
{

    public class Typ8Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Typ8>
    {
        public Typ8Mapping()
            : this("dbo")
        {
        }

        public Typ8Mapping(string schema)
        {
            ToTable("TYP8", schema);
            HasKey(x => x.Typ8001);

            Property(x => x.Typ8001).HasColumnName(@"TYP8001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Typ8010).HasColumnName(@"TYP8010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(110);
            Property(x => x.Typ8100).HasColumnName(@"TYP8100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Typ8Dtm).HasColumnName(@"TYP8DTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Typ8350).HasColumnName(@"TYP8350").HasColumnType("int").IsRequired();
            Property(x => x.Typ8360).HasColumnName(@"TYP8360").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
