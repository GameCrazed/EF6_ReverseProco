

namespace Generator
{

    public class Typ3Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Typ3>
    {
        public Typ3Mapping()
            : this("dbo")
        {
        }

        public Typ3Mapping(string schema)
        {
            ToTable("TYP3", schema);
            HasKey(x => x.Typ3001);

            Property(x => x.Typ3001).HasColumnName(@"TYP3001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Typ3010).HasColumnName(@"TYP3010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Typ3100).HasColumnName(@"TYP3100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Typ3200).HasColumnName(@"TYP3200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Typ3Dtm).HasColumnName(@"TYP3DTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Typ3300).HasColumnName(@"TYP3300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Typ3601).HasColumnName(@"TYP3601").HasColumnType("tinyint").IsRequired();
        }
    }

}
