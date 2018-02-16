

namespace Generator
{

    public class Ty22Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty22>
    {
        public Ty22Mapping()
            : this("dbo")
        {
        }

        public Ty22Mapping(string schema)
        {
            ToTable("TY22", schema);
            HasKey(x => x.Ty22001);

            Property(x => x.Ty22001).HasColumnName(@"TY22001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty22010).HasColumnName(@"TY22010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty22100).HasColumnName(@"TY22100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty22200).HasColumnName(@"TY22200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
        }
    }

}
