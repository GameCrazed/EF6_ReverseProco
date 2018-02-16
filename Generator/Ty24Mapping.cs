

namespace Generator
{

    public class Ty24Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty24>
    {
        public Ty24Mapping()
            : this("dbo")
        {
        }

        public Ty24Mapping(string schema)
        {
            ToTable("TY24", schema);
            HasKey(x => x.Ty24001);

            Property(x => x.Ty24001).HasColumnName(@"TY24001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty24010).HasColumnName(@"TY24010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty24100).HasColumnName(@"TY24100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
