

namespace Generator
{

    public class Ty12Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty12>
    {
        public Ty12Mapping()
            : this("dbo")
        {
        }

        public Ty12Mapping(string schema)
        {
            ToTable("TY12", schema);
            HasKey(x => x.Ty12001);

            Property(x => x.Ty12001).HasColumnName(@"TY12001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty12010).HasColumnName(@"TY12010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty12100).HasColumnName(@"TY12100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty12400).HasColumnName(@"TY12400").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ty12410).HasColumnName(@"TY12410").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ty12420).HasColumnName(@"TY12420").HasColumnType("int").IsRequired();
            Property(x => x.Ty12601).HasColumnName(@"TY12601").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ty12602).HasColumnName(@"TY12602").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ty12603).HasColumnName(@"TY12603").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ty12604).HasColumnName(@"TY12604").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ty12Dtm).HasColumnName(@"TY12DTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Ty12700).HasColumnName(@"TY12700").HasColumnType("int").IsRequired();
        }
    }

}
