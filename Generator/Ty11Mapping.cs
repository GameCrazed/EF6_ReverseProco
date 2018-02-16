

namespace Generator
{

    public class Ty11Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty11>
    {
        public Ty11Mapping()
            : this("dbo")
        {
        }

        public Ty11Mapping(string schema)
        {
            ToTable("TY11", schema);
            HasKey(x => x.Ty11001);

            Property(x => x.Ty11001).HasColumnName(@"TY11001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty11010).HasColumnName(@"TY11010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty11100).HasColumnName(@"TY11100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty11Dtm).HasColumnName(@"TY11DTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
