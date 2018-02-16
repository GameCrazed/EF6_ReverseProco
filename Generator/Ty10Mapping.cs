

namespace Generator
{

    public class Ty10Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty10>
    {
        public Ty10Mapping()
            : this("dbo")
        {
        }

        public Ty10Mapping(string schema)
        {
            ToTable("TY10", schema);
            HasKey(x => x.Ty10001);

            Property(x => x.Ty10001).HasColumnName(@"TY10001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty10010).HasColumnName(@"TY10010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty10100).HasColumnName(@"TY10100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty10Dtm).HasColumnName(@"TY10DTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
