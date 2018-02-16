

namespace Generator
{

    public class Ty13Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty13>
    {
        public Ty13Mapping()
            : this("dbo")
        {
        }

        public Ty13Mapping(string schema)
        {
            ToTable("TY13", schema);
            HasKey(x => x.Ty13001);

            Property(x => x.Ty13001).HasColumnName(@"TY13001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty13010).HasColumnName(@"TY13010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty13100).HasColumnName(@"TY13100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty13Dtm).HasColumnName(@"TY13DTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
