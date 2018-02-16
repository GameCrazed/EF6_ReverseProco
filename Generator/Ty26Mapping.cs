

namespace Generator
{

    public class Ty26Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty26>
    {
        public Ty26Mapping()
            : this("dbo")
        {
        }

        public Ty26Mapping(string schema)
        {
            ToTable("TY26", schema);
            HasKey(x => x.Ty26001);

            Property(x => x.Ty26001).HasColumnName(@"TY26001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty26010).HasColumnName(@"TY26010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty26100).HasColumnName(@"TY26100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
