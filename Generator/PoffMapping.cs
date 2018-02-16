

namespace Generator
{

    public class PoffMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Poff>
    {
        public PoffMapping()
            : this("dbo")
        {
        }

        public PoffMapping(string schema)
        {
            ToTable("POFF", schema);
            HasKey(x => x.Poff001);

            Property(x => x.Poff001).HasColumnName(@"POFF001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Poff010).HasColumnName(@"POFF010").HasColumnType("int").IsRequired();
            Property(x => x.Poff020).HasColumnName(@"POFF020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Poff053).HasColumnName(@"POFF053").HasColumnType("smallint").IsRequired();
            Property(x => x.Poff055).HasColumnName(@"POFF055").HasColumnType("int").IsRequired();
            Property(x => x.Poff064).HasColumnName(@"POFF064").HasColumnType("int").IsRequired();
            Property(x => x.Poff100).HasColumnName(@"POFF100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Poff110).HasColumnName(@"POFF110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Poff120).HasColumnName(@"POFF120").HasColumnType("int").IsRequired();
            Property(x => x.Poff200).HasColumnName(@"POFF200").HasColumnType("smallint").IsRequired();
            Property(x => x.Poff210).HasColumnName(@"POFF210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Poff140).HasColumnName(@"POFF140").HasColumnType("datetime").IsRequired();
        }
    }

}
