

namespace Generator
{

    public class Ty21Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty21>
    {
        public Ty21Mapping()
            : this("dbo")
        {
        }

        public Ty21Mapping(string schema)
        {
            ToTable("TY21", schema);
            HasKey(x => x.Ty21001);

            Property(x => x.Ty21001).HasColumnName(@"TY21001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty21010).HasColumnName(@"TY21010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty21100).HasColumnName(@"TY21100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty21200).HasColumnName(@"TY21200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
