

namespace Generator
{

    public class Ty29Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty29>
    {
        public Ty29Mapping()
            : this("dbo")
        {
        }

        public Ty29Mapping(string schema)
        {
            ToTable("TY29", schema);
            HasKey(x => x.Ty29001);

            Property(x => x.Ty29001).HasColumnName(@"TY29001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty29010).HasColumnName(@"TY29010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty29100).HasColumnName(@"TY29100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty29200).HasColumnName(@"TY29200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ty29350).HasColumnName(@"TY29350").HasColumnType("int").IsRequired();
        }
    }

}
