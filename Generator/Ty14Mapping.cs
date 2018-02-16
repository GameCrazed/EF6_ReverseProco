

namespace Generator
{

    public class Ty14Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty14>
    {
        public Ty14Mapping()
            : this("dbo")
        {
        }

        public Ty14Mapping(string schema)
        {
            ToTable("TY14", schema);
            HasKey(x => x.Ty14001);

            Property(x => x.Ty14001).HasColumnName(@"TY14001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty14010).HasColumnName(@"TY14010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty14020).HasColumnName(@"TY14020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ty14030).HasColumnName(@"TY14030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
        }
    }

}
