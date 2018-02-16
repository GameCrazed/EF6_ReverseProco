

namespace Generator
{

    public class Ty25Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty25>
    {
        public Ty25Mapping()
            : this("dbo")
        {
        }

        public Ty25Mapping(string schema)
        {
            ToTable("TY25", schema);
            HasKey(x => x.Ty25001);

            Property(x => x.Ty25001).HasColumnName(@"TY25001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty25010).HasColumnName(@"TY25010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty25100).HasColumnName(@"TY25100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty25200).HasColumnName(@"TY25200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
        }
    }

}
