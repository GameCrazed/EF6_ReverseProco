

namespace Generator
{

    public class Typ6Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Typ6>
    {
        public Typ6Mapping()
            : this("dbo")
        {
        }

        public Typ6Mapping(string schema)
        {
            ToTable("TYP6", schema);
            HasKey(x => x.Typ6001);

            Property(x => x.Typ6001).HasColumnName(@"TYP6001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Typ6010).HasColumnName(@"TYP6010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Typ6100).HasColumnName(@"TYP6100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Typ6200).HasColumnName(@"TYP6200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Typ6210).HasColumnName(@"TYP6210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
