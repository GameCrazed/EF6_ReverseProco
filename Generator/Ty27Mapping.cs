

namespace Generator
{

    public class Ty27Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty27>
    {
        public Ty27Mapping()
            : this("dbo")
        {
        }

        public Ty27Mapping(string schema)
        {
            ToTable("TY27", schema);
            HasKey(x => x.Ty27001);

            Property(x => x.Ty27001).HasColumnName(@"TY27001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty27010).HasColumnName(@"TY27010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty27100).HasColumnName(@"TY27100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty27200).HasColumnName(@"TY27200").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ty27210).HasColumnName(@"TY27210").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ty27220).HasColumnName(@"TY27220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty27300).HasColumnName(@"TY27300").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ty27310).HasColumnName(@"TY27310").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ty27320).HasColumnName(@"TY27320").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty27330).HasColumnName(@"TY27330").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
        }
    }

}
