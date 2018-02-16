

namespace Generator
{

    public class Ty28Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty28>
    {
        public Ty28Mapping()
            : this("dbo")
        {
        }

        public Ty28Mapping(string schema)
        {
            ToTable("TY28", schema);
            HasKey(x => x.Ty28001);

            Property(x => x.Ty28001).HasColumnName(@"TY28001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ty28010).HasColumnName(@"TY28010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ty28350).HasColumnName(@"TY28350").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Ty28360).HasColumnName(@"TY28360").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
