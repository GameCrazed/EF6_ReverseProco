

namespace Generator
{

    public class Ty18Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty18>
    {
        public Ty18Mapping()
            : this("dbo")
        {
        }

        public Ty18Mapping(string schema)
        {
            ToTable("TY18", schema);
            HasKey(x => x.Ty18001);

            Property(x => x.Ty18001).HasColumnName(@"TY18001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty18010).HasColumnName(@"TY18010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty18100).HasColumnName(@"TY18100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
