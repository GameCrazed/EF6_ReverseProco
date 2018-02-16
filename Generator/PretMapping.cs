

namespace Generator
{

    public class PretMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pret>
    {
        public PretMapping()
            : this("dbo")
        {
        }

        public PretMapping(string schema)
        {
            ToTable("PRET", schema);
            HasKey(x => x.Pret001);

            Property(x => x.Pret001).HasColumnName(@"PRET001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pret010).HasColumnName(@"PRET010").HasColumnType("int").IsRequired();
            Property(x => x.Pret020).HasColumnName(@"PRET020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Pret053).HasColumnName(@"PRET053").HasColumnType("smallint").IsRequired();
            Property(x => x.Pret055).HasColumnName(@"PRET055").HasColumnType("int").IsRequired();
            Property(x => x.Pret064).HasColumnName(@"PRET064").HasColumnType("int").IsRequired();
            Property(x => x.Pret100).HasColumnName(@"PRET100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pret110).HasColumnName(@"PRET110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pret120).HasColumnName(@"PRET120").HasColumnType("int").IsRequired();
            Property(x => x.Pret200).HasColumnName(@"PRET200").HasColumnType("smallint").IsRequired();
            Property(x => x.Pret210).HasColumnName(@"PRET210").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pret290).HasColumnName(@"PRET290").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pret140).HasColumnName(@"PRET140").HasColumnType("datetime").IsRequired();
        }
    }

}
