

namespace Generator
{

    public class Typ7Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Typ7>
    {
        public Typ7Mapping()
            : this("dbo")
        {
        }

        public Typ7Mapping(string schema)
        {
            ToTable("TYP7", schema);
            HasKey(x => x.Typ7001);

            Property(x => x.Typ7001).HasColumnName(@"TYP7001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Typ7010).HasColumnName(@"TYP7010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Typ7100).HasColumnName(@"TYP7100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Typ7Dtm).HasColumnName(@"TYP7DTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Typ7200).HasColumnName(@"TYP7200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Typ7350).HasColumnName(@"TYP7350").HasColumnType("int").IsRequired();
        }
    }

}
