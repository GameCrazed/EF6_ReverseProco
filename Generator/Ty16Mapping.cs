

namespace Generator
{

    public class Ty16Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty16>
    {
        public Ty16Mapping()
            : this("dbo")
        {
        }

        public Ty16Mapping(string schema)
        {
            ToTable("TY16", schema);
            HasKey(x => x.Ty16001);

            Property(x => x.Ty16001).HasColumnName(@"TY16001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty16010).HasColumnName(@"TY16010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ty16100).HasColumnName(@"TY16100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
