

namespace Generator
{

    public class Ty33Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty33>
    {
        public Ty33Mapping()
            : this("dbo")
        {
        }

        public Ty33Mapping(string schema)
        {
            ToTable("TY33", schema);
            HasKey(x => x.Ty33001);

            Property(x => x.Ty33001).HasColumnName(@"TY33001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty33010).HasColumnName(@"TY33010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty33100).HasColumnName(@"TY33100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Ty33200).HasColumnName(@"TY33200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty33300).HasColumnName(@"TY33300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
